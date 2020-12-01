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
    public partial class FrmAltaServicio : Form
    {
        public FrmAltaServicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.cmbServicio.DataSource = Enum.GetValues(typeof(EService));
            this.cmbServicio.SelectedIndex = 0;
        }

        /// <summary>
        /// Retornara el servicio en el combobox.
        /// </summary>
        public string GetServicio
        {
            get
            {
                return this.cmbServicio.SelectedIndex.ToString();
            }
        }




    }
}
