using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class CompanyContext: DbContext  //proxy - uchwyt do bazy danych
    {
        public CompanyContext(DbContextOptions<CompanyContext> o): base(o) {

        }

        public DbSet<CountryRegion> CountryRegions { get; set; }    //klasa encji -> zmapwaną na entiti set countryRegions

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryRegion>().HasKey(c => c.CountryRegionCode);

            modelBuilder.Entity<CountryRegion>().ToTable("CountryRegion", "Person");
        }
    }
}
