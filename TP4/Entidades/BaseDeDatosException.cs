using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Excepcion que lanzo cuando se produce un error en la base de datos.
    /// </summary>
    public class BaseDeDatosException:Exception
    {
        public BaseDeDatosException()
                    :base("se ha producido un error en la bas de datos.")
        {

        }


    }
}
