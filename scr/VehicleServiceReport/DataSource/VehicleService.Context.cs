﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleServiceReport.DataSource
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VehicleServiceEntities : DbContext
    {
        public VehicleServiceEntities()
            : base("name=VehicleServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VehicleServiceComplete> VehicleServiceComplete { get; set; }
    
        public virtual ObjectResult<uspVehicleServiceComplete_Result> uspVehicleServiceComplete()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspVehicleServiceComplete_Result>("uspVehicleServiceComplete");
        }
    }
}
