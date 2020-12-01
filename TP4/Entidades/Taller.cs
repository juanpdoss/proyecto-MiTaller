using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase estatica y generica Taller
    /// </summary>
    /// <typeparam name="T" T solo puede ser de tipo Service></typeparam>
    public static class Taller<U>
                        where U:Electrodomestico
    {
        #region atributos
        private static Queue<Service> colaServicios;
        private static float recaudado;
        private static List<U> listaElectrodomesticos;

        #endregion

        #region propiedades

        /// <summary>
        /// Retorna el ultimo servicio en la cola.
        /// </summary>
        public static string GetUltimoEnCola
        {
            get
            {
                return Taller<U>.colaServicios.Last().ToString();
            }
        }

        /// <summary>
        /// Retornara el atributo recaudado.
        /// </summary>
        public static float GetRecaudado
        {
            get
            {
                return Taller<U>.recaudado;
            }
        }
        /// <summary>
        /// Retornara la cantidad de elementos contenidos en la cola del taller.
        /// </summary>
        public static int GetCantidadEnCola
        {
            get
            {
                return Taller<U>.colaServicios.Count;
            }

        }

        /// <summary>
        /// De solo lectura, retornara la lista de electrodomesticos.
        /// </summary>
        public static List<U> GetElectrodomesticos
        {
            get
            {
                return Taller<U>.listaElectrodomesticos;
            }
        }


        #endregion

        #region constructor
        /// <summary>
        /// Unico constructor estatico.
        /// </summary>
        static Taller()
        {
            Taller<U>.colaServicios = new Queue<Service>();
            Taller<U>.recaudado = 0;
            Taller<U>.listaElectrodomesticos = new List<U>();
        }
        #endregion

        #region metodos
        /// <summary>
        /// Agregara un service a la cola del taller.
        /// </summary>
        /// <param name="service"></param>
        public static void PonerEnService(U electrodomestico,string service)
        {
            Service nuevoServicio = new Service(electrodomestico, service);
            Taller<U>.recaudado += nuevoServicio.GetCosto;
            Taller<U>.colaServicios.Enqueue(nuevoServicio);
            Archivos serviciosDeArchivos = new Archivos();

            serviciosDeArchivos.GuardarService(nuevoServicio);
            serviciosDeArchivos.SerializarBinario(nuevoServicio);

        }
 

        /// <summary>
        /// Asignara a la lista del taller la lista recibida por parametro.
        /// </summary>
        /// <param name="electrodomesticos"></param>
        public static void CargarElectrodomesticos(List<U> electrodomesticos)
        {
            Taller<U>.listaElectrodomesticos = electrodomesticos;
        }


        /// <summary>
        /// Agrega un electrodomestico al taller.
        /// </summary>
        /// <param name="electrodomestico"></param>
        public static void AgregarElectrodomestico(U electrodomestico)
        {
            Taller<U>.listaElectrodomesticos.Add(electrodomestico);

        }
        #endregion
    }
}
