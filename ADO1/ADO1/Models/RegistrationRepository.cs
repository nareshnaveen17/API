using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO1.Models
{
    public class RegistrationRepository
    {
        public bool Reg(Registration reg)
        {
            string constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
            bool flag;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", reg.Username);
            cmd.Parameters.AddWithValue("@password", reg.Password);
            cmd.Parameters.AddWithValue("email", reg.Email);
            cmd.Parameters.AddWithValue("mobile", reg.Mobile);
            flag = Convert.ToBoolean(cmd.ExecuteNonQuery());
            con.Close();
            return flag;
        }
    }
}