namespace SistemaPuntoVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpc_Principal = new System.Windows.Forms.TabControl();
            this.tab_ventas = new System.Windows.Forms.TabPage();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_ClienteCredito = new System.Windows.Forms.CheckBox();
            this.btn_eliminarCliente = new System.Windows.Forms.Button();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.txt_direccionCliente = new System.Windows.Forms.TextBox();
            this.label_direccionCliente = new System.Windows.Forms.Label();
            this.txt_telefonoCliente = new System.Windows.Forms.TextBox();
            this.label_telefonoCliente = new System.Windows.Forms.Label();
            this.txt_emailCliente = new System.Windows.Forms.TextBox();
            this.label_emailCliente = new System.Windows.Forms.Label();
            this.txt_apellidoCliente = new System.Windows.Forms.TextBox();
            this.label_apellidoCliente = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.label_clienteNombre = new System.Windows.Forms.Label();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.label_idCliente = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pb_clietne = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_clietneBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpc_Principal.SuspendLayout();
            this.tab_clientes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clietne)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpc_Principal
            // 
            this.tpc_Principal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tpc_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpc_Principal.Controls.Add(this.tab_ventas);
            this.tpc_Principal.Controls.Add(this.tab_clientes);
            this.tpc_Principal.Location = new System.Drawing.Point(12, 117);
            this.tpc_Principal.Name = "tpc_Principal";
            this.tpc_Principal.SelectedIndex = 0;
            this.tpc_Principal.Size = new System.Drawing.Size(1056, 572);
            this.tpc_Principal.TabIndex = 1;
            // 
            // tab_ventas
            // 
            this.tab_ventas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_ventas.Location = new System.Drawing.Point(4, 4);
            this.tab_ventas.Name = "tab_ventas";
            this.tab_ventas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ventas.Size = new System.Drawing.Size(1048, 546);
            this.tab_ventas.TabIndex = 0;
            this.tab_ventas.Text = "Ventas";
            this.tab_ventas.UseVisualStyleBackColor = true;
            // 
            // tab_clientes
            // 
            this.tab_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_clientes.Controls.Add(this.groupBox5);
            this.tab_clientes.Controls.Add(this.groupBox3);
            this.tab_clientes.Controls.Add(this.groupBox2);
            this.tab_clientes.Location = new System.Drawing.Point(4, 4);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_clientes.Size = new System.Drawing.Size(1048, 546);
            this.tab_clientes.TabIndex = 1;
            this.tab_clientes.Text = "Clientes";
            this.tab_clientes.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(319, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(721, 471);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Location = new System.Drawing.Point(6, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 472);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(6, 14);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(290, 415);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_ClienteCredito);
            this.tabPage1.Controls.Add(this.btn_eliminarCliente);
            this.tabPage1.Controls.Add(this.btn_agregarCliente);
            this.tabPage1.Controls.Add(this.txt_direccionCliente);
            this.tabPage1.Controls.Add(this.label_direccionCliente);
            this.tabPage1.Controls.Add(this.txt_telefonoCliente);
            this.tabPage1.Controls.Add(this.label_telefonoCliente);
            this.tabPage1.Controls.Add(this.txt_emailCliente);
            this.tabPage1.Controls.Add(this.label_emailCliente);
            this.tabPage1.Controls.Add(this.txt_apellidoCliente);
            this.tabPage1.Controls.Add(this.label_apellidoCliente);
            this.tabPage1.Controls.Add(this.txt_nombreCliente);
            this.tabPage1.Controls.Add(this.label_clienteNombre);
            this.tabPage1.Controls.Add(this.txt_idCliente);
            this.tabPage1.Controls.Add(this.label_idCliente);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_ClienteCredito
            // 
            this.checkBox_ClienteCredito.AutoSize = true;
            this.checkBox_ClienteCredito.Location = new System.Drawing.Point(11, 314);
            this.checkBox_ClienteCredito.Name = "checkBox_ClienteCredito";
            this.checkBox_ClienteCredito.Size = new System.Drawing.Size(59, 17);
            this.checkBox_ClienteCredito.TabIndex = 0;
            this.checkBox_ClienteCredito.Text = "Credito";
            this.checkBox_ClienteCredito.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarCliente
            // 
            this.btn_eliminarCliente.Location = new System.Drawing.Point(148, 347);
            this.btn_eliminarCliente.Name = "btn_eliminarCliente";
            this.btn_eliminarCliente.Size = new System.Drawing.Size(96, 28);
            this.btn_eliminarCliente.TabIndex = 14;
            this.btn_eliminarCliente.Text = "Eliminar";
            this.btn_eliminarCliente.UseVisualStyleBackColor = true;
            this.btn_eliminarCliente.Click += new System.EventHandler(this.btn_eliminarCliente_Click);
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Location = new System.Drawing.Point(30, 347);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(96, 28);
            this.btn_agregarCliente.TabIndex = 4;
            this.btn_agregarCliente.Text = "Agregar";
            this.btn_agregarCliente.UseVisualStyleBackColor = true;
            this.btn_agregarCliente.Click += new System.EventHandler(this.btn_agregarCliente_Click);
            // 
            // txt_direccionCliente
            // 
            this.txt_direccionCliente.Location = new System.Drawing.Point(127, 284);
            this.txt_direccionCliente.Name = "txt_direccionCliente";
            this.txt_direccionCliente.Size = new System.Drawing.Size(147, 20);
            this.txt_direccionCliente.TabIndex = 12;
            this.txt_direccionCliente.TextChanged += new System.EventHandler(this.txt_direccionCliente_TextChanged);
            // 
            // label_direccionCliente
            // 
            this.label_direccionCliente.AutoSize = true;
            this.label_direccionCliente.Location = new System.Drawing.Point(133, 268);
            this.label_direccionCliente.Name = "label_direccionCliente";
            this.label_direccionCliente.Size = new System.Drawing.Size(52, 13);
            this.label_direccionCliente.TabIndex = 13;
            this.label_direccionCliente.Text = "Direccion";
            // 
            // txt_telefonoCliente
            // 
            this.txt_telefonoCliente.Location = new System.Drawing.Point(10, 284);
            this.txt_telefonoCliente.Name = "txt_telefonoCliente";
            this.txt_telefonoCliente.Size = new System.Drawing.Size(106, 20);
            this.txt_telefonoCliente.TabIndex = 10;
            this.txt_telefonoCliente.TextChanged += new System.EventHandler(this.txt_telefonoCliente_TextChanged);
            this.txt_telefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoCliente_KeyPress);
            // 
            // label_telefonoCliente
            // 
            this.label_telefonoCliente.AutoSize = true;
            this.label_telefonoCliente.Location = new System.Drawing.Point(12, 268);
            this.label_telefonoCliente.Name = "label_telefonoCliente";
            this.label_telefonoCliente.Size = new System.Drawing.Size(49, 13);
            this.label_telefonoCliente.TabIndex = 11;
            this.label_telefonoCliente.Text = "Telefono";
            // 
            // txt_emailCliente
            // 
            this.txt_emailCliente.Location = new System.Drawing.Point(127, 238);
            this.txt_emailCliente.Name = "txt_emailCliente";
            this.txt_emailCliente.Size = new System.Drawing.Size(147, 20);
            this.txt_emailCliente.TabIndex = 8;
            this.txt_emailCliente.TextChanged += new System.EventHandler(this.txt_emailCliente_TextChanged);
            // 
            // label_emailCliente
            // 
            this.label_emailCliente.AutoSize = true;
            this.label_emailCliente.Location = new System.Drawing.Point(133, 222);
            this.label_emailCliente.Name = "label_emailCliente";
            this.label_emailCliente.Size = new System.Drawing.Size(32, 13);
            this.label_emailCliente.TabIndex = 9;
            this.label_emailCliente.Text = "Email";
            // 
            // txt_apellidoCliente
            // 
            this.txt_apellidoCliente.Location = new System.Drawing.Point(10, 238);
            this.txt_apellidoCliente.Name = "txt_apellidoCliente";
            this.txt_apellidoCliente.Size = new System.Drawing.Size(106, 20);
            this.txt_apellidoCliente.TabIndex = 6;
            this.txt_apellidoCliente.TextChanged += new System.EventHandler(this.txt_apellidoCliente_TextChanged);
            this.txt_apellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidoCliente_KeyPress);
            // 
            // label_apellidoCliente
            // 
            this.label_apellidoCliente.AutoSize = true;
            this.label_apellidoCliente.Location = new System.Drawing.Point(12, 222);
            this.label_apellidoCliente.Name = "label_apellidoCliente";
            this.label_apellidoCliente.Size = new System.Drawing.Size(44, 13);
            this.label_apellidoCliente.TabIndex = 7;
            this.label_apellidoCliente.Text = "Apellido";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(141, 194);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(133, 20);
            this.txt_nombreCliente.TabIndex = 4;
            this.txt_nombreCliente.TextChanged += new System.EventHandler(this.txt_nombreCliente_TextChanged);
            this.txt_nombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreCliente_KeyPress);
            // 
            // label_clienteNombre
            // 
            this.label_clienteNombre.AutoSize = true;
            this.label_clienteNombre.Location = new System.Drawing.Point(143, 178);
            this.label_clienteNombre.Name = "label_clienteNombre";
            this.label_clienteNombre.Size = new System.Drawing.Size(44, 13);
            this.label_clienteNombre.TabIndex = 5;
            this.label_clienteNombre.Text = "Nombre";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Location = new System.Drawing.Point(9, 194);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(115, 20);
            this.txt_idCliente.TabIndex = 3;
            this.txt_idCliente.TextChanged += new System.EventHandler(this.txt_idCliente_TextChanged);
            this.txt_idCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idCliente_KeyPress);
            // 
            // label_idCliente
            // 
            this.label_idCliente.AutoSize = true;
            this.label_idCliente.Location = new System.Drawing.Point(11, 178);
            this.label_idCliente.Name = "label_idCliente";
            this.label_idCliente.Size = new System.Drawing.Size(79, 13);
            this.label_idCliente.TabIndex = 3;
            this.label_idCliente.Text = "Num. Identidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pb_clietne);
            this.groupBox4.Location = new System.Drawing.Point(63, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 134);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // pb_clietne
            // 
            this.pb_clietne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_clietne.Image = global::SistemaPuntoVenta.Properties.Resources.wallpapersden_com_witcher_3_artstation_fan_art_1366x768;
            this.pb_clietne.Location = new System.Drawing.Point(11, 15);
            this.pb_clietne.Name = "pb_clietne";
            this.pb_clietne.Size = new System.Drawing.Size(133, 104);
            this.pb_clietne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_clietne.TabIndex = 3;
            this.pb_clietne.TabStop = false;
            this.pb_clietne.Click += new System.EventHandler(this.pb_clietne_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informacion del nuevo cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pago";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_clietneBuscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_clietneBuscar
            // 
            this.txt_clietneBuscar.Location = new System.Drawing.Point(308, 15);
            this.txt_clietneBuscar.Multiline = true;
            this.txt_clietneBuscar.Name = "txt_clietneBuscar";
            this.txt_clietneBuscar.Size = new System.Drawing.Size(197, 27);
            this.txt_clietneBuscar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes";
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(16, 78);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(96, 28);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaPuntoVenta.Properties.Resources.wallpapersden_com_witcher_3_artstation_fan_art_1366x768;
            this.pictureBox1.Location = new System.Drawing.Point(17, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Punto de Venta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1080, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.tpc_Principal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tpc_Principal.ResumeLayout(false);
            this.tab_clientes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_clietne)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tpc_Principal;
        private System.Windows.Forms.TabPage tab_ventas;
        private System.Windows.Forms.TabPage tab_clientes;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_clietneBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idCliente;
        private System.Windows.Forms.Label label_idCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pb_clietne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label label_clienteNombre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_eliminarCliente;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.TextBox txt_direccionCliente;
        private System.Windows.Forms.Label label_direccionCliente;
        private System.Windows.Forms.TextBox txt_telefonoCliente;
        private System.Windows.Forms.Label label_telefonoCliente;
        private System.Windows.Forms.TextBox txt_emailCliente;
        private System.Windows.Forms.Label label_emailCliente;
        private System.Windows.Forms.TextBox txt_apellidoCliente;
        private System.Windows.Forms.Label label_apellidoCliente;
        private System.Windows.Forms.CheckBox checkBox_ClienteCredito;
    }
}

