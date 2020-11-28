using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, System.EventArgs e)
        {
            FillSzamlaBox();
            ShowData(eredetListBox.Items[0].ToString());
        }

        private void ShowData(string szamlaszam)
        {
            atutalasChart.Series["Átutalások"].Points.Clear();
            var sql = $"SELECT * from átutalás WHERE `átutalás`.`Eredetszámla számlaszáma` = '{szamlaszam}'";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            var result = DataGridViewHelper.GetAtutalas(reader);
            if(result == null)
            {
                MessageBox.Show("Az adott számlázoh nem tartoznak átutalások.");
                return;
            }
            var month = result
                .Select(_ => new { _.Datum, _.Mennyiseg })
                .GroupBy(_ => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_.Datum.Month)).ToDictionary(key => key.Key, value => value.ToList())
                .Select(_ => new { _.Key, V = _.Value.Sum(m => m.Mennyiseg) });
            foreach (var m in month)
            {
                atutalasChart.Series["Átutalások"].Points.AddXY(m.Key, m.V);
            }
        }

        private void FillSzamlaBox()
        {
            var query = "SELECT * from számla LIMIT 100";
            var result = DatabaseAccess.ExcecuteRead(query);
            var data = DataGridViewHelper.GetSzamla(result);
            var list = data.Select(_ => _.Szamlaszam);
            foreach (var l in list)
            {
                eredetListBox.Items.Add(l);
            }
        }

        private void EredetListBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var text = ((ListBox)sender).SelectedItem.ToString();
            ShowData(text);
        }
    }
}
