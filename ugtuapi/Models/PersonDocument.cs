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
    
    public partial class PersonDocument
    {
        public PersonDocument()
        {
            this.Document11 = new HashSet<PersonDocument>();
            this.Document2 = new HashSet<PersonDocument>();
        }
    
        public int Ik_Document { get; set; }
        public int Ik_Transfer { get; set; }
        public int Ik_destination { get; set; }
        public int Ik_studGrup { get; set; }
        public string Num_podrazd { get; set; }
        public Nullable<int> NumberDoc { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DateReady { get; set; }
        public System.DateTime DatePod { get; set; }
        public Nullable<int> Ik_reason_issuing { get; set; }
    
        public virtual Destination Destination { get; set; }
        public virtual StudGrup StudGrup { get; set; }
        public virtual ICollection<PersonDocument> Document11 { get; set; }
        public virtual ICollection<PersonDocument> Document2 { get; set; }
    }
}
