using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Portal
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
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

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn form = new LogIn();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
        }

        private void resultMenu_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.Show();
        }
    }
}
