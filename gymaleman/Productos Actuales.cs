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
    public partial class ProductosActuales : Form
    {
        MostrarDatos obj = new MostrarDatos();
        public ProductosActuales()
        {
            InitializeComponent();
        }

        private void ProductosActuales_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = obj.vistaTabla1();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
