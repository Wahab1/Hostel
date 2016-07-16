using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace Zainab
{
   public class Login
    {
       public static int UserLogin(string userName, string password)
       {
           using (SqlConnection con = Student.GetConnection())
           {
               SqlCommand cmd = new SqlCommand("Select * from tblLogin " +
                                               "where User_Name=@UserName " +
                                               "And Password=@Password",con);
               cmd.Parameters.AddWithValue("@UserName", userName);
               cmd.Parameters.AddWithValue("@Password", password);
               con.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                   return 1;
               }
           }
           return 0;
       }
       #region ChangePassword
       public static int ChangePassword(string userName, string Old_password,string New_Password)
       {
           using (SqlConnection con = Student.GetConnection())
           {
               SqlCommand cmd = new SqlCommand("update tblLogin set Password=@NewPassword" +
                                               " where User_Name=@User And Password=@OldPassword", con);
               cmd.Parameters.AddWithValue("@User", userName);
               cmd.Parameters.AddWithValue("@OldPassword", Old_password);
               cmd.Parameters.AddWithValue("@NewPassword", New_Password);
               con.Open();
              return cmd.ExecuteNonQuery();
           }
       }
       #endregion
    }
}
