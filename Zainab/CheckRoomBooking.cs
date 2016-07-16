using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Zainab
{
    class CheckRoomBooking
    {
        public static List<CheckRoomMember> GetRoom()
        {
            using (SqlConnection con = Student.GetConnection())
            {
                var chkRoom=new List<CheckRoomMember>();
                var com = new SqlCommand("spGetCheck", con);
                com.CommandType=CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    var c=new CheckRoomMember()
                        {
                            RoomNo = dr["Room"].ToString(),
                            Capacity = dr["Capacity"].ToString()
                        };
                    chkRoom.Add(c);
                }
                return chkRoom;
            }
            
        }
    }
}
