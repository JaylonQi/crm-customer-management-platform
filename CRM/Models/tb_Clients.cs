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
    
    public partial class tb_Clients
    {
        public tb_Clients()
        {
            this.tb_ClientCallback = new HashSet<tb_ClientCallback>();
            this.tb_ClientCare = new HashSet<tb_ClientCare>();
            this.tb_ClientComplaint = new HashSet<tb_ClientComplaint>();
            this.tb_ClientContactRecord = new HashSet<tb_ClientContactRecord>();
            this.tb_ServiceRecord = new HashSet<tb_ServiceRecord>();
            this.tb_ClientSurvey = new HashSet<tb_ClientSurvey>();
            this.tb_SalesAgreement = new HashSet<tb_SalesAgreement>();
            this.tb_SalesChance = new HashSet<tb_SalesChance>();
            this.tb_SalesPrice = new HashSet<tb_SalesPrice>();
            this.tb_SalesRecord = new HashSet<tb_SalesRecord>();
        }
    
        public long ClientID { get; set; }
        public string Name { get; set; }
        public long UserID { get; set; }
        public string Sharing { get; set; }
        public string SourceType { get; set; }
        public string Importance { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public string Postalcode { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
    
        public virtual ICollection<tb_ClientCallback> tb_ClientCallback { get; set; }
        public virtual ICollection<tb_ClientCare> tb_ClientCare { get; set; }
        public virtual ICollection<tb_ClientComplaint> tb_ClientComplaint { get; set; }
        public virtual ICollection<tb_ClientContactRecord> tb_ClientContactRecord { get; set; }
        public virtual ICollection<tb_ServiceRecord> tb_ServiceRecord { get; set; }
        public virtual ICollection<tb_ClientSurvey> tb_ClientSurvey { get; set; }
        public virtual ICollection<tb_SalesAgreement> tb_SalesAgreement { get; set; }
        public virtual ICollection<tb_SalesChance> tb_SalesChance { get; set; }
        public virtual ICollection<tb_SalesPrice> tb_SalesPrice { get; set; }
        public virtual ICollection<tb_SalesRecord> tb_SalesRecord { get; set; }
        public virtual tb_Users tb_Users { get; set; }
    }
}