using L02P02_2021TH650_2021SC601.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L02P02_2021TH650_2021SC601.Controllers
{
    public class librosController : Controller
    {

        private readonly libreriaDbContext _libreriaDbContext;
        public librosController(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        public IActionResult Index()
        {
            var listaAutor = (from m in _libreriaDbContext.autores
                                 select m).ToList();
            ViewData["listautores"] = new SelectList(listaAutor, "id", "autor");
            return View();
        }


       
    }
}
