﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iSpanDessertShop2023JanEntities : DbContext
    {
        public iSpanDessertShop2023JanEntities()
            : base("name=iSpanDessertShop2023JanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<BlacklistedMember> BlacklistedMembers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<LoginHistory> LoginHistories { get; set; }
        public virtual DbSet<MemberAddress> MemberAddresses { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberServiceDetail> MemberServiceDetails { get; set; }
        public virtual DbSet<MemberServiceRecord> MemberServiceRecords { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductFlavor> ProductFlavors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SellerServiceDetail> SellerServiceDetails { get; set; }
        public virtual DbSet<SellerServiceRecord> SellerServiceRecords { get; set; }
        public virtual DbSet<Suspension> Suspensions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
