//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_form
    {
        public int order_id { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public string recipient_name { get; set; }
        public string recipient_phone { get; set; }
        public string recipient_address { get; set; }
        public string payment_method { get; set; }
        public string remittance_account { get; set; }
        public string payment_status { get; set; }
        public string shipping_status { get; set; }
        public string member_account { get; set; }
    }
}
