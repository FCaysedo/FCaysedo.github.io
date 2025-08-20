using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();
        public string Registrar(Clientes cliente)
        {
            return dCliente.Registrar(cliente);
        }

        public List<Clientes> ListarTodo()
        {
            return dCliente.ListarTodo();
        }

        public List<Clientes> BuscarClientes(string DNI, string Nombre, string Apellido)
        {
            return dCliente.BuscarClientes(DNI, Nombre, Apellido);
        }
    }
}
