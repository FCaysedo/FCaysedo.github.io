using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using static Datos.REPORTE;

namespace Presentación
{
    public partial class FrmReporteReservasPendientes : Form
    {
        private NReserva negocioreserva = new NReserva();
        public FrmReporteReservasPendientes()
        {
            InitializeComponent();
        }

        private void btnBuscarSolicitudesPendientes_Click(object sender, EventArgs e)
        {
            List<ReporteReservaPendiente> reporte = negocioreserva.RptReservaPendientes();
            dgvSolicitudesPendientes.DataSource = null;
            dgvSolicitudesPendientes.DataSource = reporte;
        }
    }
}
