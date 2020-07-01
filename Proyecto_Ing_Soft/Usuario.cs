using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ing_Soft
{
    class Usuario
    {
        private string User;
        private string Pass;

        public string getUsuario
        {
            set
            {
                User = value;
            }
            get
            {
                return User;
            }
        }
        public string getContraseña
        {
            set
            {
                Pass = value;
            }
            get
            {
                return Pass;
            }
        }
    }
}
