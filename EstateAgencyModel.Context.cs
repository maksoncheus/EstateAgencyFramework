﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EstateAgencyEntities : DbContext
    {
        public EstateAgencyEntities()
            : base("name=EstateAgencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<CommonContract> CommonContract { get; set; }
        public virtual DbSet<DealType> DealType { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Realty> Realty { get; set; }
        public virtual DbSet<RealtyCharacteristic> RealtyCharacteristic { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ServiceContract> ServiceContract { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TypeOfRealty> TypeOfRealty { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
