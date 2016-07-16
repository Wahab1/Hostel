using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Zainab
{
   public class Student
    {
       public static SqlConnection GetConnection()
       {
           string cs = ConfigurationManager.ConnectionStrings["dbZainab"].ConnectionString;
           SqlConnection con=new SqlConnection(cs);
           return con;
       }
       #region GetDegree
       public static List<string> GetDegree()
       {
           using (SqlConnection con=GetConnection())
           {
               List<string> list=new List<string>();
               SqlCommand cmd = new SqlCommand("Select Degree from tblDegree",con);
               cmd.CommandType=CommandType.Text;
               con.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   list.Add((string)dr["Degree"]);
               }
               return list;
           }
       }
       #endregion

        #region GetDepartment
       public static List<string> GetDepartment()
       {
           using (SqlConnection con = GetConnection())
           {
               List<string> list = new List<string>();
               SqlCommand cmd = new SqlCommand("Select Department from tblDepartment", con);
               cmd.CommandType = CommandType.Text;
               con.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   list.Add((string)dr["Department"]);
               }
               return list;
           }
       }
        #endregion
       #region AddStudent
       public static void AddStudent(StudentMember student)
       {
           using (SqlConnection con = GetConnection())
           {
               string query =
                   "insert into vw_tblStudentInformation values(@Student_Name,@CNCI," +
                   "@Contact_No,@Degree,@Gender,@Department," +
                   "@RollNo,@Session,@Age,@Father_Name,@Income,@Religion," +
                   "@Occupation,@Nationality,@Address,@ImageUrl)";
               SqlCommand cmd=new SqlCommand(query,con);
               cmd.CommandType=CommandType.Text;
               cmd.Parameters.AddWithValue("@Student_Name", student.FullName);
               cmd.Parameters.AddWithValue("@CNCI", student.CNIC);
               cmd.Parameters.AddWithValue("@Contact_No", student.Mobile);
               cmd.Parameters.AddWithValue("@Degree", student.Degree);
               cmd.Parameters.AddWithValue("@Gender", student.Gender);
               cmd.Parameters.AddWithValue("@Department", student.Department);
               cmd.Parameters.AddWithValue("@RollNo", student.RollNo);
               cmd.Parameters.AddWithValue("@Session", student.Sesssion);
               cmd.Parameters.AddWithValue("@Age", student.Age);
               cmd.Parameters.AddWithValue("@Father_Name", student.FatherName);
               cmd.Parameters.AddWithValue("@Income", student.Income);
               cmd.Parameters.AddWithValue("@Religion", student.Religion);
               cmd.Parameters.AddWithValue("@Occupation", student.Occupation);
               cmd.Parameters.AddWithValue("@Nationality", student.Nationality);
               cmd.Parameters.AddWithValue("@Address", student.Address);
               cmd.Parameters.AddWithValue("@ImageUrl", student.ImageUrl);
               con.Open();
               cmd.ExecuteNonQuery();
           }    
       }
        #endregion
       #region LoadData
       public static DataSet LoadData()
       {
           using (SqlConnection con = GetConnection())
           {
               SqlDataAdapter da = new SqlDataAdapter
                   ("Select * from vw_tblStudentInformationComplete",con);
               DataSet ds=new DataSet();
               da.Fill(ds, "Student");
               return ds;
           }
       }
       #endregion

       #region SearchLoadData
       public static DataSet SearchLoadData(string name)
       {
           using (SqlConnection con = GetConnection())
           {
               SqlDataAdapter da = new SqlDataAdapter
                   ("Select * from vw_tblStudentInformationComplete" +
                    " where Student_Name Like '"+name+"%'", con);
               DataSet ds = new DataSet();
               da.Fill(ds, "Student");
               return ds;
           }
       }
       #endregion
       #region DeleteStudent
       public static void DeleteStudent(int id)
       {
           using (SqlConnection con = GetConnection())
           {
               SqlCommand cmd = new SqlCommand("Delete from vw_tblStudentInformationComplete" +
                                               " where Id=@Id",con);
               cmd.Parameters.AddWithValue("@Id", id);
               con.Open();
               cmd.ExecuteNonQuery();

           }
       }
       #endregion
       #region UpdateStudent
       public static void UpdateStudent(StudentMember student)
       {
           using (SqlConnection con = GetConnection())
           {
               SqlCommand cmd = new SqlCommand("update vw_tblStudentInformationComplete set Student_Name=@Student_Name," +
                                               "CNIC=@CNIC,Contact_No#=@Contect_No#,Degree=@Degree,Department=@Department," +
                                               "RollNo#=@RollNo,Session=@Session,Age=@Age,[Father/Guardian_Name]=@Father," +
                                               "Religion=@Religion,ImageUrl=@ImageUrl,Gender=@Gender where Id=@Id",con);
               cmd.Parameters.AddWithValue("@Student_Name", student.FullName);
               cmd.Parameters.AddWithValue("@CNIC", student.CNIC);
               cmd.Parameters.AddWithValue("@Contect_No#", student.Mobile);
               cmd.Parameters.AddWithValue("@Degree", student.Degree);
               cmd.Parameters.AddWithValue("@Department", student.Department);
               cmd.Parameters.AddWithValue("@RollNo", student.RollNo);
               cmd.Parameters.AddWithValue("@Session", student.Sesssion);
               cmd.Parameters.AddWithValue("@Age", student.Age);
               cmd.Parameters.AddWithValue("@Father", student.FatherName);
               cmd.Parameters.AddWithValue("@Religion", student.Religion);
               cmd.Parameters.AddWithValue("@ImageUrl", student.ImageUrl);
               cmd.Parameters.AddWithValue("@Gender", student.Gender);
               cmd.Parameters.AddWithValue("@Id", student.StudnetId);
               con.Open();
               cmd.ExecuteNonQuery();
           }
       }
       #endregion
    }
}
