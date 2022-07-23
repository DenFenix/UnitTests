using Example4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace Example4.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_NameIndex_True()
        {
            var mock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mock.Object);

            var result = controller.Index() as ViewResult;
            Assert.NotNull(result);
        }
    }
}