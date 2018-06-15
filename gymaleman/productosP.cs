using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gymaleman
{
    public partial class productosP : Form
    {
        public productosP()
        {
            InitializeComponent();
        }

        private void productosP_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "gim";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand sql = conn.CreateCommand();
            sql.CommandText = "INSERT INTO  Productos (IDP, DescripcionP, CostoP, UnidadMedia, Existencia, PrecioUnidad, Nombre) VALUES ('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString()+ "', '" + textBox7.Text.ToString() + "')";
            conn.Open();
            sql.ExecuteNonQuery();
        }

         private void button1_Click(object sender, EventArgs e)
          {
            ProductosActuales a = new ProductosActuales();
            a.Show();

            }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "gim";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand sql = conn.CreateCommand();


            sql.CommandText = "DELETE FROM Productos WHERE IDP=" + textBox1.Text.ToString();
            conn.Open();
            sql.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "gim";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand sql = conn.CreateCommand();


            sql.CommandText = "UPDATE Productos SET DescripcionP='" + textBox2.Text + "',CostoP='" + textBox3.Text +
                "',UnidadMedia='" + textBox4.Text + "',Existencia='" + textBox5.Text + "',PrecioUnidad='" + textBox6.Text + "',Nombre='"+ textBox7.Text+
                "'WHERE IDP=" + textBox1.Text.ToString();
            conn.Open();
            sql.ExecuteNonQuery();
        }
    }
    }

