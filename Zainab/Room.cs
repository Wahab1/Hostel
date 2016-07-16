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
    public class Room
    {
        #region GetRoomNumber
        public static int GetRoomNumber()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                int roomNo = 1;
                SqlCommand cmd = new SqlCommand("Select count(id) from tblRoom",con);
                cmd.CommandType=CommandType.Text;
                con.Open();
                roomNo +=(int)cmd.ExecuteScalar();
                return roomNo;
            }
        }
        #endregion
        #region GetRoomType
        public static List<string> GetRoomType()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                List<string>list=new List<string>();
                SqlCommand cmd = new SqlCommand("Select Room_Type from tblRoomType",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["Room_Type"]);
                }
                return list;
            }
        }
        #endregion
        #region RoomRent
        public static int RoomRent(string roomType)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                int roomRent = 0;
                SqlCommand cmd = new SqlCommand("Select Room_Rent from tblRoomType" +
                                                " where Room_Type=@Room_Type",con);
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@Room_Type", roomType);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    roomRent =(int)dr["Room_Rent"];
                }
                return roomRent;
            }
        }
        #endregion
        #region AddRoom
        public static void AddRoom(RoomMember room)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into vwtblRoom values" +
                                                "(@RoomNo,@Room_Type,@RoomCapacity,@RoomDescription)",con);
                cmd.Parameters.AddWithValue("@RoomNo", room.RoomNo);
                cmd.Parameters.AddWithValue("@Room_Type", room.RoomType);
                cmd.Parameters.AddWithValue("@RoomCapacity", room.RoomCapacity);
                cmd.Parameters.AddWithValue("@RoomDescription", room.RoomDescription);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        public static DataSet DataLoad()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from vwtblRoomComplete",con);
                DataSet ds=new DataSet();
                da.Fill(ds, "Room");
                return ds;
            }
        }

    }
}
 