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

            var listacateg = (from m in _libreriaDbContext.categorias
                              select m).ToList();
            ViewData["listcatg"] = new SelectList(listaAutor, "id", "categoria");

            var listadolibros = (from l in _libreriaDbContext.libros
                                 join a in _libreriaDbContext.autores on l.id_autor equals a.id
                                 join c in _libreriaDbContext.categorias on l.id_categoria equals c.id
                                 select new
                                 {
                                     nombrelibro=l.nombre,
                                     descripcion=l.descripcion,
                                     precio=l.precio,
                                     autor=a.autor,
                                     categoria=c.categoria
                                 } ).ToList();
            ViewData["listlibros"] = listadolibros;




            return View();
        }

        public IActionResult Crearlibro(libros nuevolibro)
        {
            _libreriaDbContext.Add(nuevolibro);
            _libreriaDbContext.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}
