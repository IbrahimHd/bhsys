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
    
    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            this.ReceiptItems = new HashSet<ReceiptItem>();
        }
    
        public int receiptId { get; set; }
        public int supplierId { get; set; }
        public Nullable<System.DateTime> receiptDate { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> modifiedAt { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<double> freight { get; set; }
        public Nullable<double> landingCost { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}