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
    
    public partial class BlacklistedMember
    {
        public int ID { get; set; }
        public int ItemNo { get; set; }
        public int SellerID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public string MemberAccount { get; set; }
        public string Status { get; set; }
    }
}
