//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzuxServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Scrap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Scrap()
        {
            this.ScrapEntry = new HashSet<ScrapEntry>();
        }
    
        public int Id { get; set; }
        public string ScrapName { get; set; }
        public decimal DefaultPrice { get; set; }
        public int CategoryId { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScrapEntry> ScrapEntry { get; set; }
    }
}
