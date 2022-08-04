using System;
using Entity.Configuration;
using Entity.Core;
using Entity.Core.authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Entity.Context
{
    public class AppEducationDbContext : IdentityDbContext<userIdentity,roleIdentity,int>
    {
        public AppEducationDbContext(DbContextOptions<AppEducationDbContext> options):base(options)
        {
            
        }
    protected  override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }

        public DbSet<Category> Categories { get; set; }
    }
}