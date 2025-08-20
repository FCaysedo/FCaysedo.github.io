using System;
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
    public partial class MenuPrincipal : Form
    {
        private NCliente nCliente = new NCliente();
        private NHabitacion nHabitacion = new NHabitacion();
        private NReserva nReserva = new NReserva();
        public MenuPrincipal()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodo());
            MostrarHabitaciones(nHabitacion.ListarTodo());
            MostrarReservas(nReserva.ListarTodo());
        }

        private void MostrarClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgvClientes.DataSource = clientes;
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtDNICliente.Text == "" || txtNombreCliente.Text == "" || txtApellidosCliente.Text == ""|| txtEdadCliente.Text=="")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Clientes cliente = new Clientes()
            {
                DNI=txtDNICliente.Text,
                Nombre = txtNombreCliente.Text,
                Apellido = txtApellidosCliente.Text,
                Edad = txtEdadCliente.Text,
                FechaRegistro = dtpFechaRegistro.Value
            };

            string mensaje = nCliente.Registrar(cliente);
            MessageBox.Show(mensaje);
            MostrarClientes(nCliente.ListarTodo());
            txtDNICliente.Clear();
            txtNombreCliente.Clear();
            txtApellidosCliente.Clear();
            txtEdadCliente.Clear();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtDNICliente.Text == "" || txtNombreCliente.Text == "" || txtApellidosCliente.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del empleo a buscar o especifique un salario");
                return;
            }

            string DNI=txtDNICliente.Text;
            string Nombre = txtNombreCliente.Text;
            string Apellido = txtApellidosCliente.Text;

            MostrarClientes(nCliente.BuscarClientes(DNI, Nombre, Apellido));

            txtDNICliente.Clear();
            txtNombreCliente.Clear();
            txtApellidosCliente.Clear();
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes(nCliente.ListarTodo());
        }

        private void MostrarHabitaciones(List<Habitaciones> habitaciones)
        {
            dgvHabitaciones.DataSource = null;
            if (habitaciones.Count == 0)
            {
                return;
            }
            else
            {
                dgvClientes.DataSource = habitaciones;
            }
        }

        private void btnRegistrarHabitacion_Click(object sender, EventArgs e)
        {
            if (txtNumHabitacion.Text == "" || cmbEstadoHabitacion.SelectedItem==null|| cmbTipoHabitacion.SelectedItem==null)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Habitaciones habitacion = new Habitaciones()
            {
                Numero = txtNumHabitacion.Text,
                Estado= cmbEstadoHabitacion.SelectedItem,
                Tipo = cmbTipoHabitacion.SelectedItem,
                Fecha_Registro = dtpRegistroHabitacion,
            };

            string mensaje = nHabitacion.Registrar(habitacion);
            MessageBox.Show(mensaje);
            MostrarHabitaciones(nHabitacion.ListarTodo());
            txtNumHabitacion.Clear();
        }

        private void btnModificarHabitacion_Click(object sender, EventArgs e)
        {
            if(dgvHabitaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una habitacion a modificar");
                return;
            }
            else
            {
                int ID_Habitacion = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells["ID_Habitacion"].Value);
                ModificarHabitacion modificarHabitacion= new ModificarHabitacion();
                modificarHabitacion.ShowDialog();
                MostrarHabitaciones(nHabitacion.ListarTodo());
            }
        }

        private void MostrarReservas(List<Reservas> reservas)
        {
            dgvReservas.DataSource = null;
            if (reservas.Count == 0)
            {
                return;
            }
            else
            {
                dgvClientes.DataSource = reservas;
            }
        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            if (cmbIDCliente.SelectedItem == null || cmbIDHabitacion.SelectedItem == null || txtNumNoches.Text == "" || txtNumPersonas.Text== "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Reservas reserva = new Reservas()
            {
                ID_Cliente = cmbIDCliente.SelectedItem.ToString(),
                ID_Habitacion = cmbIDHabitacion.SelectedItem.ToString(),
                Num_Huesped = txtNumPersonas.Text,
                Num_Noches = txtNumNoches.Text,
                Fecha_Entrada = dTPFechaEntrada.Value,
                Fecha_Salida = dTPFechaSalida.Value,
            };
            string mensaje = nReserva.Registrar(reserva);
            MessageBox.Show(mensaje);
            MostrarReservas(nReserva.ListarTodo());
            txtNumPersonas.Clear();
            txtNumNoches.Clear();

        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva a modificar");
                return;
            }
            else
            {
                int ID_Reserva = Convert.ToInt32(dgvReservas.CurrentRow.Cells["ID_Reserva"].Value);
                ModificarReserva modificarReserva = new ModificarReserva();
                modificarReserva.ShowDialog();
                MostrarReservas(nReserva.ListarTodo());
            }
        }

        private void SalirHabitacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btnReporte1_Click(object sender, EventArgs e)
        {
            FrmReservaRangodeFecha ejecutarReporte1 = new FrmReservaRangodeFecha();
            ejecutarReporte1.ShowDialog();
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            FrmReporteReservasPendientes ejecutarReporte2 = new FrmReporteReservasPendientes();
            ejecutarReporte2.ShowDialog();
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            FrmReporteCantidadReservaxTipoHabitacion ejecutarReporte3 = new FrmReporteCantidadReservaxTipoHabitacion();
            ejecutarReporte3.ShowDialog();
        }
    }
}
