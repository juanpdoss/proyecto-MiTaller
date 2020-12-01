
namespace MiTaller
{
    partial class FormTaller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgElectrodomesticos = new System.Windows.Forms.DataGridView();
            this.btnAgregarElectrodomestico = new System.Windows.Forms.Button();
            this.btnMeterEnService = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.RichTextBox();
            this.lblRecaudado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEnCola = new System.Windows.Forms.Label();
            this.lblTotalEnCola = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgElectrodomesticos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgElectrodomesticos
            // 
            this.dgElectrodomesticos.AllowUserToAddRows = false;
            this.dgElectrodomesticos.AllowUserToResizeColumns = false;
            this.dgElectrodomesticos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgElectrodomesticos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgElectrodomesticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgElectrodomesticos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgElectrodomesticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgElectrodomesticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgElectrodomesticos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgElectrodomesticos.Location = new System.Drawing.Point(438, 129);
            this.dgElectrodomesticos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgElectrodomesticos.MultiSelect = false;
            this.dgElectrodomesticos.Name = "dgElectrodomesticos";
            this.dgElectrodomesticos.ReadOnly = true;
            this.dgElectrodomesticos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgElectrodomesticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgElectrodomesticos.Size = new System.Drawing.Size(592, 482);
            this.dgElectrodomesticos.TabIndex = 0;
            this.dgElectrodomesticos.UseWaitCursor = true;
            // 
            // btnAgregarElectrodomestico
            // 
            this.btnAgregarElectrodomestico.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarElectrodomestico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarElectrodomestico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarElectrodomestico.Location = new System.Drawing.Point(866, 34);
            this.btnAgregarElectrodomestico.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarElectrodomestico.Name = "btnAgregarElectrodomestico";
            this.btnAgregarElectrodomestico.Size = new System.Drawing.Size(164, 57);
            this.btnAgregarElectrodomestico.TabIndex = 1;
            this.btnAgregarElectrodomestico.Text = "Agregar electrodomestico";
            this.btnAgregarElectrodomestico.UseVisualStyleBackColor = false;
            this.btnAgregarElectrodomestico.Click += new System.EventHandler(this.btnAgregarElectrodomestico_Click);
            // 
            // btnMeterEnService
            // 
            this.btnMeterEnService.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMeterEnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeterEnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeterEnService.Location = new System.Drawing.Point(651, 34);
            this.btnMeterEnService.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMeterEnService.Name = "btnMeterEnService";
            this.btnMeterEnService.Size = new System.Drawing.Size(164, 57);
            this.btnMeterEnService.TabIndex = 2;
            this.btnMeterEnService.Text = "Meter en service";
            this.btnMeterEnService.UseVisualStyleBackColor = false;
            this.btnMeterEnService.Click += new System.EventHandler(this.btnMeterEnService_Click);
            // 
            // txtService
            // 
            this.txtService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService.Location = new System.Drawing.Point(11, 129);
            this.txtService.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(302, 335);
            this.txtService.TabIndex = 3;
            this.txtService.Text = "Aqui se mostrara la informacion del ultimo servicio agregado..";
            // 
            // lblRecaudado
            // 
            this.lblRecaudado.AutoSize = true;
            this.lblRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudado.Location = new System.Drawing.Point(12, 34);
            this.lblRecaudado.Name = "lblRecaudado";
            this.lblRecaudado.Size = new System.Drawing.Size(138, 25);
            this.lblRecaudado.TabIndex = 4;
            this.lblRecaudado.Text = "Recaudado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(156, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblEnCola
            // 
            this.lblEnCola.AutoSize = true;
            this.lblEnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnCola.Location = new System.Drawing.Point(12, 75);
            this.lblEnCola.Name = "lblEnCola";
            this.lblEnCola.Size = new System.Drawing.Size(98, 25);
            this.lblEnCola.TabIndex = 6;
            this.lblEnCola.Text = "En cola:";
            // 
            // lblTotalEnCola
            // 
            this.lblTotalEnCola.AutoSize = true;
            this.lblTotalEnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnCola.Location = new System.Drawing.Point(106, 75);
            this.lblTotalEnCola.Name = "lblTotalEnCola";
            this.lblTotalEnCola.Size = new System.Drawing.Size(25, 25);
            this.lblTotalEnCola.TabIndex = 7;
            this.lblTotalEnCola.Text = "0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(438, 34);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 57);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar electrodomestico";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 623);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTotalEnCola);
            this.Controls.Add(this.lblEnCola);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRecaudado);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.btnMeterEnService);
            this.Controls.Add(this.btnAgregarElectrodomestico);
            this.Controls.Add(this.dgElectrodomesticos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTaller_FormClosing);
            this.Load += new System.EventHandler(this.FormTaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgElectrodomesticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgElectrodomesticos;
        private System.Windows.Forms.Button btnAgregarElectrodomestico;
        private System.Windows.Forms.Button btnMeterEnService;
        private System.Windows.Forms.RichTextBox txtService;
        private System.Windows.Forms.Label lblRecaudado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEnCola;
        private System.Windows.Forms.Label lblTotalEnCola;
        private System.Windows.Forms.Button btnEliminar;
    }
}

