
using System;

using KristaLO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KristaLO.Data
{
    public class NourishDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Meals> Meal { get; set; }

        public NourishDbContext(DbContextOptions<NourishDbContext> options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }
}

