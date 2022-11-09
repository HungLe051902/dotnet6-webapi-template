using BookingService.InfrastructureLayer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookingService.DataAccessLayer
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ModelTest>().
            modelBuilder.Entity<ModelTest>()
                .Property(b => b.Code)
                .IsRequired();
        }

        public IDbConnection Connection => throw new NotImplementedException();

        public DbSet<ModelTest> ModelTests { get; set; } = default!;
    }
}
