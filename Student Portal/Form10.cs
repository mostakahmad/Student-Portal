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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = userNameTextBox.Text;
            string code = CCode.Text;
            string title = CTitle.Text;

            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();


            string query = "insert into t_student (ID, [Course Code], [Course Title]) Values(@id,  @code, @title)";
            //string query = "insert into t_student values(@id)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@title", title);
            command.ExecuteNonQuery();
            MessageBox.Show("Courser  is added successfully!");
            con.Close();
            this.Hide();
        }
    }
}
