using System.Collections.Generic;

namespace adatbazisok_beadando.Model
{
    public class Meghatalmazas
    {
        public string Szamlaszam { get; set; }
        public int UgyfelId { get; set; }
        public string Nev { get; set; }

        public Meghatalmazas(List<string> values)
        {

            UgyfelId = int.Parse(values[3]);
            Nev = values[0]+" " + values[2] + values[1];
            Szamlaszam = values[4];
        }
    }
}
