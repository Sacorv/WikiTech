using MicroservicioWiki.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioWiki.Data.Dtos
{
    public class ArticuloDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? Puntaje { get; set; }
        public int IdColaborador { get; set; }
        public int IdCategoria { get; set; }
        public string? ImagenPrincipal { get; set; }

       

    }
}
