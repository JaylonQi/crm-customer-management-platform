//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_SalesPrice
    {
        public long ID { get; set; }
        public long ClientID { get; set; }
        public long UserID { get; set; }
        public string SaleMode { get; set; }
        public string SaleOfferTitle { get; set; }
        public string ProductClass { get; set; }
        public long ProductID { get; set; }
        public string SalePrice { get; set; }
    
        public virtual tb_Clients tb_Clients { get; set; }
        public virtual tb_Products tb_Products { get; set; }
        public virtual tb_Users tb_Users { get; set; }
    }
}
