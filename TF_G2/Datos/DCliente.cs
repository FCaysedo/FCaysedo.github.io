using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public string Registrar(Clientes cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
                return "Cliente Registrado Correctamente";
            }
            catch (Exception ex)
            {
                return "Error al ingresar, intente de nuevo";
            }
        }

        public List<Clientes> ListarTodo()
        {
            List<Clientes> cliente = new List<Clientes>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    cliente = context.Clientes.ToList();
                }
                return cliente;
            }
            catch (Exception ex)
            {
                return cliente;
            }
        }

        public List<Clientes> BuscarClientes(string DNI = null, string Nombre = null, string Apellido = null)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var consulta = context.Clientes.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(DNI))
                    {
                        consulta = consulta.Where(a => a.DNI.Equals(DNI));
                    }

                    if (!string.IsNullOrWhiteSpace(Nombre))
                    {
                        consulta = consulta.Where(a => a.Nombre.Equals(Nombre));
                    }

                    if (!string.IsNullOrWhiteSpace(Apellido))
                    {
                        consulta = consulta.Where(a => a.Apellido.Equals(Apellido));
                    }

                    clientes = consulta.ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
    }
}
