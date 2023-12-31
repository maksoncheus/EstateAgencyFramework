//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstateAgencyFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Realty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Realty()
        {
            this.CommonContract = new HashSet<CommonContract>();
            this.RealtyCharacteristic = new HashSet<RealtyCharacteristic>();
        }
    
        public int RealtyID { get; set; }
        public string House { get; set; }
        public Nullable<int> Flat { get; set; }
        public string Disctrict { get; set; }
        public string Street { get; set; }
        public Nullable<int> Rooms { get; set; }
        public int LivingArea { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public Nullable<int> Floors { get; set; }
        public bool Balcony { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> RealtyType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommonContract> CommonContract { get; set; }
        public virtual TypeOfRealty TypeOfRealty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RealtyCharacteristic> RealtyCharacteristic { get; set; }
    }
}
