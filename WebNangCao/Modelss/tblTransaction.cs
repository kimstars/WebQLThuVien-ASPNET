//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNangCao.Modelss
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransaction
    {
        public int TranId { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookTitle { get; set; }
        public string TranStatus { get; set; }
        public string TranDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
    }
}
