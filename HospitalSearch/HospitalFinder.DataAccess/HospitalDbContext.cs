using HospitalFinderEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.DataAccess
{
    class HospitalDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-VJBC22E;Database=HospitalDb;Trusted_Connection=true");
        }
        public DbSet<Hospital> Hospitals { get; set; }
    }
}
