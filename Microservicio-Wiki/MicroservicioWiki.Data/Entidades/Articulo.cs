using System;
using System.Collections.Generic;

namespace MicroservicioWiki.Data.Entidades
{
    public partial class Articulo
    {
        public int IdArticulo { get; set; }
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? Puntaje { get; set; }
        public int IdColaborador { get; set; }
        public int IdCategoria { get; set; }
        public string? ImagenPrincipal { get; set; }

        public virtual Colaborador IdArticulo1 { get; set; } = null!;
        public virtual Categorium IdArticuloNavigation { get; set; } = null!;
    }
}
