using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos
    {
        /*
         * queria que estos metodos fueran estaticos pero al intentarlo me pidio actualizar a la version 8.0
         * no lo hice por miedo a que esto genere problemas al momento de la correcion 
         */


        /// <summary>
        /// Guardara el detalle de un service en texto.
        /// </summary>
        /// <param name="service"></param>
        bool GuardarService(Service service);

        /// <summary>
        /// Serializara y guardara un Service en formato binario.
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        bool SerializarBinario(Service service);

    }
}
