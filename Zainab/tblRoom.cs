//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zainab
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRoom
    {
        public tblRoom()
        {
            this.tblBookingRooms = new HashSet<tblBookingRoom>();
            this.tblFeeSubmissions = new HashSet<tblFeeSubmission>();
        }
    
        public int Id { get; set; }
        public string RoomNo_ { get; set; }
        public Nullable<int> RoomTypeId { get; set; }
        public string Room_Description { get; set; }
        public string Room_Capacity { get; set; }
    
        public virtual ICollection<tblBookingRoom> tblBookingRooms { get; set; }
        public virtual ICollection<tblFeeSubmission> tblFeeSubmissions { get; set; }
        public virtual tblRoomType tblRoomType { get; set; }
    }
}
