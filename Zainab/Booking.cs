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
    public class Booking
    {
        #region GetDegree
        public static List<string> GetDegree()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string> list=new List<string>();
                SqlCommand cmd = new SqlCommand("Select Degree from tblDegree",con);
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
        #region Department
        public static List<string> GetDepartment()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string> list = new List<string>();
                SqlCommand cmd = new SqlCommand("Select Department from tblDepartment", con);
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
        #region GetStudent
        public static List<string> GetStudent(string department,string degree)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string> list = new List<string>();
                SqlCommand cmd = new SqlCommand("Select Full_Name from vwGetStudentUnBookingRoom" +
                                                " where Department=@Department And Degree=@Degree", con);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Degree", degree);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["Full_Name"]);
                }
                return list;
            }
        }
        #endregion
        #region UpdateRoomStudent
        public static List<string> GetUpdateStudent(string department, string degree)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string> list = new List<string>();
                SqlCommand cmd = new SqlCommand("Select *  from vwGetStudentBookingRoom" +
                                                " where Department=@Department And Degree=@Degree", con);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Degree", degree);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["Full_Name"]);
                }
                return list;
            }
        }
        #endregion
        #region GetRoomNumber
        public static List<string> GetRoomNumber()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string> list = new List<string>();
                SqlCommand cmd = new SqlCommand("Select RoomNo# from tblRoom", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["RoomNo#"]);
                }
                return list;
            }
        }
        #endregion
        #region RoomCapacity
        public static int RoomCapactiy(string roomNo)
        {
            int capacity = 0;
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd=new SqlCommand("Select count(RoomNo#) from vwFindRoomCapacity " +
                                              "where RoomNo#=@Room",con);
                cmd.Parameters.AddWithValue("@Room", roomNo);
                con.Open();
               capacity=4-(int)cmd.ExecuteScalar();
            }
            return capacity;
        }
        #endregion
        #region RoomRent
        public static int RoomRent(string roomNo)
        {
            int rent = 0;
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Room_Rent from vwFindRoomRent" +
                                                " where RoomNo#=@RoomNo", con);
                cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    rent = (int) dr["Room_Rent"];
                }
            }
            return rent;
        }
        #endregion
        #region BookRoom
        public static void BookRoom(BookingMember booking)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into vwBookingRoom " +
                                                "values(@StudentName,@RoomNo)",con);
                cmd.Parameters.AddWithValue("@StudentName", booking.StudentName);
                cmd.Parameters.AddWithValue("@RoomNo", booking.RoomNo);
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
                    ("Select * from vwBookingRoomComplete",con);
                DataSet ds=new DataSet();
                da.Fill(ds, "Booking");
                return ds;
            }
        }
        #endregion
        #region GetStudentRoomNo
        public static string GetStudentRoomNo(string name)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                string room=null;
                SqlCommand cmd = new SqlCommand("Select RoomNo#  from vwGetStudentBookingRoom " +
                                                "where Full_Name=@Name", con);
                cmd.Parameters.AddWithValue("@Name", name);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    room=(string)dr["RoomNo#"];
                }
                return room;
            }
        }
        #endregion
        #region UpdateStudentId
        public static int UpdateStudentId(string name)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                int Id = 0;
                SqlCommand cmd = new SqlCommand("Select Id from vwGetStudentBookingRoom " +
                                                "where Full_Name=@Name", con);
                cmd.Parameters.AddWithValue("@Name", name);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = (int)dr["Id"];
                }
                return Id;
            }
        }
        #endregion
        #region UpdateRoom
        public static void UpdateStudentRoom(string Room,string id)
        {
            using (SqlConnection con=Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Update vwGetStudentBookingRoom " +
                                                "set RoomNo#=@Room " +
                                                "where Id=@Id",con);
                cmd.Parameters.AddWithValue("@Room", Room);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region LoadDataSearch
        public static DataSet LoadDataSearch(string room)
        {
            if (room != "")
            {
                using (SqlConnection con = Student.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter
                        ("Select * from vwBookingRoomComplete" +
                         " where RoomNo#=@Room", con);
                    da.SelectCommand.Parameters.AddWithValue("@Room", room);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Booking");
                    return ds;
                }
            }
            else
            {
                DataSet ds = Booking.LoadData();
                return ds;
            }
        }
        #endregion
    }
}
