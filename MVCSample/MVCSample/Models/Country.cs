//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCSample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.States = new HashSet<State>();
            this.Employees = new HashSet<Employee>();
        }
    
        public int CountryId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}