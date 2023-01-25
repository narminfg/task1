using Microsoft.AspNetCore.Mvc;
using task1.Models;
namespace task1.Controllers
{
    public class ModelsController : Controller
    {
        private readonly List<Model> _models;
        public ModelsController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, ModelName = 118, BrandId = 1,Year=2005 },
                new Model { Id = 2, ModelName = 228, BrandId = 1,Year=2005 },
                new Model { Id = 3, ModelName = 312, BrandId = 2,Year=2009},
                new Model { Id = 4, ModelName = 418, BrandId = 2 ,Year = 2009},
                new Model { Id = 5, ModelName = 518, BrandId = 3 ,Year = 2010},
                new Model { Id = 6, ModelName = 618, BrandId = 3 ,Year = 2010},
            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_models);
            }
            if (_models.Exists(s => s.Id == id))
            {
                return View(_models.FindAll(s => s.Id == id));
            }
            else
            {
                return BadRequest();
            }

        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (_models.Exists(s => s.BrandId == id))
            {
                return View(_models.Find(s => s.BrandId == id));
            }
            else
            {
                return NotFound();
            }
        }
    }

}
