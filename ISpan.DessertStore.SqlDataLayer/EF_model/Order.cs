//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISpan.DessertStore.SqlDataLayer.EF_model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ID { get; set; }
        public int MemberID { get; set; }
        public int SellerID { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string ShipZIP { get; set; }
        public string ShipAddress { get; set; }
        public string InvoiceZIP { get; set; }
        public string InvoiceAddress { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public decimal ShippingFee { get; set; }
        public string ShipVia { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
    
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Order Orders1 { get; set; }
        public virtual Order Order1 { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
