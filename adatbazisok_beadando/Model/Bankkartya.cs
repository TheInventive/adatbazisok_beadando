using System;
using System.Collections.Generic;

namespace adatbazisok_beadando.Model
{
    public class Bankkartya
    {
        public string BankkartyaSzam { get; set; }
        public DateTime Lejarat { get; set; }
        public string MegerositoCod { get; set; }
        public string Tipus { get; set; }
        public double Limit { get; set; }
        public string Szamlaszam { get; set; }

        public Bankkartya(List<string> values)
        {
            if (values.Count != 6) return;
            BankkartyaSzam = values[0];
            Lejarat = DateTime.Parse(values[1]);
            MegerositoCod = values[2];
            Tipus = values[3];
            Limit = double.Parse(values[4]);
            Szamlaszam = values[5];
        }
    }
}
