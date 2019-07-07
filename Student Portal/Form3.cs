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
    public partial class selectOption : Form
    {
        public selectOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (teacherRadio.Checked)
            {
                teacherSignUp form = new teacherSignUp();
                form.Show();
            }
            else
            {
                SignUp form = new SignUp();
                form.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
