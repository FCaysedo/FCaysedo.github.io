using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DHabitacion
    {
        public string Registrar(Habitaciones habitacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Habitaciones.Add(habitacion);
                    context.SaveChanges();
                }
                return "Habitacion Registrada Correctamente";
            }
            catch (Exception ex)
            {
                return "Error al ingresar habitacion, intente de nuevo";
            }
        }


        public string Modificar (Habitaciones habitacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Habitaciones habitacionTemp = context.Habitaciones.Find(habitacion.ID_Habitacion);

                    habitacionTemp.Estado = habitacion.Estado;
                    habitacionTemp.Tipo = habitacion.Tipo;
                    context.SaveChanges();
                }
                return "Habitacion Modificada correctamente";
            }
            catch (Exception ex) 
            {
                return "Error de modificacion";
            }
        }

        public List<Habitaciones> ListarTodo()
        {
            List<Habitaciones> habitacion = new List<Habitaciones>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    habitacion = context.Habitaciones.ToList();
                }
                return habitacion;
            }
            catch (Exception ex)
            {
                return habitacion;
            }
        }


    }
}
