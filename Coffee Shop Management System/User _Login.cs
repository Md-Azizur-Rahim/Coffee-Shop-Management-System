using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coffee_Shop_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (txt_user_email.Text == "" || txt_user_password.Text == "")

            {
                MessageBox.Show("Please enter email and password");
                return;
            }

            string connectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog=Cofee Shop Management System; Integrated Security = True";

            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query =
                    "SELECT r.RoleName " +
                    "FROM Employees e " +
                    "JOIN Roles r ON e.RoleId = r.RoleId " +
                    "WHERE e.Useremail = @Email AND e.Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", txt_user_email.Text);
                cmd.Parameters.AddWithValue("@Password", txt_user_password.Text);

                con.Open();

                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    MessageBox.Show("Login successful");

                    if (role.ToString() == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else
                    {
                        EmployeeDashboard emp = new EmployeeDashboard();
                        emp.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong email or password");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
