using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace Zainab
{
    public class Visitor
    {
        #region AddVisitor
        public static void AddVisitor(VisitorMember visitor)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into tblVisitor values" +
                                                "(@Full_Name,@CNIC,@Contact,@Address)",con);
                cmd.Parameters.AddWithValue("@Full_Name", visitor.FullName);
                cmd.Parameters.AddWithValue("@CNIC", visitor.CNIC);
                cmd.Parameters.AddWithValue("@Contact", visitor.Mobile);
                cmd.Parameters.AddWithValue("@Address", visitor.Address);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region LoadData
        public static DataSet LoadData()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter
                    ("Select * from tblVisitor",con);
                DataSet ds=new DataSet();
                da.Fill(ds, "Visitor");
                return ds;
            }
        }
        #endregion
        #region Search
        public static DataSet SearchLoadData(string name)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter
                    ("Select * from tblVisitor where Full_Name Like'"+name+"%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Visitor");
                return ds;
            }
        }
        #endregion
        #region DeleteStaff
        public static void DeleteStaff(string id)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Delete from tblVisitor " +
                                                "where Id=@Id",con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region UpdateStaff
        public static void UpdateStaff(VisitorMember visitor)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Update tblVisitor set Full_Name=@FullName,CNIC=@CNIC" +
                                                ",Contact=@Contact,Address=@Address where Id =@Id",con);
                cmd.Parameters.AddWithValue("@FullName", visitor.FullName);
                cmd.Parameters.AddWithValue("@CNIC", visitor.CNIC);
                cmd.Parameters.AddWithValue("@Contact", visitor.Mobile);
                cmd.Parameters.AddWithValue("@Address", visitor.Address);
                cmd.Parameters.AddWithValue("@Id", visitor.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
