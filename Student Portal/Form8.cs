using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Portal
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            p1.Text = "     Full Name";
            p2.Text = "     Post";
            p3.Text = "     e-mail";
            p4.Text = "     Department";
            p5.Text = "     Mobile or Telephone Number";
            p6.Text = "     Present  Address";
            p7.Text = "     Parmanent Address";

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn form = new LogIn();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
