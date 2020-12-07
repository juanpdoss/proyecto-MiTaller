using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTaller
{
    /// <summary>
    /// Formulario para dar de alta un electrodomestico.
    /// </summary>
    public partial class FrmAltaElectrodomestico : Form
    {
        public FrmAltaElectrodomestico()
        {
            InitializeComponent();
            this.Text = "Agregar electrodomestico";
            this.StartPosition = FormStartPosition.CenterParent;
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
            this.cmbTipo.SelectedIndex = 0;
          
        }

        #region propiedades

        /// <summary>
        /// Retornara el contenido del combobox;
        /// </summary>
        public string GetTipo
        {
            get
            {
                return this.cmbTipo.SelectedIndex.ToString();
            }
        }

        /// <summary>
        /// Retornara el estado del radio button del form.
        /// </summary>
        public bool GetGarantia
        {
            get
            {
                return this.rdGarantia.Checked;
            }
        }





        #endregion


    }
}
