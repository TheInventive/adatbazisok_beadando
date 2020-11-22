using System;
using System.Collections.Generic;

namespace adatbazisok_beadando.Model
{
    public class Atutalas
    {
        public int UtalasiAzonosito { get; set; }
        public double Mennyiseg { get; set; }
        public DateTime Datum { get; set; }
        public int MegbizoAzonosito { get; set; }
        public string CelszamlaSzamlaszam { get; set; }
        public string EredetszamlaSzamlaszam { get; set; }

        public Atutalas(List<string> values)
        {
            if (values.Count != 6) return;
            UtalasiAzonosito = int.Parse(values[0]);
            Mennyiseg = double.Parse(values[1]);
            Datum = DateTime.Parse(values[2]);
            MegbizoAzonosito = int.Parse(values[3]);
            CelszamlaSzamlaszam = values[4];
            EredetszamlaSzamlaszam = values[5];
        }
    }
}
