using System;

namespace adatbazisok_beadando.Model
{
    public class Atutalas
    {
        public int UtalasiAzonosito { get; set; }
        public double Mennyiseg { get; set; }
        public string Valuta { get; set; }
        public DateTime Datum { get; set; }
        public int MegbizoAzonosito { get; set; }
        public string CelszamlaSzamlaszam { get; set; }
        public string EredetszamlaSzamlaszam { get; set; }

        public Atutalas(string[] values)
        {
            if (values.Length != 7) return;
            UtalasiAzonosito = int.Parse(values[0]);
            Mennyiseg = double.Parse(values[1]);
            Datum = DateTime.Parse(values[2]);
            MegbizoAzonosito = int.Parse(values[3]);
            EredetszamlaSzamlaszam = values[4];
            Valuta = values[6];
            CelszamlaSzamlaszam = values[5];
        }
    }
}
