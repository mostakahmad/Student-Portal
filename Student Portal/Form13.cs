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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "select [Course Code], [Course Title], [Department] from t_student where ID = '" + userNameTextBox.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView.DataSource = table;

            connection.Close();
        }
    }
}
