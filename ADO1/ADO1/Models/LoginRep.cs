    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO1.Models
{
    public class LoginRep
    {   
        public bool CheckUser(string tusername,string tpassword)
        {
            string constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
            bool flag;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from emp where username='" + tusername + "' and password='" + tpassword + "'", con);
            flag = Convert.ToBoolean(cmd.ExecuteScalar());
            return flag;
        }
    }
}