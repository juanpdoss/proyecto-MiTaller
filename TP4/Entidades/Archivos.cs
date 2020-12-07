using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    /// <summary>
    /// Clase publica Archivos.
    /// </summary>
    public class Archivos : IArchivos
    {
        public bool GuardarService(Service aux)
        {
            bool pude = true;

            try
            {
                using(StreamWriter escritor=new StreamWriter("Comprobantes.txt",true))
                {
                    escritor.WriteLine("Service generado el dia {0}", DateTime.Now);
                    escritor.WriteLine("informacion del servicio:");
                    escritor.WriteLine(aux.ToString());
                    escritor.WriteLine("-----------------------------------------");

                }


            }
            catch
            {
                pude = false;

            }

            return pude;
        }

        public bool SerializarBinario(Service service)
        {
            bool pude = true;

            try
            {
                using(FileStream fs=new FileStream("service.bin",FileMode.Create))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, service);
                }
            }
            catch
            {
                pude = false;

            }

            return pude;

        }
    }
}
