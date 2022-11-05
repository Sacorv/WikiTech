using System;
using System.Collections.Generic;

namespace MicroservicioWiki.Data.Entidades
{
    public partial class Categorium
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual Articulo? Articulo { get; set; }
    }
}
