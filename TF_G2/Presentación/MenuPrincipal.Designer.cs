namespace Presentación
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCMenu = new System.Windows.Forms.TabControl();
            this.tabPageCliente = new System.Windows.Forms.TabPage();
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.txtEdadCliente = new System.Windows.Forms.TextBox();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageReserva = new System.Windows.Forms.TabPage();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnSalirReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dTPFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dTPFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarReserva = new System.Windows.Forms.Button();
            this.txtNumNoches = new System.Windows.Forms.TextBox();
            this.txtNumPersonas = new System.Windows.Forms.TextBox();
            this.cmbIDHabitacion = new System.Windows.Forms.ComboBox();
            this.cmbIDCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageHabitaciones = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRegistroHabitacion = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.cmbEstadoHabitacion = new System.Windows.Forms.ComboBox();
            this.btnModificarHabitacion = new System.Windows.Forms.Button();
            this.SalirHabitacion = new System.Windows.Forms.Button();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnRegistrarHabitacion = new System.Windows.Forms.Button();
            this.txtNumHabitacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReporte4 = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.tCMenu.SuspendLayout();
            this.tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPageReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.tabPageHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMenu
            // 
            this.tCMenu.Controls.Add(this.tabPageCliente);
            this.tCMenu.Controls.Add(this.tabPageReserva);
            this.tCMenu.Controls.Add(this.tabPageHabitaciones);
            this.tCMenu.Controls.Add(this.tabPage1);
            this.tCMenu.Location = new System.Drawing.Point(13, 14);
            this.tCMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tCMenu.Name = "tCMenu";
            this.tCMenu.SelectedIndex = 0;
            this.tCMenu.Size = new System.Drawing.Size(1225, 624);
            this.tCMenu.TabIndex = 1;
            // 
            // tabPageCliente
            // 
            this.tabPageCliente.Controls.Add(this.btnActualizarClientes);
            this.tabPageCliente.Controls.Add(this.btnBuscarCliente);
            this.tabPageCliente.Controls.Add(this.dtpFechaRegistro);
            this.tabPageCliente.Controls.Add(this.label1);
            this.tabPageCliente.Controls.Add(this.btnSalir);
            this.tabPageCliente.Controls.Add(this.dgvClientes);
            this.tabPageCliente.Controls.Add(this.btnRegistrarCliente);
            this.tabPageCliente.Controls.Add(this.txtEdadCliente);
            this.tabPageCliente.Controls.Add(this.txtApellidosCliente);
            this.tabPageCliente.Controls.Add(this.txtNombreCliente);
            this.tabPageCliente.Controls.Add(this.txtDNICliente);
            this.tabPageCliente.Controls.Add(this.label4);
            this.tabPageCliente.Controls.Add(this.label5);
            this.tabPageCliente.Controls.Add(this.label3);
            this.tabPageCliente.Controls.Add(this.label2);
            this.tabPageCliente.Location = new System.Drawing.Point(4, 29);
            this.tabPageCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageCliente.Name = "tabPageCliente";
            this.tabPageCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageCliente.Size = new System.Drawing.Size(1217, 591);
            this.tabPageCliente.TabIndex = 0;
            this.tabPageCliente.Text = "Cliente";
            this.tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.Location = new System.Drawing.Point(124, 428);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(88, 32);
            this.btnActualizarClientes.TabIndex = 30;
            this.btnActualizarClientes.Text = "Actualizar";
            this.btnActualizarClientes.UseVisualStyleBackColor = true;
            this.btnActualizarClientes.Click += new System.EventHandler(this.btnActualizarClientes_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(125, 379);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(87, 32);
            this.btnBuscarCliente.TabIndex = 29;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(189, 270);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(113, 26);
            this.dtpFechaRegistro.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha de Registro";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(124, 475);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(354, 32);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.Size = new System.Drawing.Size(868, 467);
            this.dgvClientes.TabIndex = 25;
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(125, 329);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(88, 34);
            this.btnRegistrarCliente.TabIndex = 24;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // txtEdadCliente
            // 
            this.txtEdadCliente.Location = new System.Drawing.Point(189, 218);
            this.txtEdadCliente.Name = "txtEdadCliente";
            this.txtEdadCliente.Size = new System.Drawing.Size(113, 26);
            this.txtEdadCliente.TabIndex = 23;
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(189, 166);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(113, 26);
            this.txtApellidosCliente.TabIndex = 22;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(189, 115);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(113, 26);
            this.txtNombreCliente.TabIndex = 21;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(189, 67);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(113, 26);
            this.txtDNICliente.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "DNI";
            // 
            // tabPageReserva
            // 
            this.tabPageReserva.Controls.Add(this.btnModificarReserva);
            this.tabPageReserva.Controls.Add(this.btnSalirReserva);
            this.tabPageReserva.Controls.Add(this.dgvReservas);
            this.tabPageReserva.Controls.Add(this.dTPFechaSalida);
            this.tabPageReserva.Controls.Add(this.dTPFechaEntrada);
            this.tabPageReserva.Controls.Add(this.btnRegistrarReserva);
            this.tabPageReserva.Controls.Add(this.txtNumNoches);
            this.tabPageReserva.Controls.Add(this.txtNumPersonas);
            this.tabPageReserva.Controls.Add(this.cmbIDHabitacion);
            this.tabPageReserva.Controls.Add(this.cmbIDCliente);
            this.tabPageReserva.Controls.Add(this.label9);
            this.tabPageReserva.Controls.Add(this.label8);
            this.tabPageReserva.Controls.Add(this.label6);
            this.tabPageReserva.Controls.Add(this.label11);
            this.tabPageReserva.Controls.Add(this.label12);
            this.tabPageReserva.Controls.Add(this.label13);
            this.tabPageReserva.Location = new System.Drawing.Point(4, 29);
            this.tabPageReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageReserva.Name = "tabPageReserva";
            this.tabPageReserva.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageReserva.Size = new System.Drawing.Size(1217, 591);
            this.tabPageReserva.TabIndex = 1;
            this.tabPageReserva.Text = "Reserva";
            this.tabPageReserva.UseVisualStyleBackColor = true;
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(144, 450);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(102, 31);
            this.btnModificarReserva.TabIndex = 47;
            this.btnModificarReserva.Text = "Modificar";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // btnSalirReserva
            // 
            this.btnSalirReserva.Location = new System.Drawing.Point(138, 514);
            this.btnSalirReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalirReserva.Name = "btnSalirReserva";
            this.btnSalirReserva.Size = new System.Drawing.Size(108, 32);
            this.btnSalirReserva.TabIndex = 46;
            this.btnSalirReserva.Text = "Salir";
            this.btnSalirReserva.UseVisualStyleBackColor = true;
            this.btnSalirReserva.Click += new System.EventHandler(this.btnSalirReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(380, 10);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 62;
            this.dgvReservas.Size = new System.Drawing.Size(795, 536);
            this.dgvReservas.TabIndex = 45;
            // 
            // dTPFechaSalida
            // 
            this.dTPFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFechaSalida.Location = new System.Drawing.Point(216, 315);
            this.dTPFechaSalida.Name = "dTPFechaSalida";
            this.dTPFechaSalida.Size = new System.Drawing.Size(121, 26);
            this.dTPFechaSalida.TabIndex = 44;
            // 
            // dTPFechaEntrada
            // 
            this.dTPFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFechaEntrada.Location = new System.Drawing.Point(216, 258);
            this.dTPFechaEntrada.Name = "dTPFechaEntrada";
            this.dTPFechaEntrada.Size = new System.Drawing.Size(121, 26);
            this.dTPFechaEntrada.TabIndex = 43;
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.Location = new System.Drawing.Point(144, 376);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(102, 32);
            this.btnRegistrarReserva.TabIndex = 41;
            this.btnRegistrarReserva.Text = "Registrar";
            this.btnRegistrarReserva.UseVisualStyleBackColor = true;
            this.btnRegistrarReserva.Click += new System.EventHandler(this.btnRegistrarReserva_Click);
            // 
            // txtNumNoches
            // 
            this.txtNumNoches.Location = new System.Drawing.Point(216, 198);
            this.txtNumNoches.Name = "txtNumNoches";
            this.txtNumNoches.Size = new System.Drawing.Size(121, 26);
            this.txtNumNoches.TabIndex = 40;
            // 
            // txtNumPersonas
            // 
            this.txtNumPersonas.Location = new System.Drawing.Point(216, 154);
            this.txtNumPersonas.Name = "txtNumPersonas";
            this.txtNumPersonas.Size = new System.Drawing.Size(121, 26);
            this.txtNumPersonas.TabIndex = 39;
            // 
            // cmbIDHabitacion
            // 
            this.cmbIDHabitacion.FormattingEnabled = true;
            this.cmbIDHabitacion.Location = new System.Drawing.Point(216, 94);
            this.cmbIDHabitacion.Name = "cmbIDHabitacion";
            this.cmbIDHabitacion.Size = new System.Drawing.Size(121, 28);
            this.cmbIDHabitacion.TabIndex = 37;
            // 
            // cmbIDCliente
            // 
            this.cmbIDCliente.FormattingEnabled = true;
            this.cmbIDCliente.Location = new System.Drawing.Point(216, 34);
            this.cmbIDCliente.Name = "cmbIDCliente";
            this.cmbIDCliente.Size = new System.Drawing.Size(121, 28);
            this.cmbIDCliente.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fecha de Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fecha de Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID_Habitacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "ID_Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cantidad de noches";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cantidad de huespedes";
            // 
            // tabPageHabitaciones
            // 
            this.tabPageHabitaciones.Controls.Add(this.label7);
            this.tabPageHabitaciones.Controls.Add(this.dtpRegistroHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.cmbTipoHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.cmbEstadoHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.btnModificarHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.SalirHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.dgvHabitaciones);
            this.tabPageHabitaciones.Controls.Add(this.btnRegistrarHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.txtNumHabitacion);
            this.tabPageHabitaciones.Controls.Add(this.label15);
            this.tabPageHabitaciones.Controls.Add(this.label17);
            this.tabPageHabitaciones.Controls.Add(this.label18);
            this.tabPageHabitaciones.Location = new System.Drawing.Point(4, 29);
            this.tabPageHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageHabitaciones.Name = "tabPageHabitaciones";
            this.tabPageHabitaciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageHabitaciones.Size = new System.Drawing.Size(1217, 591);
            this.tabPageHabitaciones.TabIndex = 2;
            this.tabPageHabitaciones.Text = "Habitaciones";
            this.tabPageHabitaciones.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fecha de Registro";
            // 
            // dtpRegistroHabitacion
            // 
            this.dtpRegistroHabitacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistroHabitacion.Location = new System.Drawing.Point(199, 223);
            this.dtpRegistroHabitacion.Name = "dtpRegistroHabitacion";
            this.dtpRegistroHabitacion.Size = new System.Drawing.Size(121, 26);
            this.dtpRegistroHabitacion.TabIndex = 43;
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Matrimonial",
            "Familiar"});
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(199, 170);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoHabitacion.TabIndex = 42;
            // 
            // cmbEstadoHabitacion
            // 
            this.cmbEstadoHabitacion.FormattingEnabled = true;
            this.cmbEstadoHabitacion.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "En Limpieza",
            "Mantenimiento"});
            this.cmbEstadoHabitacion.Location = new System.Drawing.Point(199, 119);
            this.cmbEstadoHabitacion.Name = "cmbEstadoHabitacion";
            this.cmbEstadoHabitacion.Size = new System.Drawing.Size(121, 28);
            this.cmbEstadoHabitacion.TabIndex = 41;
            // 
            // btnModificarHabitacion
            // 
            this.btnModificarHabitacion.Location = new System.Drawing.Point(107, 367);
            this.btnModificarHabitacion.Name = "btnModificarHabitacion";
            this.btnModificarHabitacion.Size = new System.Drawing.Size(94, 34);
            this.btnModificarHabitacion.TabIndex = 40;
            this.btnModificarHabitacion.Text = "Modificar";
            this.btnModificarHabitacion.UseVisualStyleBackColor = true;
            this.btnModificarHabitacion.Click += new System.EventHandler(this.btnModificarHabitacion_Click);
            // 
            // SalirHabitacion
            // 
            this.SalirHabitacion.Location = new System.Drawing.Point(107, 427);
            this.SalirHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalirHabitacion.Name = "SalirHabitacion";
            this.SalirHabitacion.Size = new System.Drawing.Size(94, 32);
            this.SalirHabitacion.TabIndex = 39;
            this.SalirHabitacion.Text = "Salir";
            this.SalirHabitacion.UseVisualStyleBackColor = true;
            this.SalirHabitacion.Click += new System.EventHandler(this.SalirHabitacion_Click);
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(338, 35);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersWidth = 62;
            this.dgvHabitaciones.Size = new System.Drawing.Size(868, 424);
            this.dgvHabitaciones.TabIndex = 38;
            // 
            // btnRegistrarHabitacion
            // 
            this.btnRegistrarHabitacion.Location = new System.Drawing.Point(107, 311);
            this.btnRegistrarHabitacion.Name = "btnRegistrarHabitacion";
            this.btnRegistrarHabitacion.Size = new System.Drawing.Size(94, 34);
            this.btnRegistrarHabitacion.TabIndex = 37;
            this.btnRegistrarHabitacion.Text = "Registrar";
            this.btnRegistrarHabitacion.UseVisualStyleBackColor = true;
            this.btnRegistrarHabitacion.Click += new System.EventHandler(this.btnRegistrarHabitacion_Click);
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Location = new System.Drawing.Point(199, 68);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(121, 26);
            this.txtNumHabitacion.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(103, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tipo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(89, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Estado";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(89, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Numero";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReporte4);
            this.tabPage1.Controls.Add(this.btnReporte3);
            this.tabPage1.Controls.Add(this.btnReporte1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1217, 591);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Reportes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnReporte4
            // 
            this.btnReporte4.Location = new System.Drawing.Point(495, 382);
            this.btnReporte4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReporte4.Name = "btnReporte4";
            this.btnReporte4.Size = new System.Drawing.Size(281, 69);
            this.btnReporte4.TabIndex = 9;
            this.btnReporte4.Text = "Reporte de Cantidad de Reservas por Tipo de Habitación";
            this.btnReporte4.UseVisualStyleBackColor = true;
            // 
            // btnReporte3
            // 
            this.btnReporte3.Location = new System.Drawing.Point(495, 243);
            this.btnReporte3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Size = new System.Drawing.Size(281, 69);
            this.btnReporte3.TabIndex = 8;
            this.btnReporte3.Text = "Reporte de Reservas Pendientes (No atendidas)";
            this.btnReporte3.UseVisualStyleBackColor = true;
            // 
            // btnReporte1
            // 
            this.btnReporte1.Location = new System.Drawing.Point(495, 123);
            this.btnReporte1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(281, 69);
            this.btnReporte1.TabIndex = 7;
            this.btnReporte1.Text = "Reporte de Reserva por Rango de Fechas";
            this.btnReporte1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 660);
            this.Controls.Add(this.tCMenu);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.tCMenu.ResumeLayout(false);
            this.tabPageCliente.ResumeLayout(false);
            this.tabPageCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPageReserva.ResumeLayout(false);
            this.tabPageReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.tabPageHabitaciones.ResumeLayout(false);
            this.tabPageHabitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCMenu;
        private System.Windows.Forms.TabPage tabPageCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.TextBox txtEdadCliente;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageReserva;
        private System.Windows.Forms.Button btnSalirReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DateTimePicker dTPFechaSalida;
        private System.Windows.Forms.DateTimePicker dTPFechaEntrada;
        private System.Windows.Forms.Button btnRegistrarReserva;
        private System.Windows.Forms.TextBox txtNumNoches;
        private System.Windows.Forms.TextBox txtNumPersonas;
        private System.Windows.Forms.ComboBox cmbIDHabitacion;
        private System.Windows.Forms.ComboBox cmbIDCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPageHabitaciones;
        private System.Windows.Forms.Button SalirHabitacion;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnRegistrarHabitacion;
        private System.Windows.Forms.TextBox txtNumHabitacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificarHabitacion;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.ComboBox cmbEstadoHabitacion;
        private System.Windows.Forms.Button btnActualizarClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpRegistroHabitacion;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnReporte4;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.Button btnReporte1;
    }
}