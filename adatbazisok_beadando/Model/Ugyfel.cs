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
            if (values.Count != 12) return;
            UgyfelId = int.Parse(values[0]);
            Keresztnev = values[1];
            Utonev = values[2];
            Telefonszam = values[3];
            Megszolitas = values[4];
            SzemelyiIgazolvanySzam = values[5];
            AdoazonositoJel = values[6];
            EmailCim = values[7];
            Lakcim = values[8];
            SzuletesiDatum = DateTime.Parse(values[9]);
            AnyjaLeanykoriNeve = values[10];
            Allampolgarsag = values[11];
        }
    }
}
