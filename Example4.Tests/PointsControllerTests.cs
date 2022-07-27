using Example4.Controllers;
using Example4.Models;
using Example4.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4.Tests
{
    public class PointsControllerTests
    {
        private List<Point> _points = new List<Point> { 
            new Point { Id = 1, X = 10, Y = 10 }, 
            new Point { Id = 2, X = 20, Y = 20 },
            new Point { Id = 3, X = 30, Y = 30 }};
        private Mock<IRepository<Point>> _mock;
        private PointsController CreatePointsController()
        {
            _mock = new Mock<IRepository<Point>>();
            var controller = new PointsController();
            controller.PointRepository = _mock.Object;
            return controller;
        }

        [Fact]
        public void Index_ExecuteIndex_View()
        {
            var controller = CreatePointsController();

            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        //пошаговое создание подобных тестов можно посмотреть на https://metanit.com/sharp/aspnet5/22.5.php
        [Fact]
        public void Index_ActionIndex_3Poins()
        {
            var controller = CreatePointsController();
            _mock.Setup(x => x.GetAll()).Returns(_points);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var pointList = Assert.IsAssignableFrom<IEnumerable<Point>>(viewResult.Model);

            Assert.Equal<int>(3, pointList.Count());
        }

        [Fact]
        public void Details_IdMinus1_NotFound()
        {
            Point point = null;
            var controller = CreatePointsController();          
            _mock.Setup(x => x.Get(-1)).Returns(point);

            var result = controller.Details(-1);

            Assert.IsType<NotFoundResult>(result);
        }

        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Details_ValidIds_NotFound(int id)
        {
            var controller = CreatePointsController();
            var point = _points.First(x => x.Id == id);
            _mock.Setup(x => x.Get(id)).Returns(point);

            var result = controller.Details(id);

            var viewResult = Assert.IsType<ViewResult>(result);

            var resultPoint = Assert.IsAssignableFrom<Point>(viewResult.Model);

            Assert.Equal(point.Id, resultPoint.Id);
            Assert.Equal(point.X, resultPoint.X);
            Assert.Equal(point.Y, resultPoint.Y);
        }

        [Fact]
        public void Create_ExecuteCreate_View()
        {
            var controller = CreatePointsController();

            var result = controller.Create();
            Assert.IsType<ViewResult>(result);
        }

        //Ошибка ввежёггых данных
        [Fact]
        public void CreatePOST_InvalidModelState_ReturnView()
        {
            var controller = CreatePointsController();
            controller.ModelState.AddModelError("Id", "-1"); //todo уточнить
            var result = controller.Create(_points.First());

            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.IsType<Point>(viewResult.Model);
        }

        [Fact]
        public void CreatePOST_ExecuteCreate()
        {
            var controller = CreatePointsController();
            var result = controller.Create(_points.First());

            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName);
        }

        //подобные тесты с описанием каждой строчки можно найти у Фримана А.
        [Fact]
        public void CreatePOST_ValidModelState_CalledOnce()
        {
            var controller = CreatePointsController();

            Point point = null;
            var a = _mock.Setup(x => x.Create(It.IsAny<Point>())).Callback<Point>(x => point = x);

            var result = controller.Create(_points.First());
            //утверждение проверка что точка была сохранена
            _mock.Verify(x => x.Create(It.IsAny<Point>()), Times.Once);
            Assert.Equal(_points.First().Id, point.Id);
        }

    }
}
