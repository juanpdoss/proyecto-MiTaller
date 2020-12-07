using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Excepcion que se lanza cuando se quiere agregar a la cola de servicios del taller
    //  un service que ya esta dado de alta.
    /// </summary>
    public class YaEstaEnTallerException:Exception
    {
        public YaEstaEnTallerException()
                    :base("El electrodomestico elegido ya se encuentra en un service.")
        {

        }

    }
}
