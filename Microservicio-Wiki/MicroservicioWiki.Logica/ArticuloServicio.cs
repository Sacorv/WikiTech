using MicroservicioWiki.Data.Dtos;
using MicroservicioWiki.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioWiki.Logica
{

    public interface IArticuloServicio
    {
        Task<List<ArticuloDto>> Listar();

        Task<ArticuloDto> BuscarPorId(int id);

        Task<Articulo> BuscarArticulo(int id);

        Task<Articulo> Crear(CrearArticuloDto articulo);

        Task<bool> Eliminar(Articulo articulo);

        Task<ArticuloDto> ConvertirADto(Articulo articulo);

        Task<Articulo> ConvertirAEntidad(CrearArticuloDto articuloDTO);

    }

    public class ArticuloServicio : IArticuloServicio
    {

        private MicroservicioWikiContext _context;

        public ArticuloServicio(MicroservicioWikiContext context)
        {
            _context = context;
        }

        public async Task<ArticuloDto> BuscarPorId(int IdArticulo)
        {
            Articulo articuloBuscado = await _context.Articulos.FindAsync(IdArticulo);

            return await ConvertirADto(articuloBuscado);
        }


        public async Task<Articulo> Crear(CrearArticuloDto articulo)
        {
            Articulo nuevoArticulo = await ConvertirAEntidad(articulo);

            EntityEntry<Articulo> response = await _context.Articulos.AddAsync(nuevoArticulo);

            await _context.SaveChangesAsync();

            return nuevoArticulo;
        }

        public async Task<List<ArticuloDto>> Listar()
        {
            List<Articulo> articulos = await _context.Articulos.ToListAsync();

            List<ArticuloDto> DTOs = new List<ArticuloDto>();

            foreach (Articulo articulo in articulos)
            {
                DTOs.Add(await ConvertirADto(articulo));
            }

            return DTOs;
        }

        public async Task<bool> Eliminar(Articulo articulo)
        {
            bool eliminado = false;

            if(await _context.Articulos.FindAsync(articulo.IdArticulo) != null)
            {
                _context.Articulos.Remove(articulo);
                _context.SaveChanges();

                eliminado = true;
            }
            return eliminado;
        }

        public async Task<Articulo> BuscarArticulo(int IdArticulo)
        {
            Articulo articuloBuscado = await _context.Articulos.FindAsync(IdArticulo);

            return articuloBuscado;
        }


        public async Task<ArticuloDto> ConvertirADto(Articulo articulo)
        {
            ArticuloDto articuloDTO = new ArticuloDto();

            articuloDTO.Id = articulo.IdArticulo;
            articuloDTO.Titulo = articulo.Titulo;
            articuloDTO.Contenido = articulo.Contenido;
            articuloDTO.Fecha = articulo.Fecha;
            articuloDTO.Puntaje = articulo.Puntaje;
            articuloDTO.IdColaborador = articulo.IdColaborador;
            articuloDTO.IdCategoria = articulo.IdCategoria;
            articuloDTO.ImagenPrincipal = articulo.ImagenPrincipal;

            return articuloDTO;
        }


        public async Task<Articulo> ConvertirAEntidad(CrearArticuloDto articuloDTO)
        {
            Articulo nuevoArticulo = new Articulo();
            nuevoArticulo.Titulo = articuloDTO.Titulo;
            nuevoArticulo.Contenido = articuloDTO.Contenido;
            nuevoArticulo.Fecha = articuloDTO.Fecha;
            nuevoArticulo.Puntaje = articuloDTO.Puntaje;
            nuevoArticulo.IdColaborador = articuloDTO.IdColaborador;
            nuevoArticulo.IdCategoria = articuloDTO.IdCategoria;
            nuevoArticulo.ImagenPrincipal = articuloDTO.ImagenPrincipal;

            return nuevoArticulo;
        }

        
    }
}
