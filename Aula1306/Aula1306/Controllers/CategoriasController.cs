using Aula1306.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aula1306.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {

            /*usando ViewBag
            List<string> categorias = new List<string>()
            {
                "Carros",
                "Motos",
                "Barcos",
                "Aviões",
                "Caminhões"
            };

            ViewBag.ListaCategorias = categorias;

            */

            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros" });
            categorias.Add(new Categoria() { Nome = "Motos" });
            categorias.Add(new Categoria() { Nome = "Barcos" });
            categorias.Add(new Categoria() { Nome = "Aviões" });
            categorias.Add(new Categoria() { Nome = "Caminhões" });

            return View(categorias);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}