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
    
    public partial class tb_SalesPlan
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string PYear { get; set; }
        public long DepartID { get; set; }
        public long UserID { get; set; }
        public string PJan { get; set; }
        public string PFeb { get; set; }
        public string PMar { get; set; }
        public string PApr { get; set; }
        public string PMay { get; set; }
        public string PJun { get; set; }
        public string PJul { get; set; }
        public string PAug { get; set; }
        public string PSep { get; set; }
        public string POct { get; set; }
        public string PNov { get; set; }
        public string PDec { get; set; }
        public Nullable<System.DateTime> TimeDate { get; set; }
        public string Describe { get; set; }
        public string Remarks { get; set; }
    
        public virtual tb_Departs tb_Departs { get; set; }
        public virtual tb_Users tb_Users { get; set; }
    }
}