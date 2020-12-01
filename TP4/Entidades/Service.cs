using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase instanciable service.
    /// </summary>
    [Serializable]
    public class Service
    {
        #region atributos
        private Electrodomestico electrodomestico;
        private EService servicio;
        #endregion

        #region propiedades
        /// <summary>
        /// Retornara el costo de un service basado en el atributo de tipo EService.
        /// </summary>
        public float GetCosto
        {
            get
            {
                float retorno = 0;

                if(!this.electrodomestico.Garantia)//si tiene garantia, no le cobro el service al cliente.
                {
                    switch (this.servicio)
                    {
                        case EService.Balanceo:
                            retorno += 1300;
                            break;
                        case EService.CambioCremallera:
                            retorno += 2500;
                            break;
                        case EService.CargaDeGas:
                            retorno += 2000;
                            break;
                        case EService.LimpiezaDeFiltro:
                            retorno += 1500;
                            break;
                        case EService.PerdidaDeGas:
                            retorno += 1300;
                            break;
                        case EService.CambioCorrea:
                            retorno += 2000;
                            break;
                        case EService.ArregloElectrico:
                            retorno += 3000;
                            break;
                        default:
                            retorno += 1500;
                            break;                
                    }
                }
                return retorno;
            }
        }

        /// <summary>
        /// Establecera el atributo de tipo EService a partir del string recibido.
        /// </summary>
        public string MapearService
        {
            set
            {
                int.TryParse(value, out int auxiliar);
                switch (auxiliar)
                {
                    case 0:
                        this.servicio = EService.Balanceo;
                        break;
                    case 1:
                        this.servicio = EService.CambioCremallera;
                        break;
                    case 2:
                        this.servicio = EService.CargaDeGas;
                        break;
                    case 3:
                        this.servicio = EService.LimpiezaDeFiltro;
                        break;
                    case 4:
                        this.servicio = EService.PerdidaDeGas;
                        break;
                    case 5:
                        this.servicio = EService.CambioCorrea;
                        break;
                    case 6:
                        this.servicio = EService.ArregloElectrico;
                        break;
                    default:
                        this.servicio = EService.DiagnosticoTecnico;
                        break;
                }


            }
        }

        /// <summary>
        /// Dara formato al atributo de tipo EService antes de retornarlo.
        /// </summary>
        public string GetServiceString
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                switch (this.servicio)
                {
                    case EService.Balanceo:
                        sb.Append("de balanceo.");
                        break;
                    case EService.CambioCremallera:
                        sb.Append("cambio de cremallera.");
                        break;
                    case EService.CargaDeGas:
                        sb.Append("carga de gas.");
                        break;
                    case EService.LimpiezaDeFiltro:
                        sb.Append("limpieza del filtro.");
                        break;
                    case EService.PerdidaDeGas:
                        sb.Append("busqueda de posible perdida de gas.");
                        break;
                    case EService.CambioCorrea:
                        sb.Append("cambio de correa.");
                        break;
                    case EService.ArregloElectrico:
                        sb.Append("control y posterior reparacion electronica.");
                        break;
                    default:
                        sb.Append("diagostico tecnico.");
                        break;
                    
                }

                return sb.ToString();

            }
        }

        #endregion

        #region constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Service()
        {

        }
        /// <summary>
        /// Constructor de instancia de dos parametros.
        /// </summary>
        /// <param name="electrodomestico" objeto de tipo electrodomestico></param>
        /// <param name="servicio" objeto de tipo servicio.></param>
        public Service(Electrodomestico electrodomestico, string servicio)
        {
            this.electrodomestico = electrodomestico;
            this.MapearService = servicio;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Retornara en formato string toda la informacion de un Service.
        /// </summary>
        /// <returns></returns>
        private string ServiceToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} numero {1} recibira un servicio de {2}\n",
                    this.electrodomestico.Tipo, this.electrodomestico.Id ,this.GetServiceString);
            if(this.electrodomestico.Garantia)
            {
                sb.AppendLine("no tendra que pagar, los costos del mismo estan cubierto por la garantia.");
            }
            else
            {
                sb.AppendFormat("el costo del servicio sera de {0} ya que el electrodomestico no tiene garantia."
                                     , this.GetCosto);             
            }

            return sb.ToString();
        }

        /// <summary>
        /// Hara publicos los datos de un Service.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.ServiceToString();
        }

        #endregion

   
    }
}
