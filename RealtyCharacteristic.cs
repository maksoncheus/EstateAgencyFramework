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
    
    public partial class RealtyCharacteristic
    {
        public int RealtyCharacteristicID { get; set; }
        public Nullable<int> Realty { get; set; }
        public Nullable<int> Property { get; set; }
    
        public virtual Property Property1 { get; set; }
        public virtual Realty Realty1 { get; set; }
    }
}
