namespace gymaleman
{
    partial class principal
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
            this.components = new System.ComponentModel.Container();
            this.fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ventas = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.Button();
            this.Compra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Compras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Servicios = new System.Windows.Forms.Button();
            this.Inventario = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Label();
            this.Provedores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Teal;
            this.fecha.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(403, 3);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(55, 18);
            this.fecha.TabIndex = 14;
            this.fecha.Text = "Fecha:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.hora);
            this.panel2.Controls.Add(this.fecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 27);
            this.panel2.TabIndex = 16;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(653, 3);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(48, 18);
            this.hora.TabIndex = 15;
            this.hora.Text = "Hora:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.MaximumSize = new System.Drawing.Size(734, 340);
            this.panel3.MinimumSize = new System.Drawing.Size(734, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 340);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ventas";
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.Transparent;
            this.Clientes.BackgroundImage = global::gymaleman.Properties.Resources.cliente2;
            this.Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clientes.Location = new System.Drawing.Point(12, -1);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(75, 46);
            this.Clientes.TabIndex = 0;
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            this.Clientes.MouseLeave += new System.EventHandler(this.Clientes_MouseLeave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Productos";
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.Color.Transparent;
            this.Ventas.BackgroundImage = global::gymaleman.Properties.Resources.venta;
            this.Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ventas.Location = new System.Drawing.Point(302, 3);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(75, 46);
            this.Ventas.TabIndex = 0;
            this.Ventas.UseVisualStyleBackColor = false;
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            this.Ventas.MouseLeave += new System.EventHandler(this.Ventas_MouseLeave);
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.Transparent;
            this.Productos.BackgroundImage = global::gymaleman.Properties.Resources.productos;
            this.Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Productos.Location = new System.Drawing.Point(202, 0);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(75, 46);
            this.Productos.TabIndex = 0;
            this.Productos.UseVisualStyleBackColor = false;
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            this.Productos.MouseLeave += new System.EventHandler(this.Productos_MouseLeave);
            // 
            // Compra
            // 
            this.Compra.AutoSize = true;
            this.Compra.BackColor = System.Drawing.Color.Transparent;
            this.Compra.ForeColor = System.Drawing.Color.White;
            this.Compra.Location = new System.Drawing.Point(111, 52);
            this.Compra.Name = "Compra";
            this.Compra.Size = new System.Drawing.Size(48, 13);
            this.Compra.TabIndex = 10;
            this.Compra.Text = "Compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Servicios";
            // 
            // Compras
            // 
            this.Compras.BackgroundImage = global::gymaleman.Properties.Resources.compra;
            this.Compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Compras.Location = new System.Drawing.Point(102, 3);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(75, 46);
            this.Compras.TabIndex = 0;
            this.Compras.UseVisualStyleBackColor = true;
            this.Compras.Click += new System.EventHandler(this.Compras_Click);
            this.Compras.MouseLeave += new System.EventHandler(this.Compras_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(483, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inventario";
            // 
            // Servicios
            // 
            this.Servicios.BackgroundImage = global::gymaleman.Properties.Resources.servicio;
            this.Servicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Servicios.Location = new System.Drawing.Point(383, 0);
            this.Servicios.Name = "Servicios";
            this.Servicios.Size = new System.Drawing.Size(75, 46);
            this.Servicios.TabIndex = 0;
            this.Servicios.UseVisualStyleBackColor = true;
            this.Servicios.Click += new System.EventHandler(this.Servicios_Click);
            this.Servicios.MouseLeave += new System.EventHandler(this.Servicios_MouseLeave);
            // 
            // Inventario
            // 
            this.Inventario.BackgroundImage = global::gymaleman.Properties.Resources.inventario2;
            this.Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventario.Location = new System.Drawing.Point(473, -1);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(75, 46);
            this.Inventario.TabIndex = 0;
            this.Inventario.UseVisualStyleBackColor = true;
            this.Inventario.Click += new System.EventHandler(this.Inventario_Click);
            this.Inventario.MouseLeave += new System.EventHandler(this.Inventario_MouseLeave);
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSize = true;
            this.Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.Proveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.Proveedor.Location = new System.Drawing.Point(572, 48);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(55, 13);
            this.Proveedor.TabIndex = 12;
            this.Proveedor.Text = "proveedor";
            this.Proveedor.Click += new System.EventHandler(this.Proveedor_Click);
            // 
            // Provedores
            // 
            this.Provedores.BackColor = System.Drawing.Color.Transparent;
            this.Provedores.BackgroundImage = global::gymaleman.Properties.Resources.proveedor;
            this.Provedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Provedores.Location = new System.Drawing.Point(564, 0);
            this.Provedores.Name = "Provedores";
            this.Provedores.Size = new System.Drawing.Size(75, 45);
            this.Provedores.TabIndex = 13;
            this.Provedores.UseVisualStyleBackColor = false;
            this.Provedores.Click += new System.EventHandler(this.provedor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Ventas);
            this.panel1.Controls.Add(this.Provedores);
            this.panel1.Controls.Add(this.Proveedor);
            this.panel1.Controls.Add(this.Inventario);
            this.panel1.Controls.Add(this.Servicios);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Compras);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Compra);
            this.panel1.Controls.Add(this.Productos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Clientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 76);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gymaleman.Properties.Resources.tercera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 500);
            this.Name = "principal";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Label Compra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Compras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Servicios;
        private System.Windows.Forms.Button Inventario;
        private System.Windows.Forms.Label Proveedor;
        private System.Windows.Forms.Button Provedores;
        private System.Windows.Forms.Panel panel1;
    }
}