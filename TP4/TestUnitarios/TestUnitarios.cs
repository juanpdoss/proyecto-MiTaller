using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void TallerInstanciaListaOK()
        {
            Assert.IsNotNull(Taller<Electrodomestico>.GetElectrodomesticos);

        }

        [TestMethod]
        public void BaseDeDatosProduceExcepcion()
        {
           
            try
            {
                //Produce error porque el id pasado como parametro no se encuentra en la base de datos.
                ServiciosSql.BorrarElectrodomestico(10000);

            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(BaseDeDatosException));
            }
            

        }


        [TestMethod]
        public void TallerAgregaService()
        {

            Taller<Electrodomestico>.PonerEnService(new Electrodomestico(3499, 3, false), "3");
            Assert.AreEqual(1, Taller<Electrodomestico>.GetCantidadEnCola);

        }





    }
}
