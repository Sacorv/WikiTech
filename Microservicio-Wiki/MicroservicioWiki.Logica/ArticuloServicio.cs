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

        Task<List<CategoriaDto>> ObtenerCategorias();

        Task<bool> RegistrarColaborador(ColaboradorDto colaboradorDTO);

        Task<ColaboradorDto> BuscarColaboradorPorEmail(string email);

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

            return await ConvertirArticuloADto(articuloBuscado);
        }


        public async Task<Articulo> Crear(CrearArticuloDto articulo)
        {
            Articulo nuevoArticulo = await ConvertirArticuloDTOAEntidad(articulo);

            EntityEntry<Articulo> response = await _context.Articulos.AddAsync(nuevoArticulo);

            await _context.SaveChangesAsync();

            return nuevoArticulo;
        }

        public async Task<List<ArticuloDto>> Listar()
        {
            List<Articulo> articulos = await _context.Articulos.ToListAsync();

            List<ArticuloDto> DTOs = new List<ArticuloDto>();

            if(articulos != null)
            {
                foreach (Articulo articulo in articulos)
                {
                    DTOs.Add(await ConvertirArticuloADto(articulo));
                }

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

        public async Task<List<CategoriaDto>> ObtenerCategorias()
        {
            List<Categorium> categorias = await _context.Categoria.OrderBy(c => c.Nombre).ToListAsync();

            List<CategoriaDto> categoriasDTO = new List<CategoriaDto>();

            if (categorias != null)
            {
                foreach (Categorium categoria in categorias)
                {
                    categoriasDTO.Add(await ConvertirCategoriaADto(categoria));
                }
            }

            return categoriasDTO;
        }

        public async Task<bool> RegistrarColaborador(ColaboradorDto colaboradorDTO)
        {
            bool registrado = false;
            Colaborador colaborador = await ConvertirColaboradorAEntidad(colaboradorDTO);

            if (colaborador != null)
            {
                _context.Colaboradors.Add(colaborador);
                _context.SaveChanges();
                registrado = true;
            }
            return registrado;
        }

        public async Task<ColaboradorDto> BuscarColaboradorPorEmail(string email)
        {
            Colaborador colaborador = _context.Colaboradors.Where(c => c.Email == email).FirstOrDefault();
            ColaboradorDto colaboradorDTO = null;

            if (colaborador != null)
            {
                colaboradorDTO = await ConvertirColaboradorADTO(colaborador);
            }

            return colaboradorDTO;
        }


        private async Task<ArticuloDto> ConvertirArticuloADto(Articulo articulo)
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


        private async Task<Articulo> ConvertirArticuloDTOAEntidad(CrearArticuloDto articuloDTO)
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

        private async Task<CategoriaDto> ConvertirCategoriaADto(Categorium categoria)
        {
            CategoriaDto categoriaDTO = new CategoriaDto();
            categoriaDTO.IdCategoria = categoria.IdCategoria;
            categoriaDTO.Nombre = categoria.Nombre;

            return categoriaDTO;
        }

        private async Task<Colaborador> ConvertirColaboradorAEntidad(ColaboradorDto colaboradorDTO)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.IdColaborador = colaboradorDTO.IdColaborador;
            colaborador.Nombre = colaboradorDTO.Nombre;
            colaborador.Apellido = colaboradorDTO.Apellido;
            colaborador.Email = colaboradorDTO.Email;

            return colaborador;
        }

        private async Task<ColaboradorDto> ConvertirColaboradorADTO(Colaborador colaborador)
        {
            ColaboradorDto colaboradorDTO = new ColaboradorDto();
            colaboradorDTO.IdColaborador = colaborador.IdColaborador;
            colaboradorDTO.Nombre = colaborador.Nombre;
            colaboradorDTO.Apellido = colaborador.Apellido;
            colaboradorDTO.Email = colaborador.Email;

            return colaboradorDTO;
        }

    }
}
