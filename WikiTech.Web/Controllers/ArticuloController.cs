﻿using Microsoft.AspNetCore.Mvc;
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
            
            if(HttpContext.Session.GetString("token") != null)
            {
                ViewBag.Eliminar = true;
                ViewBag.Token = HttpContext.Session.GetString("token");
                ViewBag.usuario = HttpContext.Session.GetString("email");
            }
            else
            {
                ViewBag.Eliminar = false;
            }
            ViewBag.Articulos = await _articuloServicio.ObtenerArticulos();
            

            return View();
        }

        public async Task<IActionResult> VerArticulo(int id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                ViewBag.Eliminar = true;
            }
            else
            {
                ViewBag.Eliminar = false;
            }
            Articulo articulo = await _articuloServicio.BuscarArticulo(id);

            return View(articulo);
        }


        public async Task<IActionResult> CrearArticulo()

        {
            ViewBag.Categorias = await _articuloServicio.ObtenerCategorias(HttpContext);

            return View();
        }


        [HttpPost]
        public IActionResult CrearArticulo(Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                var sesion = HttpContext;

                _articuloServicio.GuardarArticulo(articulo, sesion);

                Thread.Sleep(1500);

                TempData["creado"] = "Artículo creado con éxito";

                return RedirectToAction("ListarArticulos");
            }
            else
            {
                return View();
            }

            
        }


        public IActionResult EliminarArticulo(int id)
        {
            var sesion = HttpContext;
            _articuloServicio.EliminarArticulo(id, sesion);

            Thread.Sleep(800);

            return RedirectToAction("ListarArticulos");
        }


        public IActionResult Modificar()
        {
            return View();
        }
    }
}
