//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.ORM.Databaseclass
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orderdetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProcutID { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Products Products { get; set; }
    }
}
