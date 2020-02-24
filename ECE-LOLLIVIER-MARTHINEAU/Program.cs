using ECE.AA.MyAirport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Linq;

namespace ECE.AA.MyAirport.App
{
    class Program
    {

        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); });
        static void Main(string[] args)
        {



            var optionsBuilder = new DbContextOptionsBuilder<AirportContext>();
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AirportDB"].ConnectionString);

            using (var db = new AirportContext(optionsBuilder.Options))
            {

                //CREATE
                var vol = new Vol { 
                    CIE = "test",
                    LIG = "AZERTY"
                };
                db.Vols.Add(vol);
                db.SaveChanges();

                var baggage = new Bagage
                {
                    ID_VOL = 1,
                    CODE_IATA = "AZERTY"
                };
                db.Bagages.Add(baggage);
                db.SaveChanges();

                // Read
                var bag = db.Bagages
                    .First();

                // Update
                bag.CODE_IATA = "TREZA";
                bag.SSUR = "AZE";
                db.SaveChanges();

                // Delete
                db.Remove(bag);
                db.SaveChanges();



            }
            Console.WriteLine("Hello World!");
        }
    }
}
