//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CricketDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cricketer
    {
        public Cricketer()
        {
            this.Cricketer_Details = new HashSet<Cricketer_Details>();
            this.Cricketer_ODI_Statistics = new HashSet<Cricketer_ODI_Statistics>();
            this.Cricketer_Test_Statistics = new HashSet<Cricketer_Test_Statistics>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ODI { get; set; }
        public Nullable<int> Test { get; set; }
    
        public virtual ICollection<Cricketer_Details> Cricketer_Details { get; set; }
        public virtual ICollection<Cricketer_ODI_Statistics> Cricketer_ODI_Statistics { get; set; }
        public virtual ICollection<Cricketer_Test_Statistics> Cricketer_Test_Statistics { get; set; }
    }
}
