using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica e instanciable Electrodomestico.
    /// </summary>
    public class Electrodomestico
    {
        #region atributos
        private int id;
        private ETipo tipo;
        private bool tieneGarantia;
        public delegate bool DelegadoElectrodomestico(string tipo, bool tieneGarantia);
        public event DelegadoElectrodomestico EventoInstanciaElectrodomestico;

        #endregion

        #region propiedades
        /// <summary>
        /// De solo lectura, retornara el campo tieneGarantia.
        /// </summary>
        public bool Garantia
        {
            get
            {
                return this.tieneGarantia;
            }
        }

        /// <summary>
        /// Establecera el atributo de tipo ETIPO a partir del string recibido.
        /// </summary>
        public string MapearTipo
        {
            set
            {
                int.TryParse(value, out int auxiliar);
                switch (auxiliar)
                {
                    case 0:
                        this.tipo = ETipo.Microondas;
                        break;

                    case 1:
                        this.tipo = ETipo.Lavarropa;
                        break;

                    case 2:
                        this.tipo = ETipo.Cocina;
                        break;

                    case 3:
                        this.tipo = ETipo.AireAcondicionado;
                        break;

                    case 4:
                        this.tipo = ETipo.Heladera;
                        break;

                    case 5:
                        this.tipo = ETipo.Estufa;
                        break;

                    case 6:
                        this.tipo = ETipo.Lavavajillas;
                        break;

                    default:
                        this.tipo = ETipo.SinEspecificar;
                        break;
                }
            }

        }

        /// <summary>
        /// Retornara en formato string el entero asociado al atributo tipo.
        /// </summary>
        public string Id
        {
           get
           {
                //Me hice este getter exclusivamente para usarlo en el insert de la tabla de datos.
                return this.id.ToString();
               
           }
        }

        /// <summary>
        /// Retornara en formato string el atributo tipo
        /// </summary>
        public string Tipo
        {
            get
            {
                return this.tipo.ToString();
            }

        }

        #endregion

        #region constructores

        //Los constructores no los reutilizo porque los uso para dos cosas distintas 

        /// <summary>
        /// Constructor de instancia que utilizo al momento de dar altas desde el form.
        /// Su finalidad es insertar al electrodomestico en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipo"></param>
        public Electrodomestico(string tipoString, bool garantia)
        {
            this.EventoInstanciaElectrodomestico += this.InsertarEnBaseDeDatos;
            this.EventoInstanciaElectrodomestico(tipoString, garantia);

            this.id = ServiciosSql.ObtenerUltimoId();
            this.MapearTipo = tipoString;
            this.tieneGarantia = garantia;
        }
        /// <summary>
        /// Constructor de instancia que utilizo al momento de instanciar electrodomesticos desde la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoStrin"></param>
        /// <param name="garantia"></param>
        public Electrodomestico(int id,int tipo,bool garantia)
        {
            this.id = id;
            this.tipo = (ETipo)tipo;
            this.tieneGarantia = garantia;

        }
        #endregion

        #region metodos
        /// <summary>
        /// Manejador del evento "EventoInstanciaElectrodomestico" 
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="tieneGarantia"></param>
        /// <returns></returns>
        public bool InsertarEnBaseDeDatos(string tipo,bool tieneGarantia)
        {
            return ServiciosSql.InsertarElectrodomestico(tipo, tieneGarantia);
        }

        /// <summary>
        /// Convierte el tipo recibido como parametro a formato int y lo retorna.
        /// Lo utilizo para convertir la columna tipo del dataGrid a int. 
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static int MapearTipoAInt(string tipo)
        {
            int retorno = 0;

            switch (tipo)
            {
                case "Microondas":
                    retorno = 0;
                    break;
                case "Lavarropa":
                    retorno = 1;
                    break;
                case "Cocina":
                    retorno = 2;
                    break;
                case "AireAcondicionado":
                    retorno = 3;
                    break;
                case "Heladera":
                    retorno = 4;
                    break;
                case "Estufa":
                    retorno = 5;
                    break;
                case "Lavavajillas":
                    retorno = 6;
                    break;
                case "SinEspecificar":
                    retorno = 7;
                    break;

            }

            return retorno;
        }

        #endregion

    }

}
