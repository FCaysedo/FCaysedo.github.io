using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class REPORTE
    {
        public class ReporteReservaxRangoFechas
        {
            public DateTime FechaHoraReserva { get; set; }
            public string TipoReserva { get; set; }
            public string TipoHabitacion { get; set; }
            public string NombreCliente { get; set; }
        }
        public class ReporteReservaPendiente
        {
            public string TipoReserva { get; set; }
            public DateTime FechaHoraReserva { get; set; }
            public string TipoHabitacion { get; set; }
            public string NombreCliente { get; set; }
        }
        public class ReporteReservaxTipoHabitacion
        {
            public string TipoReserva { get; set; }
            public int Cantidad { get; set; }
        }
    }
}
