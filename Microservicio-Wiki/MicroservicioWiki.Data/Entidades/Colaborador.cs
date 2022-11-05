using System;
using System.Collections.Generic;

namespace MicroservicioWiki.Data.Entidades
{
    public partial class Colaborador
    {
        public int IdColaborador { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? Email { get; set; }

        public virtual Articulo? Articulo { get; set; }
    }
}
