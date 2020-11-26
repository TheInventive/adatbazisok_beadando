using adatbazisok_beadando.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public static class DataGridViewHelper
    {
        public static void InsertData(this DataGridView grid, Dictionary<int, List<string>> values, MediaType type)
        {
            switch (type)
            {
                case MediaType.Atutalas:
                    var result = GetAtutalas(values);
                    grid.DataSource = result;
                    break;
                case MediaType.Bankkartya:
                    grid.DataSource = GetBankkartya(values);
                    break;
                case MediaType.Szamla:
                    grid.DataSource = GetSzamla(values);
                    break;
                case MediaType.Ugyfel:
                    grid.DataSource = GetUgyfel(values);
                    break;
            }

        }

        public static List<Ugyfel> GetUgyfel(Dictionary<int, List<string>> values)
        {
            var data = new List<Ugyfel>();
            for (int i = 0; i < values.Count; i++)
            {
                values.TryGetValue(i, out List<string> row);
                data.Add(new Ugyfel(row));
            }
            return data;
        }

        public static List<Atutalas> GetAtutalas(Dictionary<int, List<string>> values)
        {
            var data = new List<Atutalas>();
            if (values.Count == 0) return null;
            for (int i = 0; i < values.Count; i++)
            {
                values.TryGetValue(i, out List<string> row);
                data.Add(new Atutalas(row.ToArray()));
            }
            return data;
        }

        public static List<Bankkartya> GetBankkartya(Dictionary<int, List<string>> values)
        {
            var data = new List<Bankkartya>();
            if (values.Count == 0) return null;
            for (int i = 0; i < values.Count; i++)
            {
                values.TryGetValue(i, out List<string> row);
                data.Add(new Bankkartya(row));
            }
            return data;
        }

        public static List<Szamla> GetSzamla(Dictionary<int, List<string>> values)
        {
            var data = new List<Szamla>();
            if (values.Count == 0) return null;
            for (int i = 0; i < values.Count; i++)
            {
                values.TryGetValue(i, out List<string> row);
                data.Add(new Szamla(row));
            }
            return data;
        }
    }
}
