using ECE.AA.MyAirport.EF;
using System;
using System.Linq;

namespace ECE.AA.MyAirport.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AirportContext())
            {

                //CREATE
                var vol = new Vol { 
                    CIE = 1,
                    LIG = "AZERTY",
                    JEX = 1
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
