﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MvcDemoEntities : DbContext
    {
        public MvcDemoEntities()
            : base("name=MvcDemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<EmpDetail> EmpDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmpQualification> EmpQualifications { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<ProfilePic> ProfilePics { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
    
        public virtual ObjectResult<GetCountrys_Result> GetCountrys()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCountrys_Result>("GetCountrys");
        }
    }
}
