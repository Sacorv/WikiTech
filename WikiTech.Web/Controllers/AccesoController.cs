using Microsoft.AspNetCore.Mvc;
using WikiTech.Entidades;
using WikiTech.Logica;

namespace WikiTech.Web.Controllers
{
    public class AccesoController : Controller
    {

        public IAccesoServicio _IAccesoServicio;
        
        public AccesoController(IAccesoServicio _accesoServicio)
        {
            _IAccesoServicio = _accesoServicio;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _IAccesoServicio.Login(usuario);

                return Redirect("/Home/Index");
            }
            else
            {
                return View(usuario);
            }
           
        }

        public IActionResult Registrar()
        {
            return View();
        }
    }
}
