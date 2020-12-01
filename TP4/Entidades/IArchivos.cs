using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos
    {

        /// <summary>
        /// Guardara el detalle de un service en texto.
        /// </summary>
        /// <param name="service"></param>
        void GuardarService(Service service);

        /// <summary>
        /// Serializara y guardara un Service en formato binario.
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        void SerializarBinario(Service service);

    }
}
