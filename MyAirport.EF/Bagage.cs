using System;
using System.Collections.Generic;
using System.Text;

namespace ECE.AA.MyAirport.EF
{
    public class Bagage
    {
        public int ID_BAGAGE { get; set; }
        public int ID_VOL { get; set; }
        public string CODE_IATA { get; set; }
        public DateTime DATE_CREATION { get; set; }
        public char CLASSE { get; set; }
        public byte PRIORITAIRE { get; set; }
        public char STA { get; set; }
        public string SSUR { get; set; }
        public string DESTINATION { get; set; }
        public string ESCALE { get; set; }
    }
}
