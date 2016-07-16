using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Zainab
{
    public class FeeSubmission
    {
        #region GetStudent
        public static List<string> GetStudent(string degree, string department)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string> student = new List<string>();
                SqlCommand cmd = new SqlCommand("Select Full_Name from vwtblFeeSubmissionGetStudent" +
                                                " where Degree=@Degree And Department=@Department",con);
                cmd.Parameters.AddWithValue("@Degree", degree);
                cmd.Parameters.AddWithValue("@Department", department);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    student.Add((string)dr["Full_Name"]);
                }
                return student;
            }
        }
        #endregion
        #region GetRoom
        public static string GetStudentRoom(string degree, string department,string name)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                string room = null;
                SqlCommand cmd = new SqlCommand("Select RoomNo# from vwtblFeeSubmissionGetStudent" +
                                                " where Degree=@Degree And Department=@Department" +
                                                " And Full_Name=@name", con);
                cmd.Parameters.AddWithValue("@Degree", degree);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    room = (string)dr["RoomNo#"];
                }
                return room;
            }
        }
        #endregion
        #region FeeSubmit
        public static void FeeSubmissionStudent( string name,string room,string month,string year)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into vwFeeSubmission values" +
                                                "(@Full_Name,@RoomNo#,@Month,@Year)", con);
                cmd.Parameters.AddWithValue("@Full_Name", name);
                cmd.Parameters.AddWithValue("@RoomNo#", room);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
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
                SqlDataAdapter da = new SqlDataAdapter
                    ("Select * from vwFeeSubmisstionComplete",con);
                DataSet ds=new DataSet();
                da.Fill(ds, "Fee");
                return ds;

            }
        }
        #endregion
        #region DataLoadSearch
        public static DataSet DataLoadSearch(string month,string year)
        {
            int y = 0;
            bool conversionYear = int.TryParse(year, out y);
            if (conversionYear)
            {
                using (SqlConnection con = Student.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter
                        ("Select * from vwFeeSubmisstionComplete " +
                         "where Month=@Month And Year=@Year", con);
                    da.SelectCommand.Parameters.AddWithValue("@Month", month);
                    da.SelectCommand.Parameters.AddWithValue("@Year", year);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Fee");
                    return ds;

                }
            }
            else
            {
                using (SqlConnection con = Student.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter
                        ("Select * from vwFeeSubmisstionComplete", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Fee");
                    return ds;

                }
            }
        }
        #endregion
        
    }
}
