using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion.Servicio
{
    internal class ServicioUsuario
    {
        public bool ValidateUser(string user, string password)
        {
            return user == "admin" && password == "1234";
        }
    }
}
