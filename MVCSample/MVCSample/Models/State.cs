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
    
    public partial class State
    {
        public State()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int StateId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
