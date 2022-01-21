using System;
using FinalLiftOff.Models;
using Microsoft.EntityFrameworkCore;

namespace KristaLO.Data
{
    public class NourishDbContext
    {
        public DbSet<Meals> Meals { get; set; }

        public NourishDbContext()
        {
        }
    }
}
