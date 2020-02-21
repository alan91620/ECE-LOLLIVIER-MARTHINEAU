using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ECE.AA.MyAirport.EF
{
    public class AirportContext : DbContext
    {
        public DbSet<Vol> Vols { get; set; }
        public DbSet<Bagage> Bagages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Airport;Integrated Security=True");
        }
    }
}
