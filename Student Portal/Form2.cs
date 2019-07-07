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
    public partial class SignUp : Form
    {
        public SignUp()
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


            string query = "select * from t_student";
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


            string query = "select * from t_student";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader check = command.ExecuteReader();
            while (check.Read())
            {
                if (check[6].ToString() == username.Text)
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
            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "update t_student set UserName='" + username.Text + "', Password='" + password.Text + "' where [ID] = '" + userNameTextBox.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Succesfully Complete!");
            con.Close();
        }
    }
}
