//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace student_management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public registration()
        {
            this.teachers = new HashSet<teacher>();
        }
    
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nic { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<int> batch_id { get; set; }
        public Nullable<int> telno { get; set; }
    
        public virtual branch branch { get; set; }
        public virtual course course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<teacher> teachers { get; set; }
    }
}
