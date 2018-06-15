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
    public partial class ClientesActuales : Form
    {
    
        MostrarDatos obj = new MostrarDatos();

    
    


        public ClientesActuales()
        {
            InitializeComponent();
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = obj.vistaTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
