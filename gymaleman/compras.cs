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
    public partial class compras : Form
    {
        public compras()
        {
            InitializeComponent();
        }

        private void compras_Load(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "gim";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand sql = conn.CreateCommand();
            sql.CommandText = "INSERT INTO  Compras (FolioC, DiaC, MesC, AñoC, ID) VALUES ('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() +"')";
            conn.Open();
            sql.ExecuteNonQuery();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Datos_de_compras a = new Datos_de_compras();
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


            sql.CommandText = "DELETE FROM Compras WHERE FolioC=" + textBox1.Text.ToString();
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


            sql.CommandText = "UPDATE Compras SET DiaC='" + textBox2.Text + "',MesC='" + textBox3.Text + "',AñoC='" + textBox4.Text + "',ID='" + textBox5.Text +
                "'WHERE FolioC=" + textBox1.Text.ToString();
            conn.Open();
            sql.ExecuteNonQuery();
        }
    }
}
