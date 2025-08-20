
namespace Presentación
{
    partial class FrmReporteReservasPendientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSolicitudesPendientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarSolicitudesPendientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudesPendientes
            // 
            this.dgvSolicitudesPendientes.AllowUserToAddRows = false;
            this.dgvSolicitudesPendientes.AllowUserToDeleteRows = false;
            this.dgvSolicitudesPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesPendientes.Location = new System.Drawing.Point(61, 84);
            this.dgvSolicitudesPendientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSolicitudesPendientes.Name = "dgvSolicitudesPendientes";
            this.dgvSolicitudesPendientes.ReadOnly = true;
            this.dgvSolicitudesPendientes.RowHeadersWidth = 51;
            this.dgvSolicitudesPendientes.RowTemplate.Height = 25;
            this.dgvSolicitudesPendientes.Size = new System.Drawing.Size(677, 336);
            this.dgvSolicitudesPendientes.TabIndex = 3;
            // 
            // btnBuscarSolicitudesPendientes
            // 
            this.btnBuscarSolicitudesPendientes.Location = new System.Drawing.Point(61, 30);
            this.btnBuscarSolicitudesPendientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarSolicitudesPendientes.Name = "btnBuscarSolicitudesPendientes";
            this.btnBuscarSolicitudesPendientes.Size = new System.Drawing.Size(124, 29);
            this.btnBuscarSolicitudesPendientes.TabIndex = 2;
            this.btnBuscarSolicitudesPendientes.Text = "Buscar Solicitudes Pendientes";
            this.btnBuscarSolicitudesPendientes.UseVisualStyleBackColor = true;
            this.btnBuscarSolicitudesPendientes.Click += new System.EventHandler(this.btnBuscarSolicitudesPendientes_Click);
            // 
            // FrmReporteReservasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSolicitudesPendientes);
            this.Controls.Add(this.btnBuscarSolicitudesPendientes);
            this.Name = "FrmReporteReservasPendientes";
            this.Text = "FrmReporteReservasPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudesPendientes;
        private System.Windows.Forms.Button btnBuscarSolicitudesPendientes;
    }
}