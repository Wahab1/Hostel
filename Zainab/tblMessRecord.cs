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
    
    public partial class tblMessRecord
    {
        public int Id { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> MessId { get; set; }
    
        public virtual tblStudentInformation tblStudentInformation { get; set; }
        public virtual tblMess tblMess { get; set; }
    }
}