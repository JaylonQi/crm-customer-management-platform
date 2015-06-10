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
    
    public partial class tb_Users
    {
        public tb_Users()
        {
            this.tb_ClientCallback = new HashSet<tb_ClientCallback>();
            this.tb_ClientCare = new HashSet<tb_ClientCare>();
            this.tb_ClientComplaint = new HashSet<tb_ClientComplaint>();
            this.tb_ClientContactRecord = new HashSet<tb_ClientContactRecord>();
            this.tb_Clients = new HashSet<tb_Clients>();
            this.tb_ClientSurvey = new HashSet<tb_ClientSurvey>();
            this.tb_Demands = new HashSet<tb_Demands>();
            this.tb_Log = new HashSet<tb_Log>();
            this.tb_SalesAgreement = new HashSet<tb_SalesAgreement>();
            this.tb_SalesChance = new HashSet<tb_SalesChance>();
            this.tb_SalesPlan = new HashSet<tb_SalesPlan>();
            this.tb_SalesPrice = new HashSet<tb_SalesPrice>();
            this.tb_SalesRecord = new HashSet<tb_SalesRecord>();
            this.tb_ServiceRecord = new HashSet<tb_ServiceRecord>();
        }
    
        public long UserID { get; set; }
        public string Name { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }
        public string WorkNum { get; set; }
        public long DepartID { get; set; }
        public long DutyID { get; set; }
        public bool IfLogin { get; set; }
        public System.DateTime CreateTimeDate { get; set; }
        public string Remark { get; set; }
        public string Picture { get; set; }
        public string Telephone { get; set; }
        public string Contacts { get; set; }
        public string ContactTel { get; set; }
        public string Adress { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Nationality { get; set; }
        public string Marriage { get; set; }
        public string Politics { get; set; }
        public string NativePlace { get; set; }
        public string Education { get; set; }
        public string Graduate { get; set; }
        public string Speciality { get; set; }
        public string Experience { get; set; }
        public string Train { get; set; }
        public string Rewards { get; set; }
        public string Other { get; set; }
        public Nullable<long> UserTypeID { get; set; }
        public string IdNumber { get; set; }
        public Nullable<System.DateTime> Worktime { get; set; }
        public Nullable<System.DateTime> Companytime { get; set; }
    
        public virtual ICollection<tb_ClientCallback> tb_ClientCallback { get; set; }
        public virtual ICollection<tb_ClientCare> tb_ClientCare { get; set; }
        public virtual ICollection<tb_ClientComplaint> tb_ClientComplaint { get; set; }
        public virtual ICollection<tb_ClientContactRecord> tb_ClientContactRecord { get; set; }
        public virtual ICollection<tb_Clients> tb_Clients { get; set; }
        public virtual ICollection<tb_ClientSurvey> tb_ClientSurvey { get; set; }
        public virtual ICollection<tb_Demands> tb_Demands { get; set; }
        public virtual tb_Departs tb_Departs { get; set; }
        public virtual tb_Duties tb_Duties { get; set; }
        public virtual ICollection<tb_Log> tb_Log { get; set; }
        public virtual ICollection<tb_SalesAgreement> tb_SalesAgreement { get; set; }
        public virtual ICollection<tb_SalesChance> tb_SalesChance { get; set; }
        public virtual ICollection<tb_SalesPlan> tb_SalesPlan { get; set; }
        public virtual ICollection<tb_SalesPrice> tb_SalesPrice { get; set; }
        public virtual ICollection<tb_SalesRecord> tb_SalesRecord { get; set; }
        public virtual ICollection<tb_ServiceRecord> tb_ServiceRecord { get; set; }
        public virtual tb_UserType tb_UserType { get; set; }
    }
}
