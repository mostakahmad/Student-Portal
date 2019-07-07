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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void signUpMenu_Click(object sender, EventArgs e)
        {
            selectOption form = new selectOption();
            form.Show();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administration form = new Administration();
            form.Show();
        }

        private void resultMenu_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            if (teacherRadioButton.Checked)
            {
                bool flag = false;
                

                string connectionString = "server = desktop-b9giqpc; database = StudentPortal; Integrated security = true;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                string query = "select * from t_signUpTeacher";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader check = command.ExecuteReader();
                while (check.Read())
                {
                    if (check[1].ToString() == userNameTextBox.Text && check[2].ToString() == passwordTextBox.Text)
                    {
                        
                        this.Hide();
                        Form8 form = new Form8();
                        form.Show();
                        flag = true;
                        break;
                    }
                }
                con.Close();


                if (flag == true)
                {
                    // add function call
                    //addDatabase();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.");
                }
                con.Close();
                //this.Hide();
                //Form8 form = new Form8();
                //form.Show();
            }
            else if (studentRadioButton.Checked)
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
                    if (check[6].ToString() == userNameTextBox.Text && check[7].ToString() == passwordTextBox.Text)
                    {

                        this.Hide();
                        Form9 form = new Form9();
                        form.Show();
                        flag = true;
                        break;
                    }
                }
                con.Close();


                if (flag == true)
                {
                    // add function call
                    //addDatabase();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.");
                }
                con.Close();
                //this.Hide();
                //Form9 form = new Form9();
                //form.Show();
            }
            else
            {
                MessageBox.Show("Please selsect 'Student' or 'teacherRadioButton'");
            }
        }

        void addDatabase()
        {
            //
        }
    }
}
