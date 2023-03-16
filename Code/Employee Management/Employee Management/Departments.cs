using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ListDepartments();
        }

        private void ListDepartments()
        {
            string Query = "select *  from DeptTable";
            deptList.DataSource = Con.getData(Query);    
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textDepName.Equals(""))
                {
                    MessageBox.Show("Please Fill the Details properly..", "Alert");
                }
                else
                {
                    string Dep = textDepName.Text;
                    string query = "insert into DeptTable values('{0}')";

                    query = string.Format(query,textDepName.Text);
                    Con.setData(query);
                    ListDepartments();
                    MessageBox.Show("DepartMent added successfully","Success");
                    textDepName.Text = "";
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void deptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textDepName.Text = deptList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            if (textDepName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key=Convert.ToInt32(deptList.Rows[e.RowIndex].Cells["DepId"].FormattedValue.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textDepName.Equals(""))
                {
                    MessageBox.Show("Please Fill the Details properly..", "Alert");
                }
                else
                {
                    string Dep = textDepName.Text;
                    string query = "update DeptTable set DepName='{0}' where DepId={1}";
                    query = string.Format(query, textDepName.Text,Key);
                    Con.setData(query);
                    ListDepartments();
                    MessageBox.Show("DepartMent Updated!!");
                    textDepName.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textDepName.Equals(""))
                {
                    MessageBox.Show("Please Fill the Details properly..", "Alert");
                }
                else
                {
                    string Dep = textDepName.Text;
                    string query = "delete from DeptTable where DepId={0}";
                    query = string.Format(query,Key);
                    Con.setData(query);
                    ListDepartments();
                    MessageBox.Show("Department Deleted Successfully..","Success");
                    textDepName.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}