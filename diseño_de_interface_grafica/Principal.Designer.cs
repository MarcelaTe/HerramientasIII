namespace diseño_de_interface_grafica
{
    partial class Principal1
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.Facturación = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Acerca_de = new System.Windows.Forms.TabPage();
            this.TapOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFacturación = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlPrincipal.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.Facturación.SuspendLayout();
            this.Seguridad.SuspendLayout();
            this.Acerca_de.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlContenedor);
            this.pnlPrincipal.Controls.Add(this.pnlMenu);
            this.pnlPrincipal.Location = new System.Drawing.Point(1, 65);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1201, 1034);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.TbpMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 1034);
            this.pnlMenu.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.Tablas);
            this.TbpMenu.Controls.Add(this.Facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Acerca_de);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 1034);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.LightBlue;
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 1008);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.Color.LightBlue;
            this.Tablas.Controls.Add(this.button1);
            this.Tablas.Controls.Add(this.btnClientes);
            this.Tablas.Controls.Add(this.btnCategorias);
            this.Tablas.Controls.Add(this.btnProductos);
            this.Tablas.Controls.Add(this.pictureBox2);
            this.Tablas.Location = new System.Drawing.Point(4, 22);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(192, 1008);
            this.Tablas.TabIndex = 1;
            this.Tablas.Text = "Tablas";
            // 
            // Facturación
            // 
            this.Facturación.BackColor = System.Drawing.Color.LightBlue;
            this.Facturación.Controls.Add(this.button2);
            this.Facturación.Controls.Add(this.btnInformes);
            this.Facturación.Controls.Add(this.btnFacturación);
            this.Facturación.Controls.Add(this.pictureBox3);
            this.Facturación.Location = new System.Drawing.Point(4, 22);
            this.Facturación.Name = "Facturación";
            this.Facturación.Size = new System.Drawing.Size(192, 1008);
            this.Facturación.TabIndex = 2;
            this.Facturación.Text = "Facturación";
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.LightBlue;
            this.Seguridad.Controls.Add(this.button3);
            this.Seguridad.Controls.Add(this.btnEmpleados);
            this.Seguridad.Controls.Add(this.btnRoles);
            this.Seguridad.Controls.Add(this.btnSeguridad);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 1008);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // Acerca_de
            // 
            this.Acerca_de.BackColor = System.Drawing.Color.LightBlue;
            this.Acerca_de.Controls.Add(this.button4);
            this.Acerca_de.Controls.Add(this.btnAcerca);
            this.Acerca_de.Controls.Add(this.btnAyuda);
            this.Acerca_de.Controls.Add(this.pictureBox5);
            this.Acerca_de.Location = new System.Drawing.Point(4, 22);
            this.Acerca_de.Name = "Acerca_de";
            this.Acerca_de.Size = new System.Drawing.Size(192, 1008);
            this.Acerca_de.TabIndex = 4;
            this.Acerca_de.Text = "Acerca de";
            // 
            // TapOpcionesMenu
            // 
            this.TapOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.TapOpcionesMenu.Depth = 0;
            this.TapOpcionesMenu.Location = new System.Drawing.Point(374, 33);
            this.TapOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TapOpcionesMenu.Name = "TapOpcionesMenu";
            this.TapOpcionesMenu.Size = new System.Drawing.Size(645, 23);
            this.TapOpcionesMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diseño_de_interface_grafica.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::diseño_de_interface_grafica.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::diseño_de_interface_grafica.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(192, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::diseño_de_interface_grafica.Properties.Resources.logo1;
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(192, 142);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::diseño_de_interface_grafica.Properties.Resources.logo1;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(192, 142);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::diseño_de_interface_grafica.Properties.Resources.exit_1_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(-2, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 52);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::diseño_de_interface_grafica.Properties.Resources.box;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(-1, 195);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(194, 52);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Producto";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Image = global::diseño_de_interface_grafica.Properties.Resources.list;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(-2, 253);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(194, 52);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categoria";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = global::diseño_de_interface_grafica.Properties.Resources.customer;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-1, 311);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(194, 52);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Cientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnFacturación
            // 
            this.btnFacturación.FlatAppearance.BorderSize = 0;
            this.btnFacturación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFacturación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturación.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturación.Image = global::diseño_de_interface_grafica.Properties.Resources.bill;
            this.btnFacturación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturación.Location = new System.Drawing.Point(-1, 196);
            this.btnFacturación.Name = "btnFacturación";
            this.btnFacturación.Size = new System.Drawing.Size(194, 52);
            this.btnFacturación.TabIndex = 2;
            this.btnFacturación.Text = "Facturación";
            this.btnFacturación.UseVisualStyleBackColor = true;
            this.btnFacturación.Click += new System.EventHandler(this.btnFacturación_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Image = global::diseño_de_interface_grafica.Properties.Resources.search;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 254);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(194, 52);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click_1);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.Image = global::diseño_de_interface_grafica.Properties.Resources.verified;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(-1, 191);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(194, 52);
            this.btnSeguridad.TabIndex = 2;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click_1);
            // 
            // btnRoles
            // 
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Image = global::diseño_de_interface_grafica.Properties.Resources.user;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(-2, 249);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(194, 52);
            this.btnRoles.TabIndex = 3;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click_1);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::diseño_de_interface_grafica.Properties.Resources.employee;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(-2, 307);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(194, 52);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click_1);
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Image = global::diseño_de_interface_grafica.Properties.Resources.help_desk;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(-2, 202);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(194, 52);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click_1);
            // 
            // btnAcerca
            // 
            this.btnAcerca.FlatAppearance.BorderSize = 0;
            this.btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.Image = global::diseño_de_interface_grafica.Properties.Resources.question;
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(-2, 260);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(194, 52);
            this.btnAcerca.TabIndex = 3;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::diseño_de_interface_grafica.Properties.Resources.exit_1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, 901);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::diseño_de_interface_grafica.Properties.Resources.exit_1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-1, 888);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::diseño_de_interface_grafica.Properties.Resources.exit_1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-2, 890);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::diseño_de_interface_grafica.Properties.Resources.exit_1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, 894);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1001, 1034);
            this.pnlContenedor.TabIndex = 1;
            // 
            // Principal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 1100);
            this.Controls.Add(this.TapOpcionesMenu);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "Principal1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Facturación";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Tablas.ResumeLayout(false);
            this.Facturación.ResumeLayout(false);
            this.Seguridad.ResumeLayout(false);
            this.Acerca_de.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabPage Facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca_de;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialTabSelector TapOpcionesMenu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnFacturación;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}