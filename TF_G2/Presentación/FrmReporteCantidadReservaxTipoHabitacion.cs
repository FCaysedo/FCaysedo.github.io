using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Datos.REPORTE;

namespace Presentación
{
    public partial class FrmReporteCantidadReservaxTipoHabitacion : Form
    {
        private NReserva nreserva = new NReserva();
        public FrmReporteCantidadReservaxTipoHabitacion()
        {
            InitializeComponent();
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<ReporteReservaxTipoHabitacion> reporte = nreserva.RptReservaxTipo();
            dgvSolicitudesPorTipo.DataSource = null;
            dgvSolicitudesPorTipo.DataSource = reporte;

        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void FrmReporteCantidadReservaxTipoHabitacion_Load(object sender, EventArgs e)
        {

        }
    }
}
