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
    
    public partial class Tur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tur()
        {
            this.Tur_Musteri = new HashSet<Tur_Musteri>();
            this.Parkur = new HashSet<Parkur>();
        }
    
        public long id { get; set; }
        public string ad { get; set; }
        public Nullable<long> tipID { get; set; }
        public string kod { get; set; }
        public Nullable<int> kapasite { get; set; }
        public Nullable<long> sezonID { get; set; }
        public Nullable<System.DateTime> basTarih { get; set; }
        public Nullable<System.DateTime> bitTarih { get; set; }
        public string durum { get; set; }
        public string ulke { get; set; }
        public string sehir { get; set; }
        public Nullable<long> donemID { get; set; }
        public string aciklama { get; set; }
        public Nullable<int> kesinKayitLimit { get; set; }
        public Nullable<bool> aktif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tur_Musteri> Tur_Musteri { get; set; }
        public virtual Donem Donem { get; set; }
        public virtual Sezon Sezon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parkur> Parkur { get; set; }
    }
}
