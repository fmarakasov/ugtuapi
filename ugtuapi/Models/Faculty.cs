//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ugtuapi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty
    {
        public Faculty()
        {
            this.FacultyRel = new HashSet<FacultyRel>();
        }
    
        public int Id { get; set; }
        public string DiplExcPatternName { get; set; }
        public string DiplVklExcPatternName { get; set; }
        public Nullable<bool> DiplVklDatPadez { get; set; }
        public Nullable<System.Guid> DepartmentUID { get; set; }
    
        public virtual ICollection<FacultyRel> FacultyRel { get; set; }
        public virtual Department Department { get; set; }
    }
}
