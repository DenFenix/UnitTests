using Example4.Models;
using Example4.Repository.Implementation;
using Example4.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Example4.Controllers
{
    public class PointsController : Controller
    {
        public IRepository<Point> PointRepository { get; set; } = new Repository<Point>();
        public IActionResult Index()
        {
            return View(PointRepository.GetAll());
        }

        public IActionResult Details(int? id)
        {
            var point = PointRepository.Get(id.Value);
            return point == null ? NotFound() : View(point);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,X,Y")] Point poin)
        {
            if (ModelState.IsValid)
            {
                PointRepository.Create(poin);
                return RedirectToAction(nameof(Index));
            }
            return View(poin);
        }
    }
}
