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
    
    public partial class Document
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Issued { get; set; }
        public string Authority { get; set; }
        public int DocTypeId { get; set; }
        public string Number { get; set; }
        public string Series { get; set; }
        public decimal nCode { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
        public virtual Person Person { get; set; }
    }
}