//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BH
{
    using System;
    using System.Collections.Generic;
    
    public partial class vSupplierSummary
    {
        public int supplierId { get; set; }
        public string supplierName { get; set; }
        public Nullable<System.DateTime> latestReceiptDate { get; set; }
        public Nullable<int> receiptsCount { get; set; }
        public Nullable<double> receiptsSum { get; set; }
    }
}
