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
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            getDepartment();
            showEmp();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet1.DeptTable' table. You can move, or remove it, as needed.
            this.deptTableTableAdapter.Fill(this.employeeDBDataSet1.DeptTable);
            // TODO: This line of code loads data into the 'employeeDBDataSet.EmployeeTbl' table. You can move, or remove it, as needed.
            this.employeeTblTableAdapter.Fill(this.employeeDBDataSet.EmployeeTbl);

        }

        private void showEmp()
        {
            string query = "select * from EmployeeTbl";
            EmployeeList.DataSource = Con.getData(query);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Equals("") || GendercomboBox.SelectedIndex==-1 || departmentComboBox.SelectedIndex==-1 || textSalary.Text=="")
                {
                    MessageBox.Show("Please Fill the Details properly..", "Alert");
                }
                else
                {
                    string Name = textName.Text;
                    string Gender = GendercomboBox.SelectedItem.ToString();
                    int Department = Convert.ToInt32(departmentComboBox.SelectedValue.ToString());
                    //string DOB = birthDatePicker.Value.ToString();
                    //string JDate = joinDatePicker.Value.ToString();
                    int Salary = Convert.ToInt32(textSalary.Text.ToString());


                    string query = "insert into EmployeeTbl values('{0}','{1}',{2},'{3}','{4}',{5})";

                    query = string.Format(query,Name,Gender,Department,birthDatePicker.Text,joinDatePicker.Text,Salary);
                    Con.setData(query);
                    showEmp();
                    MessageBox.Show("Employee added successfully..","Success");
                    textName.Text = "";
                    GendercomboBox.SelectedIndex = -1;
                    departmentComboBox.SelectedIndex = -1;
                    textSalary.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void getDepartment()
        {
            string Query = "select * from DeptTable";
            departmentComboBox.DisplayMember = Con.getData(Query).Columns["DepName"].ToString();
            departmentComboBox.ValueMember = Con.getData(Query).Columns["DepId"].ToString();
            departmentComboBox.DataSource = Con.getData(Query);
        }

        int Key = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Equals("") || GendercomboBox.SelectedIndex == -1 || departmentComboBox.SelectedIndex == -1 || textSalary.Text == "")
                {
                    MessageBox.Show("Please Fill the Details properly..", "Alert");
                }
                else
                {
                    string Name = textName.Text;
                    string Gender = GendercomboBox.SelectedItem.ToString();
                    int Department = Convert.ToInt32(departmentComboBox.SelectedValue.ToString());
                    //string DOB = birthDatePicker.Text;
                    //string JDate = joinDatePicker.Text;
                    int Salary = Convert.ToInt32(textSalary.Text.ToString());

                    string query = "update EmployeeTbl set EmpName='{0}',EmpGen='{1}',EmpDep={2},EmpDOB='{3}',EmpJDate='{4}',EmpSal={5} where EmpId={6}";
                    //string query = "update EmployeeTbl set EmpName='{0}',EmpGen='{1}',EmpDep={2},EmpSal={3} where EmpId={4}";

                    query = string.Format(query, Name, Gender, Department, birthDatePicker.Text, joinDatePicker.Text, Salary, Key);
                    Con.setData(query);
                    showEmp();
                    MessageBox.Show("Data updated successfully..","Success");
                    textName.Text = "";
                    GendercomboBox.SelectedIndex = -1;
                    departmentComboBox.SelectedIndex = -1;
                    textSalary.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textName.Text = EmployeeList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            GendercomboBox.Text = EmployeeList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            departmentComboBox.SelectedValue = EmployeeList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            birthDatePicker.Text = EmployeeList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            joinDatePicker.Text = EmployeeList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            textSalary.Text = EmployeeList.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

            if (textName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.Rows[e.RowIndex].Cells["EmpId"].FormattedValue.ToString());
            }
        }
    }
}
