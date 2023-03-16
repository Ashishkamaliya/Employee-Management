using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class Login : Form
    {
        string ConStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string uname = textUsername.Text.ToString();
            string pass = textPassword.Text.ToString();

            if (uname == "" || pass == "")
            {
                lblAlert.Text = "Please Fill Details Properly..";
            }
            else
            {
                con = new SqlConnection(ConStr);
                con.Open();
                string query = "select * from admin where username='{0}' and password='{1}'";

                query = string.Format(query, uname, pass);
                cmd = new SqlCommand(query, con);


                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    lblAlert.Text = "Invalid Credentials..";
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPassword.Text = "";
            lblAlert.Text = "";
        }

    }
}
