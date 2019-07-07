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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "administration@bsm.edu.bd" && passwordTextBox.Text == "bsm123456")
            {
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                addTeacher form = new addTeacher();
                form.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
