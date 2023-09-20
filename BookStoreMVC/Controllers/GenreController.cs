using BookStoreMVC.Models.Domain;
using BookStoreMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreMVC.Controllers
{
    public class GenreController : Controller
    {

        private readonly IGenreService _service;
        public GenreController(IGenreService service)
        {
            _service = service;
        }


        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = _service.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully ";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error is occured on server side ";
            return View(model);


            return View();
        }

        public IActionResult Update(int id)
        {
            var record = _service.FindById(id);
            return View(record);
        }
        [HttpPost]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = _service.Update(model);
            if (result)
            {
               
                return RedirectToAction("GetAll");
            }
            TempData["msg"] = "Error is occured on server side ";
            return View(model);


            return View();
        }

        public IActionResult Delete(int id)
        {


            var result = _service.Delete(id);
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll(int id)
        {


            var data = _service.GetAll();
            return View(data);
        }

    }
}
