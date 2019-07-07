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
    public partial class addTeacher : Form
    {
        public addTeacher()
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


            if (flag == false)
            {
                // add function call
                addDatabase();
            }
            else
            {
                MessageBox.Show("This ID is already included.");
            }
            con.Close();
        }

        void addDatabase()
        {
            string id = userNameTextBox.Text;

            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "insert into t_teacherID values(@id)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            query = "insert into t_teacherInfo (ID) values(@id)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            query = "insert into t_signUpTeacher (ID) values(@id)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Added Successfully!");
            con.Close();
        }
    }
}
