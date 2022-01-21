using System;
using FinalLiftOff.Models;
using Microsoft.EntityFrameworkCore;

namespace KristaLO.Data
{
    public class NourishDbContext : DbContext
    {
        public DbSet<Meals> Meals { get; set; }

        public NourishDbContext(DbContextOptions<NourishDbContext> options)
            :base(options)
        {
        }
    }
}
