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
    
    public partial class Discipline
    {
        public Discipline()
        {
            this.sv_disc = new HashSet<CurriculaDisciplines>();
        }
    
        public int iK_disc { get; set; }
        public string cName_disc { get; set; }
        public string cShortName { get; set; }
        public bool lPract { get; set; }
        public Nullable<byte> ik_type_disc { get; set; }
        public string DiplDiscName { get; set; }
    
        public virtual DisciplineType Type_disc { get; set; }
        public virtual ICollection<CurriculaDisciplines> sv_disc { get; set; }
    }
}
