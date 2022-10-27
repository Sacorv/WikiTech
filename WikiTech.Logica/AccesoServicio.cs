using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiTech.Entidades;

namespace WikiTech.Logica
{

    public interface IAccesoServicio
    {
        bool Login(Usuario usuario);

        void Registrarse(Usuario usuario);
    }

    public class AccesoServicio : IAccesoServicio
    {
        public bool Login(Usuario usuario)
        {
            return true;
        }

        public void Registrarse(Usuario usuario)
        {
            
        }
    }
}
