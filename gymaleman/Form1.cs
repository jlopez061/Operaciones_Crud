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
    public partial class Form1 : Form
    {
        Point formposition;
        Boolean mouseAction;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            formposition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formposition.X, Cursor.Position.Y - formposition.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 20;
                label1.Text = " cargando" + progressBar1.Value + "%";
            }
            else
            {
                timer1.Enabled = false;
               
                principal pr = new principal();
                pr.Show();
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
