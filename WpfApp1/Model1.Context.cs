﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ConnectedService> ConnectedService { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<CRM> CRM { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentType> EquipmentType { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<InstallationEquipment> InstallationEquipment { get; set; }
        public virtual DbSet<ProblemType> ProblemType { get; set; }
        public virtual DbSet<ReasonForTermination> ReasonForTermination { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<StatusServices> StatusServices { get; set; }
        public virtual DbSet<Subscriber> Subscriber { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfService> TypeOfService { get; set; }
        public virtual DbSet<TypeService> TypeService { get; set; }
    }
}
