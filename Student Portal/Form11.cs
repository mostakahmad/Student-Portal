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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;

            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();


            string query = "select * from t_student";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader check = command.ExecuteReader();
            while (check.Read())
            {
                if (check[0].ToString() == userNameTextBox.Text && check[2].ToString() == CTitle.Text)
                {
                    flag = true;
                    break;
                }
            }
            con.Close();

            if (flag == true)
            {
                // add function call
                addDatabase2();
            }
            else
            {
                MessageBox.Show("This Course Is Not Taken Yet.");
            }
            con.Close();
        }

        void addDatabase2()
        {
            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "update t_student set [Grade Point] ='" + GPoint.Text + "' where [ID] = '" + userNameTextBox.Text + "' and [Course Title] = '" + CTitle.Text + "' ";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Succesfully Complete!");
            this.Hide();
            con.Close();
        }
    }
}
