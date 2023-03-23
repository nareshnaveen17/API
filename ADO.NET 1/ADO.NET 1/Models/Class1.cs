using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET_1.Models
{
    public class Class1
    {   
        public bool CheckUser(string uname,string pwd)
        {
            string constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
            bool flag ;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from emp where username='" + uname + "' and password='" + pwd + "'", con);
            flag = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return flag;
        }
    }
}