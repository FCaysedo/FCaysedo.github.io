using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using static Datos.REPORTE;

namespace Negocio
{
    public class NReserva
    {
        private DReserva dReserva = new DReserva();

        public string Registrar(Reservas reserva)
        {
            return dReserva.Registrar(reserva);
        }

        public string Modificar(Reservas reserva)
        {
            return dReserva.Modificar(reserva);
        }

        public List<Reservas> ListarTodo()
        {
            return dReserva.ListarTodo();
        }
        public List<ReporteReservaxRangoFechas> RptReservaxRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return dReserva.RptReservaxRangoFechas(fechaInicio, fechaFin);
        }
        public List<ReporteReservaPendiente> RptReservaPendientes()
        {
            return dReserva.RptReservaPendientes();
        }
        public List<ReporteReservaxTipoHabitacion> RptReservaxTipo()
        {
            return dReserva.RptReservaxTipo();
        }
    }
}
