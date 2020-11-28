using System.Collections.Generic;

namespace adatbazisok_beadando.Model
{
    public class Tulajdonos
    {
        public int UgyfelAzonosito { get; set; }
        public string Szamlaszam { get; set; }
        public double Tulajdonresz { get; set; }
        public string Nev { get; set; }

        public Tulajdonos(List<string> values)
        {
            UgyfelAzonosito = int.Parse(values[3]);
            Nev = values[0] + values[2] + values[1];
            Szamlaszam = values[4];
            Tulajdonresz = double.Parse(values[5]);
        }
    }
}
