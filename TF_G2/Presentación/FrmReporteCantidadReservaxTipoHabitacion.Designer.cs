
namespace Presentación
{
    partial class FrmReporteCantidadReservaxTipoHabitacion
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
            this.dgvSolicitudesPorTipo = new System.Windows.Forms.DataGridView();
            this.btnBuscarSolicitudesPorTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPorTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudesPorTipo
            // 
            this.dgvSolicitudesPorTipo.AllowUserToAddRows = false;
            this.dgvSolicitudesPorTipo.AllowUserToDeleteRows = false;
            this.dgvSolicitudesPorTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudesPorTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesPorTipo.Location = new System.Drawing.Point(71, 92);
            this.dgvSolicitudesPorTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSolicitudesPorTipo.Name = "dgvSolicitudesPorTipo";
            this.dgvSolicitudesPorTipo.ReadOnly = true;
            this.dgvSolicitudesPorTipo.RowHeadersWidth = 51;
            this.dgvSolicitudesPorTipo.RowTemplate.Height = 25;
            this.dgvSolicitudesPorTipo.Size = new System.Drawing.Size(579, 282);
            this.dgvSolicitudesPorTipo.TabIndex = 3;
            // 
            // btnBuscarSolicitudesPorTipo
            // 
            this.btnBuscarSolicitudesPorTipo.Location = new System.Drawing.Point(71, 38);
            this.btnBuscarSolicitudesPorTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarSolicitudesPorTipo.Name = "btnBuscarSolicitudesPorTipo";
            this.btnBuscarSolicitudesPorTipo.Size = new System.Drawing.Size(102, 27);
            this.btnBuscarSolicitudesPorTipo.TabIndex = 2;
            this.btnBuscarSolicitudesPorTipo.Text = "Buscar Solicitudes por Tipo";
            this.btnBuscarSolicitudesPorTipo.UseVisualStyleBackColor = true;
            // 
            // FrmReporteCantidadReservaxTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSolicitudesPorTipo);
            this.Controls.Add(this.btnBuscarSolicitudesPorTipo);
            this.Name = "FrmReporteCantidadReservaxTipoHabitacion";
            this.Text = "FrmReporteCantidadReservaxTipoHabitacion";
            this.Load += new System.EventHandler(this.FrmReporteCantidadReservaxTipoHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPorTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudesPorTipo;
        private System.Windows.Forms.Button btnBuscarSolicitudesPorTipo;
    }
}