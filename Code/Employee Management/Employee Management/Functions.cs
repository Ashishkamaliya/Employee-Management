using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Employee_Management
{
    class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter da;
        private string ConStr;
     
        public Functions()
        {
            ConStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable getData(string Query)
        {
            dt = new DataTable();
            da = new SqlDataAdapter(Query,ConStr);
            da.Fill(dt);
            return dt;
        }

        public int setData(string Query)
        {
            int cnt = 0;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}
