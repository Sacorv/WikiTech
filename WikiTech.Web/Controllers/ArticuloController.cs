using Microsoft.AspNetCore.Mvc;
using WikiTech.Entidades;
using WikiTech.Logica;
using static System.Net.WebRequestMethods;

namespace WikiTech.Web.Controllers
{
    public class ArticuloController : Controller
    {

        private IArticuloServicio _articuloServicio;

        public ArticuloController(IArticuloServicio articuloServicio)
        {
            _articuloServicio = articuloServicio;
        }

        public async Task<IActionResult> ListarArticulos()
        {
            ViewBag.Articulos = await _articuloServicio.ObtenerArticulos();

            return View();
        }

        public async Task<IActionResult> VerArticulo(int id)
        {
            Articulo articulo = await _articuloServicio.BuscarArticulo(id);

            return View(articulo);
        }


        public IActionResult CrearArticulo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearArticulo(Articulo articulo)
        {
            _articuloServicio.GuardarArticulo(articulo);

            Thread.Sleep(400);

            return RedirectToAction("ListarArticulos");
        }


        public IActionResult EliminarArticulo(int id)
        {
            _articuloServicio.EliminarArticulo(id);

            Thread.Sleep(400);

            return RedirectToAction("ListarArticulos");
        }


        public IActionResult Modificar()
        {
            return View();
        }
    }
}
