//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ximoShopping_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brand
    {
        public int BrandID { get; set; }
        public string brand1 { get; set; }
        public string brandTW { get; set; }
        public string BrandDesc { get; set; }
        public string BrandURL { get; set; }
        public string activity { get; set; }
        public string logoimg { get; set; }
        public string logoimgC { get; set; }
        public string brandStoryIMG { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public string created_by { get; set; }
        public string created_ip { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public string modified_by { get; set; }
        public string modified_ip { get; set; }
        public string visible { get; set; }
        public Nullable<System.DateTime> ContractEffectiveDate { get; set; }
        public Nullable<System.DateTime> ContractExpirationDate { get; set; }
    }
}
