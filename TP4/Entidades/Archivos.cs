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
        public void GuardarService(Service aux)
        {
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


            }
          
        }

        public void SerializarBinario(Service service)
        {
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

            }

        }
    }
}
