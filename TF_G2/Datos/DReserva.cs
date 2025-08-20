using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.REPORTE;

namespace Datos
{
    public class DReserva
    {
          private BDEFEntities bdcontext = new BDEFEntities();
        public string Registrar(Reservas reserva)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Clientes.Add(reserva);
                    context.SaveChanges();
                }
                return "Reserva Registrada Correctamente";
            }
            catch (Exception ex) 
            {
                return "Error al registrar una reserva, intente de nuevo";
            }
        }

        public string Modificar(Reservas reserva)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Reservas reservaTemp = context.Reservas.Find(reserva.ID_Reserva);

                    reservaTemp.ID_Cliente = reserva.ID_Cliente;
                    reservaTemp.ID_Habitacion = reserva.ID_Habitacion;
                    reservaTemp.Num_Noches = reserva.Num_Noches;
                    context.SaveChanges();
                }
                return "Reserva Modificada Correctamente";
            }
            catch (Exception ex)
            {
                return "Error al modificar";
            }
        }

        public List<Reservas> ListarTodo()
        {
            List<Reservas> reserva = new List<Reservas> ();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    reserva = context.Reservas.ToList();
                }
                return reserva;
            }
            catch (Exception ex) 
            {
                return reserva;
            }
        }
        public List<ReporteReservaxRangoFechas> RptReservaxRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            IQueryable<ReporteReservaxRangoFechas> query = from s in bdcontext.Solicitud
                                                                  join a in bdcontext.App on s.AppId equals a.AppId
                                                                  join p in bdcontext.Programador on s.ProgramadorId equals p.ProgramadorId
                                                                  where !s.Eliminado && !a.Eliminado && !p.Eliminado
                                                                  && s.FechaHoraSolicitud >= fechaInicio && s.FechaHoraSolicitud <= fechaFin
                                                                  orderby s.FechaHoraSolicitud
                                                                  select new ReporteReservaxRangoFechas
                                                                  {
                                                                      FechaHoraReserva = s.FechaHoraReserva,
                                                                      TipoReserva = s.TipoReserva,
                                                                      TipoHabitacion = a.TipoHabitacion,
                                                                      NombreCliente = p.NombreCompleto
                                                                  };
            return query.ToList();
        }
        public List<ReporteReservaPendiente> RptReservaPendientes()
        {
            IQueryable<ReporteReservaPendiente> query = from s in bdcontext.Solicitud
                                                               join a in bdcontext.App on s.AppId equals a.AppId
                                                               join p in bdcontext.Programador on s.ProgramadorId equals p.ProgramadorId
                                                               where !s.Eliminado && !a.Eliminado && !p.Eliminado
                                                               && s.Atendido == false
                                                               select new ReporteReservaPendiente
                                                               {
                                                                   TipoReserva = s.TipoReserva,
                                                                   FechaHoraReserva = s.FechaHoraReserva,
                                                                   TipoHabitacion = a.TipoHabitacion,
                                                                   NombreCliente = p.NombreCompleto
                                                               };
            return query.ToList();
        }
        public List<ReporteReservaxTipoHabitacion> RptReservaxTipo()
        {
            IQueryable<ReporteReservaxTipoHabitacion> query = from s in bdcontext.Solicitud
                                                           where !s.Eliminado
                                                           group s by s.TipoSolicitud into g
                                                           select new ReporteReservaxTipoHabitacion
                                                           {
                                                               TipoReserva = g.Key,
                                                               Cantidad = g.Count()
                                                           };
            return query.ToList();
        }
    }
}
