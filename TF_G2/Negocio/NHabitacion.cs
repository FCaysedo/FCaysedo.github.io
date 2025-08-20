using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NHabitacion
    {
        private DHabitacion dHabitacion = new DHabitacion();

        public string Registrar(Habitaciones habitacion)
        {
            return dHabitacion.Registrar(habitacion);
        }

        public string Modificar(Habitaciones habitacion)
        {
            return dHabitacion.Modificar(habitacion);
        }

        public List<Habitaciones> ListarTodo()
        {
            return dHabitacion.ListarTodo();
        }
    }
}
