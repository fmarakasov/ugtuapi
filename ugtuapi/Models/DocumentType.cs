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
    
    public partial class DocumentType
    {
        public DocumentType()
        {
            this.Documents = new HashSet<Document>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsEducational { get; set; }
        public Nullable<int> ik_subFB { get; set; }
        public Nullable<int> ik_type_grazd { get; set; }
    
        public virtual ICollection<Document> Documents { get; set; }
    }
}
