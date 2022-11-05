using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiTech.Entidades
{
    public class Articulo
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        
        public string Contenido { get; set; }

        public DateTime Fecha { get; set; }

        public int Puntaje { get; set; }

        public string? ImagenPrincipal { get; set; }

        public int IdColaborador { get; set; }

        public int IdCategoria { get; set; }

        //public static explicit operator Articulo(Task<List<Articulo>> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
