using LabWebApi.contracts.Data.Entities;
using LabWevAPI.Database.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWevAPI.Database.Data
{
    public class LabWebApiDbContext : DbContext
    {
        public LabWebApiDbContext(DbContextOptions<LabWebApiDbContext> options) :
        base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public DbSet<User> Users { get; set; }
    }
}
