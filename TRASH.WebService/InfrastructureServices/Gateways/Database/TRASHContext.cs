using Microsoft.EntityFrameworkCore;
using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TRASH.ApplicationServices.Synchronization;
using TRASH.InfrastructureServices.Gateways.Database;


namespace TRASH.InfrastructureServices.Gateways.Database
{
    public class TRASHContext : DbContext
    {
        public DbSet<trash> TRASHs { get; set; }

        public TRASHContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var v = new UseCaseTRASH();

            modelBuilder.Entity<trash>().HasData(v.trashs);
                
                
               
            
        }
    }
}
