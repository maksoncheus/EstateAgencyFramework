using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Authorization> Authorization { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<TypeOfRealty> TypeOfRealty { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ServiceContract> ServiceContract { get; set; }
        public DbSet<RealtyCharacteristic> RealtyCharacteristic { get; set; }
        public DbSet<Realty> Realty { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<DealType> DealType { get; set; }
        public DbSet<CommonContract> CommonContract { get; set; }
        public ApplicationContext() : base("name=EstateAgencyEntities")
        {
            User.Load();
            Authorization.Load();
            Role.Load();
            TypeOfRealty.Load();
            Status.Load();
            ServiceContract.Load();
            RealtyCharacteristic.Load();
            Realty.Load();
            Property.Load();
            DealType.Load();
            CommonContract.Load();
        }
    }
}
