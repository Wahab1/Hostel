using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Zainab
{
    public class Staff
    {
        #region AddStaff
        public static void AddStaff(StaffMember staff)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into vwtblStaff " +
                                                "values(@Name,@CNIC,@Contact," +
                                                "@Address,@Gender,@ImageUrl,@Salary)",con);
                cmd.Parameters.AddWithValue("@Name", staff.FullName);
                cmd.Parameters.AddWithValue("@CNIC", staff.CNIC);
                cmd.Parameters.AddWithValue("@Contact", staff.Mobile);
                cmd.Parameters.AddWithValue("@Address", staff.Address);
                cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                cmd.Parameters.AddWithValue("@ImageUrl", staff.ImageUrl);
                cmd.Parameters.AddWithValue("@Salary", staff.Salary);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region DataLoad
        public static DataSet DataLoad()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from vwtblStaffComplete", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Staff");
                return ds;
            }
        }
        #endregion
        #region Search
        public static DataSet DataSearch(string name)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from vwtblStaffComplete " +
                                                       "where Name like '"+name+"%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Staff");
                return ds;
            }
        }
        #endregion

        public static void DeleteStaff(string id)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Delete from vwtblStaffComplete" +
                                                " where Id=@Id",con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #region UpdateStaff
        public static void UpdateStaff(StaffMember staff)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Update vwtblStaffComplete set Name=@Name" +
                                                ",CNIC=@CNIC,Contact=@Contact,Address=@Address," +
                                                "Gender=@Gender,ImageUrl=@ImageUrl  where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", staff.Id);
                cmd.Parameters.AddWithValue("@Name", staff.FullName);
                cmd.Parameters.AddWithValue("@CNIC", staff.CNIC);
                cmd.Parameters.AddWithValue("@Contact", staff.Mobile);
                cmd.Parameters.AddWithValue("@Address", staff.Address);
                cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                cmd.Parameters.AddWithValue("@ImageUrl", staff.ImageUrl);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
