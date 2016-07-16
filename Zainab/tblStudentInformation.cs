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
    
    public partial class tblStudentInformation
    {
        public tblStudentInformation()
        {
            this.tblBookingRooms = new HashSet<tblBookingRoom>();
            this.tblMessRecords = new HashSet<tblMessRecord>();
            this.tblFeeSubmissions = new HashSet<tblFeeSubmission>();
        }
    
        public int Id { get; set; }
        public string Full_Name { get; set; }
        public string CNIC { get; set; }
        public string Contact_No_ { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> DegreeId { get; set; }
        public string RollNo_ { get; set; }
        public string Session { get; set; }
        public Nullable<int> Age { get; set; }
        public string Father_Guardian_Name { get; set; }
        public string Occupation { get; set; }
        public Nullable<int> Income { get; set; }
        public string Address { get; set; }
        public Nullable<int> ReligionId { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string Nationality { get; set; }
        public string ImageUrl { get; set; }
    
        public virtual ICollection<tblBookingRoom> tblBookingRooms { get; set; }
        public virtual ICollection<tblMessRecord> tblMessRecords { get; set; }
        public virtual ICollection<tblFeeSubmission> tblFeeSubmissions { get; set; }
    }
}
