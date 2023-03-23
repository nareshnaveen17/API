using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO2.Models
{
    public class UserRep
    {   
        public List<UserModel> GetUser()
        {
            string constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
            SqlConnection con = new SqlConnection(constr);
            string q = "select * from emp";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            List<UserModel> obj = new List<UserModel>();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                obj.Add(new UserModel()
                {
                    Username = Convert.ToString(dr["Username"]),
                    Password = Convert.ToString(dr["Password"]),
                    Email= Convert.ToString(dr["Email"]),
                    Mobile= Convert.ToInt64(dr["mobile"])
                }) ;
            }
            return obj;
        }
    }
}