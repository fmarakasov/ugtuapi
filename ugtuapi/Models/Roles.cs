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
    
    public partial class Roles
    {
        public Roles()
        {
            this.Destination = new HashSet<Destination>();
        }
    
        public int ik_Roles { get; set; }
        public string cNameRoles { get; set; }
    
        public virtual ICollection<Destination> Destination { get; set; }
    }
}
