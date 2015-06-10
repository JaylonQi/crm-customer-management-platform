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
    
    public partial class tb_Products
    {
        public tb_Products()
        {
            this.tb_ClientCallback = new HashSet<tb_ClientCallback>();
            this.tb_ClientComplaint = new HashSet<tb_ClientComplaint>();
            this.tb_ClientSurvey = new HashSet<tb_ClientSurvey>();
            this.tb_Demands = new HashSet<tb_Demands>();
            this.tb_SalesPrice = new HashSet<tb_SalesPrice>();
            this.tb_SalesRecord = new HashSet<tb_SalesRecord>();
            this.tb_SalesChance = new HashSet<tb_SalesChance>();
            this.tb_SalesAgreement = new HashSet<tb_SalesAgreement>();
        }
    
        public long ProductID { get; set; }
        public long SupplierID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Spec { get; set; }
        public string ConstPrice { get; set; }
        public string SalePrice { get; set; }
        public string Describe { get; set; }
        public string Remarks { get; set; }
    
        public virtual ICollection<tb_ClientCallback> tb_ClientCallback { get; set; }
        public virtual ICollection<tb_ClientComplaint> tb_ClientComplaint { get; set; }
        public virtual ICollection<tb_ClientSurvey> tb_ClientSurvey { get; set; }
        public virtual ICollection<tb_Demands> tb_Demands { get; set; }
        public virtual ICollection<tb_SalesPrice> tb_SalesPrice { get; set; }
        public virtual ICollection<tb_SalesRecord> tb_SalesRecord { get; set; }
        public virtual ICollection<tb_SalesChance> tb_SalesChance { get; set; }
        public virtual ICollection<tb_SalesAgreement> tb_SalesAgreement { get; set; }
        public virtual tb_Suppliers tb_Suppliers { get; set; }
    }
}
