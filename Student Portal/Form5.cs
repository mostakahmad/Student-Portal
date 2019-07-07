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
    public partial class teacherSignUp : Form
    {
        public teacherSignUp()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string id = userNameTextBox.Text;

            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();


            string query = "select * from t_teacherID";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader check = command.ExecuteReader();
            while (check.Read())
            {
                if (check[0].ToString() == userNameTextBox.Text)
                {
                    flag = true;
                    break;
                }
            }
            con.Close();


            if (flag == true)
            {
                // add function call
                addDatabase();
            }
            else
            {
                MessageBox.Show("Your ID does not exist.");
            }
            con.Close();
        }

        void addDatabase()
        {
            bool flag = false;
            string id = userNameTextBox.Text;

            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();


            string query = "select * from t_signUpTeacher";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader check = command.ExecuteReader();
            while (check.Read())
            {
                if (check[1].ToString() == textBox3.Text)
                {
                    flag = true;
                    break;
                }
            }
            con.Close();


            if (flag == false)
            {
                // add function call
                addDatabase2();
            }
            else
            {
                MessageBox.Show("Username is already used.");
            }
            con.Close();
        }

        void addDatabase2()
        {
            string username = textBox3.Text;
            string password = textBox4.Text;
            string id = userNameTextBox.Text;

            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

           
            string query = "update t_signUpTeacher set UserName='" + textBox3.Text + "', Password='" + textBox4.Text + "' where [ID] = '" + userNameTextBox.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();

            query = "update t_teacherInfo set Name='" + textBox1.Text + "', Department='" + textBox2.Text + "' where [ID] = '" + userNameTextBox.Text + "'";
            command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Succesfully Complete!");
            con.Close();
        }
    }
}
