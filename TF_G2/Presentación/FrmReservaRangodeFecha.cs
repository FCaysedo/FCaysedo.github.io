using System;
using Negocio;
using static Datos.REPORTE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmReservaRangodeFecha : Form
    {
        private NReserva negocioReserva = new NReserva();
        public FrmReservaRangodeFecha()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin");
                return;
            }
            List<ReporteReservaxRangoFechas> reporte = negocioReserva.RptReservaxRangoFechas(fechaInicio, fechaFin);
            dgvReporte.DataSource = null;
            dgvReporte.DataSource = reporte;
        }
    }
}
