﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UGTUEntities : DbContext
    {
        public UGTUEntities()
            : base("name=UGTUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Zach> Zach { get; set; }
        public virtual DbSet<Group> Grup { get; set; }
        public virtual DbSet<StudGrup> StudGrup { get; set; }
        public virtual DbSet<FacultyRel> Relation_spec_fac { get; set; }
        public virtual DbSet<Curricula> Uch_pl { get; set; }
        public virtual DbSet<EducationBranch> EducationBranch { get; set; }
        public virtual DbSet<StudentInfo> StudInfo { get; set; }
        public virtual DbSet<Department> DepartmentMainData { get; set; }
        public virtual DbSet<Employee> KafTeachers { get; set; }
        public virtual DbSet<Faculty> Fac { get; set; }
        public virtual DbSet<Document> Doc_stud { get; set; }
        public virtual DbSet<DocumentType> documents { get; set; }
        public virtual DbSet<Reason> Pricina { get; set; }
        public virtual DbSet<ReasonType> TypePricina { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Campus> Campus { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<PersonDocument> PersonDocumentSet { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<Content> Content_UchPl { get; set; }
        public virtual DbSet<Discipline> discpln { get; set; }
        public virtual DbSet<CurriculaDisciplines> sv_disc { get; set; }
        public virtual DbSet<TutorialTypeClass> typ_zan { get; set; }
        public virtual DbSet<BrunchType> Type_branch { get; set; }
        public virtual DbSet<DisciplineType> Type_disc { get; set; }
        public virtual DbSet<TutorialType> TutorialType { get; set; }
        public virtual DbSet<TutorialClass> vid_zaniat { get; set; }
        public virtual DbSet<CurriculaYear> Year_uch_pl { get; set; }
        public virtual DbSet<DisciplineCycle> ckl_disc { get; set; }
        public virtual DbSet<EducationForm> Form_ed { get; set; }
        public virtual DbSet<DisciplineGroup> grp_disc { get; set; }
        public virtual DbSet<TypeSupply> TypeSupply { get; set; }
    }
}
