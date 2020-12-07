using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio dos electrodomesticos, deberian insertarse en la base de datos.
            Electrodomestico e1 = new Electrodomestico("2", false);
            Electrodomestico e2 = new Electrodomestico("4", true);


            Taller<Electrodomestico>.PonerEnService(e1, "4");

            Console.WriteLine("El taller tiene {0} electrodomesticos dentro", Taller<Electrodomestico>.GetCantidadEnCola);
            Console.WriteLine("El taller ha recaudado: " + Taller<Electrodomestico>.GetRecaudado);

           
            //no deberia recaudar lo del service s2 ya que ese electrodomestico tiene garantia.
            Console.WriteLine("El taller tiene {0} electrodomesticos dentro", Taller<Electrodomestico>.GetCantidadEnCola);
            Console.WriteLine("El taller ha recaudado: " + Taller<Electrodomestico>.GetRecaudado);


            Console.WriteLine("el ultimo id en la tabla es el numero " + ServiciosSql.ObtenerUltimoId());



            Taller<Electrodomestico>.CargarElectrodomesticos(ServiciosSql.ObtenerElectrodomesticos());


            Console.WriteLine(Taller<Electrodomestico>.GetServices.ToString());




            Console.ReadKey();





        }
    }
}
