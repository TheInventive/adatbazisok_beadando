using System;
using System.Collections.Generic;

namespace adatbazisok_beadando.Model
{
    public class Szamla
    {
        public string Szamlaszam { get; set; }
        public string Valuta { get; set; }
        public double Penz { get; set; }
        public DateTime SzerzodesDatuma { get; set; }

        public Szamla(List<string> values)
        {
            if (values.Count != 4) return;
            Szamlaszam = values[0];
            Valuta = values[1];
            Penz = double.Parse(values[2]);
            SzerzodesDatuma = DateTime.Parse(values[3]);
        }
    }
}
