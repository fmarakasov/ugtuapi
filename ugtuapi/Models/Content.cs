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
    
    public partial class Content
    {
        public int ik_upContent { get; set; }
        public byte n_sem { get; set; }
        public int ik_vid_zanyat { get; set; }
        public Nullable<int> i_hour_per_week { get; set; }
        public int ik_disc_uch_plan { get; set; }
        public Nullable<int> ik_kaf { get; set; }
        public Nullable<byte> n_module { get; set; }
        public Nullable<int> i_balls { get; set; }
        public Nullable<int> ik_act_off { get; set; }
        public Nullable<int> i_hours_per_sem { get; set; }
    
        public virtual CurriculaDisciplines sv_disc { get; set; }
        public virtual TutorialClass vid_zaniat { get; set; }
    }
}
