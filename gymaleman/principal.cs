using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymaleman
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 ancho = (this.Width = panel3.Width) / 2;
            panel3.Location = new Point(ancho, panel3.Location.Y);
            fecha.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
        }
        private void abrirclienteCpanel(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fm = formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fm);
            this.panel3.Tag = fm;
            fm.Show();
        }
        private void Clientes_Click(object sender, EventArgs e)
        {
            //abrirclienteCpanel(new clientesC());
            clientesC a = new clientesC();
            a.Show();
        }
        private void abrirventaVpanel(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fm = formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fm);
            this.panel3.Tag = fm;
            fm.Show();
        }
        private void Ventas_Click(object sender, EventArgs e)
        {
           // abrirventaVpanel(new ventasV());
            ventasV a = new ventasV();
            a.Show();
        }
        private void abrirproductosPpanel(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fm = formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fm);
            this.panel3.Tag = fm;
            fm.Show();
        }
        private void Productos_Click(object sender, EventArgs e)
        {
            //abrirproductosPpanel(new productosP());
            productosP a = new productosP();
            a.Show();
           
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            compras a = new compras();
            a.Show();
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            servicioS a = new servicioS();
            a.Show();
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            inventarioI a = new inventarioI();
            a.Show();
            
        }
        private void provedor_Click(object sender, EventArgs e)
        {
            proveedorP pr = new proveedorP();
            pr.Show();
        }

        private void Clientes_MouseLeave_1(object sender, EventArgs e)
        {
            Clientes.BackgroundImageLayout = ImageLayout.Zoom;
            Clientes.BackgroundImage = Properties.Resources.cliente2;
        }

        private void Ventas_MouseLeave(object sender, EventArgs e)
        {
            Ventas.BackgroundImageLayout = ImageLayout.Zoom;
            Ventas.BackgroundImage = Properties.Resources.venta;
        }
        private void Productos_MouseLeave(object sender, EventArgs e)
        {
            Productos.BackgroundImageLayout = ImageLayout.Zoom;
            Productos.BackgroundImage = Properties.Resources.productos;
        }
        private void Compras_MouseLeave(object sender, EventArgs e)
        {
            Compras.BackgroundImageLayout = ImageLayout.Zoom;
            Compras.BackgroundImage = Properties.Resources.compra;
        }
        private void Servicios_MouseLeave(object sender, EventArgs e)
        {
            Servicios.BackgroundImageLayout = ImageLayout.Zoom;
            Servicios.BackgroundImage = Properties.Resources.servicio;
        }

        private void Inventario_MouseLeave(object sender, EventArgs e)
        {
            Inventario.BackgroundImageLayout = ImageLayout.Zoom;
            Inventario.BackgroundImage = Properties.Resources.inventario;
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BD.ObtenerConexion();
            MessageBox.Show("Conectado");
        }

        private void Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
