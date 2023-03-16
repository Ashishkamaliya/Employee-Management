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
    public partial class Salaries : Form
    {
        Functions Con;
        string Period = "";
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        int Dsal = 0;
        private void GetSalary()
        {
            string Query = "select * from EmployeeTbl where EmpId = {0}";
            Query = string.Format(Query, NamecomboBox.SelectedValue.ToString());
            foreach (DataRow dr in Con.getData(Query).Rows)
            {
                Dsal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            if (textAttendedDays.Text == "")
            {
                textSalary.Text = "Rs." + (d * Dsal);
            }
            else if(Convert.ToInt32(textAttendedDays.Text)>31){
                MessageBox.Show("Days cannot be greater than 31","Alert !!");
            }
            else
            {
                d = Convert.ToInt32(textAttendedDays.Text);
                textSalary.Text = "Rs." + (d * Dsal);
            }
        }

        private void ShowSalaries()
        {
            try
            {
                string query = "select * from SalaryTbl";
                SalaryList.DataSource = Con.getData(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";
            NamecomboBox.DisplayMember = Con.getData(Query).Columns["EmpName"].ToString();
            NamecomboBox.ValueMember = Con.getData(Query).Columns["EmpId"].ToString();
            NamecomboBox.DataSource = Con.getData(Query);
        }
        int d = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NamecomboBox.SelectedIndex == -1 || textAttendedDays.Text == "" || PireodDatePicker.Text == "")
            {
                MessageBox.Show("Please Fill the Details properly..","Alert");
            }
            else
            {
                Period = PireodDatePicker.Value.Date.Month.ToString() + "-" + PireodDatePicker.Value.Date.Year.ToString();
                int Amount = Dsal * Convert.ToInt32(textAttendedDays.Text);

                DateTime date = DateTime.Now;
                int Days = Convert.ToInt32(textAttendedDays.Text);
                string query = "insert into SalaryTbl values('{0}',{1},'{2}',{3},'{4}')";

                query = string.Format(query,NamecomboBox.SelectedValue.ToString(), Days, Period, Amount, date.ToString("yyyy-MM-dd"));
                Con.setData(query);
                ShowSalaries();
                MessageBox.Show("Salary Paid Successfully..","Success");
                NamecomboBox.SelectedIndex = -1;
                textAttendedDays.Text = "";
                textSalary.Text = "";
                
            }
        }

        private void NamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }
    }
}


