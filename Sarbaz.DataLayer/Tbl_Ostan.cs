//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sarbaz.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Ostan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ostan()
        {
            this.Tbl_Shahrestan = new HashSet<Tbl_Shahrestan>();
        }
    
        public int OstanID { get; set; }
        public string Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Shahrestan> Tbl_Shahrestan { get; set; }
    }
}