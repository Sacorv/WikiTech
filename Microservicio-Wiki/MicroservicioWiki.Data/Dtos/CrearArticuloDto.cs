using MicroservicioWiki.Data.Entidades;
using System.ComponentModel.DataAnnotations;

namespace MicroservicioWiki.Data.Dtos
{
    public class CrearArticuloDto
    {

        [Required(ErrorMessage ="El título no puede estar vacío")]
        public string Titulo { get; set; } = null!;

        //[Required(ErrorMessage = "El contenido no puede estar vacío")]
        public string Contenido { get; set; } = null!;

        //[Required(ErrorMessage = "La fecha no puede estar vacío")]
        public DateTime Fecha { get; set; }

        public int? Puntaje { get; set; }

        public int IdColaborador { get; set; }

        //[Required(ErrorMessage = "Debe elegir una categoría")]
        public int IdCategoria { get; set; }
        public string? ImagenPrincipal { get; set; }

      

    }
}
