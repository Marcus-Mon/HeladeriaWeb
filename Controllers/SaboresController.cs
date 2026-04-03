using HeladeriaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace HeladeriaWeb.Controllers
{
    public class SaboresController : Controller
    {
        static List<SaborHelado> lista = new List<SaborHelado>();

        public IActionResult Index()
        {
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SaborHelado sabor)
        {
            sabor.Id = lista.Count + 1;
            lista.Add(sabor);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var sabor = lista.FirstOrDefault(s => s.Id == id);
            return View(sabor);
        }

        [HttpPost]
        public IActionResult Edit(SaborHelado sabor)
        {
            var s = lista.FirstOrDefault(x => x.Id == sabor.Id);
            s.Nombre = sabor.Nombre;
            s.Descripcion = sabor.Descripcion;
            s.Precio = sabor.Precio;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var sabor = lista.FirstOrDefault(s => s.Id == id);
            lista.Remove(sabor);
            return RedirectToAction("Index");
        }
    }
}
