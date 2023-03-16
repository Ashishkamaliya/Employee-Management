using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            loadform(new Employees());
        }

        public void loadform(object Form)
        {
            if (this.ContentPanel.Controls.Count > 0)
                this.ContentPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ContentPanel.Controls.Add(f);
            this.ContentPanel.Tag = f;
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadform(new Employees());
        }

        private void lblDepts_Click(object sender, EventArgs e)
        {
            loadform(new Departments());
        }

        private void lblSalaries_Click(object sender, EventArgs e)
        {
            loadform(new Salaries());
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
