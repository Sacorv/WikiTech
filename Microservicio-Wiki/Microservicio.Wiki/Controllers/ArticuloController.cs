using MicroservicioWiki.Data.Dtos;
using MicroservicioWiki.Data.Entidades;
using MicroservicioWiki.Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Microservicio.Wiki.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ArticuloController : Controller
    {

        public IArticuloServicio _IArticuloServicio;

        public ArticuloController(IArticuloServicio IArticuloServicio)
        {
            _IArticuloServicio = IArticuloServicio;
        }



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ArticuloDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<List<ArticuloDto>> ObtenerArticulos()
        {
            List<ArticuloDto> articulos = await _IArticuloServicio.Listar();

            return articulos;
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ArticuloDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<IActionResult> BuscarArticulo(int id)
        {
            ArticuloDto articuloBuscado = await _IArticuloServicio.BuscarPorId(id);

            return new OkObjectResult(articuloBuscado);
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ArticuloDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<IActionResult> CrearArticulo(CrearArticuloDto articulo)
        {
         
            Articulo creado = await _IArticuloServicio.Crear(articulo);

            return new CreatedResult("https://localhost:7164",creado);
        }

        [Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<IActionResult> EliminarArticulo(int id)
        {
            Articulo articulo = await _IArticuloServicio.BuscarArticulo(id);

            bool eliminado = false;

            if (articulo != null)
            {
                eliminado = await _IArticuloServicio.Eliminar(articulo);
            }

            return new OkObjectResult(eliminado);
        }


        [Authorize]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ArticuloDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<IActionResult> ModificarArticulo(ArticuloDto articulo)
        {

            throw new NotImplementedException();
        }

        
        [Authorize]
        [HttpGet("categorias")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CategoriaDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<List<CategoriaDto>> ObtenerCategorias()
        {

            return await _IArticuloServicio.ObtenerCategorias(); ;
        }

        
        [HttpPost("colaborador")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ColaboradorDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]

        public async Task<bool> RegistrarColaborador(ColaboradorDto colaboradorDTO)
        {
            return await _IArticuloServicio.RegistrarColaborador(colaboradorDTO);

        }

        [Authorize]
        [HttpGet("colaborador/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ColaboradorDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(bool))]
        public async Task<ColaboradorDto> BuscarColaborador(string email)
        {
            return await _IArticuloServicio.BuscarColaboradorPorEmail(email);
        }

    }
}
