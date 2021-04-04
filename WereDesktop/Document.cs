//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WereDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.DocumentRow = new HashSet<DocumentRow>();
            this.DocumentPayment = new HashSet<DocumentPayment>();
        }
    
        public string ID { get; set; }
        public string SourceID { get; set; }
        public string DestinationID { get; set; }
        public int DocumentNumber { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Contragent Contragent { get; set; }
        public virtual Contragent Contragent1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentRow> DocumentRow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentPayment> DocumentPayment { get; set; }
    }
}