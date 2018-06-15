using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gymaleman.DAD;
namespace gymaleman
{
    public partial class Datos_de_compras : Form
    {
        MostrarDatos obj = new MostrarDatos();

        public Datos_de_compras()
        {
            InitializeComponent();
        }

        private void Datos_de_compras_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.vistaTabla3();
        }
    }
}
