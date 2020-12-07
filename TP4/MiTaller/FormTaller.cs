using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiTaller
{
    public partial class FormTaller : Form
    {
        Thread hilo1;
        public FormTaller()
        {
            InitializeComponent();                   
        }

        private void FormTaller_Load(object sender, EventArgs e)
        {
            this.btnMeterEnService.Enabled = false;
            this.Text = "Servicio tecnico utn";
            this.hilo1 = new Thread(this.ActualizarFormulario);

        }

        private void btnAgregarElectrodomestico_Click(object sender, EventArgs e)
        {
            FrmAltaElectrodomestico formulario = new FrmAltaElectrodomestico();

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Electrodomestico electrodomestico = new Electrodomestico(formulario.GetTipo, formulario.GetGarantia);
                    Taller<Electrodomestico>.AgregarElectrodomestico(electrodomestico);
                }
                catch(BaseDeDatosException a)
                {
                    MessageBox.Show(a.RetornarMensaje());
                }
            }
                    
        }

        private void btnMeterEnService_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgElectrodomesticos.SelectedRows[0];

                int tipoAux = Electrodomestico.MapearTipoAInt((string)row.Cells[2].Value);
                int idAux = Convert.ToInt32(row.Cells[1].Value);
                bool tieneGarantiaAux = Convert.ToBoolean(Convert.ToInt32(row.Cells[0].Value));


                Electrodomestico auxElectrodomestico = new Electrodomestico
                                                            (idAux,
                                                              tipoAux,
                                                              tieneGarantiaAux
                                                              );
                FrmAltaServicio frm = new FrmAltaServicio();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Taller<Electrodomestico>.PonerEnService(auxElectrodomestico, frm.GetServicio);
                    if (!this.hilo1.IsAlive)
                        this.hilo1.Start();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgElectrodomesticos.SelectedRows[0];
                int idAux = Convert.ToInt32(row.Cells[1].Value);
                ServiciosSql.BorrarElectrodomestico(idAux);

            }
            catch(BaseDeDatosException a)
            {
                MessageBox.Show(a.RetornarMensaje());
            }

        }
        private void FormTaller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo1.IsAlive)
                this.hilo1.Abort();
        }


        private void btnCargarElectrodomesticos_Click(object sender, EventArgs e)
        {
            this.btnMeterEnService.Enabled = true;
            Taller<Electrodomestico>.CargarElectrodomesticos(ServiciosSql.ObtenerElectrodomesticos());
            this.dgElectrodomesticos.DataSource = Taller<Electrodomestico>.GetElectrodomesticos;
            this.btnCargarElectrodomesticos.Text = "Actualizar electrodomesticos";
        }



        #region metodos
        /// <summary>
        /// Actualizara el textbox y los labels del formulario periodicamente.
        /// </summary>
        private void ActualizarFormulario()
        {       
            while (true)
            {
                try
                {

                    if (this.dgElectrodomesticos.InvokeRequired)
                    {
                        this.dgElectrodomesticos.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.txtService.Text = Taller<Electrodomestico>.GetServices;
                            this.lblTotalEnCola.Text = Taller<Electrodomestico>.GetCantidadEnCola.ToString();
                            this.lblTotal.Text = Taller<Electrodomestico>.GetRecaudado.ToString();
                        }
                        );
                    }

                }
                catch(BaseDeDatosException a)
                {
                    MessageBox.Show(a.RetornarMensaje());
                }

                Thread.Sleep(5000);
            }

        }

        #endregion

      
    }
}
