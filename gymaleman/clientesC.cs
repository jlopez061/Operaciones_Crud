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
    public partial class clientesC : Form
    {



        public clientesC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientesC_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            sql.CommandText = "INSERT INTO Clientes (IDC, Nombre, ApellitoPaterno, ApellidoMaterno, Dia, Mes, Año) VALUES ('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + textBox7.Text.ToString() + "')";
            conn.Open();
            sql.ExecuteNonQuery();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { ClientesActuales a = new ClientesActuales();
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


            sql.CommandText = "DELETE FROM Clientes WHERE IDC=" + textBox1.Text.ToString();
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
            
            
            sql.CommandText = "UPDATE Clientes SET Nombre='" + textBox2.Text + "',ApellitoPaterno='"+ textBox3.Text + 
                "',ApellidoMaterno='" +textBox4.Text + "',Dia='"+textBox5.Text+ "',Mes='"+ textBox6.Text + "',Año='"+ textBox7.Text +
                "'WHERE IDC=" + textBox1.Text.ToString();
            conn.Open();
            sql.ExecuteNonQuery();

        }

    }
        }

