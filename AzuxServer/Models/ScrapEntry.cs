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
    
    public partial class ScrapEntry
    {
        public int Id { get; set; }
        public int ScrapId { get; set; }
        public decimal PerUnitPrice { get; set; }
        public int Quantity { get; set; }
        public int SaleId { get; set; }
    
        public virtual Sale Sale { get; set; }
        public virtual Scrap Scrap { get; set; }
    }
}
