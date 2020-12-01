using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase estatica Extension.
    /// </summary>
    public static class Extension
    {
        public static string RetornarMensaje(this BaseDeDatosException exception)
        {
            return exception.Message;
        }


    }
}
