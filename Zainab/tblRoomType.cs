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
    
    public partial class tblRoomType
    {
        public tblRoomType()
        {
            this.tblRooms = new HashSet<tblRoom>();
        }
    
        public int Id { get; set; }
        public string Room_Type { get; set; }
        public Nullable<int> Room_Rent { get; set; }
    
        public virtual ICollection<tblRoom> tblRooms { get; set; }
    }
}