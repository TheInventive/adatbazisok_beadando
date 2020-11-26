using System;
using System.Collections.Generic;

namespace adatbazisok_beadando.Model
{
    public class Ugyfel
    {
        public int UgyfelId { get; set; }
        public string Keresztnev { get; set; }
        public string Utonev { get; set; }
        public string Telefonszam { get; set; }
        public string Megszolitas { get; set; }
        public string SzemelyiIgazolvanySzam { get; set; }
        public string AdoazonositoJel { get; set; }
        public string EmailCim { get; set; }
        public string Lakcim { get; set; }
        public string Allampolgarsag { get; set; }
        public string AnyjaLeanykoriNeve { get; set; }
        public DateTime SzuletesiDatum { get; set; }

        public Ugyfel(List<string> values)
        {
            UgyfelId = int.Parse(values[0]);
            Keresztnev = values[1];
            Utonev = values[2];
            Megszolitas = values[3];
            if (values.Count == 4) return;
            Telefonszam = values[4];
            Lakcim = values[5];
            SzemelyiIgazolvanySzam = values[6];
            AdoazonositoJel = values[7];
            Allampolgarsag = values[8];
            SzuletesiDatum = DateTime.Parse(values[9]);
            AnyjaLeanykoriNeve = values[10];
            EmailCim = values[11];
        }

        public override string ToString()
        {
            return $"{Megszolitas} {Keresztnev} {Utonev} {UgyfelId}";
        }
    }
}
