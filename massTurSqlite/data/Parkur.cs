//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace massTurSqlite.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parkur
    {
        public long id { get; set; }
        public string sehir { get; set; }
        public string ulasim { get; set; }
        public Nullable<int> sira { get; set; }
        public Nullable<bool> konaklama { get; set; }
        public Nullable<long> TurID { get; set; }
    
        public virtual Tur Tur { get; set; }
    }
}