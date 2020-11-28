using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace adatbazisok_beadando.Forms
{
    public partial class AddSzamlaForm : Form
    {
        private readonly bool isModify;
        private readonly string szam = "";
        public AddSzamlaForm()
        {
            isModify = false;
            InitializeComponent();
        }

        public AddSzamlaForm(List<string> list)
        {
            InitializeComponent();
            kuldes.Visible = false;
            isModify = true;
            if (list.Count != 4) return;
            szamlaszam.Text = list[0];
            szam = list[0];
            valuta.Text = list[1];
            penz.Text = list[2];
            szerzodesDatuma.Value = DateTime.Parse(list[3]);
        }

        private void SendData(object sender, EventArgs e)
        {
            if (isModify)
            {
                Modify();
                return;
            }
            var query = "INSERT INTO számla (`Számlaszám`," +
                "`Valuta`,`Pénz`,`Szerződés dátuma`)" +
                "VALUES ('"
                + szamlaszam.Text + "','"
                + valuta.Text + "','"
                + penz.Text + "','"
                + szerzodesDatuma.Value.ToString("yyyy-MM-dd")
                + "');";

            if (DatabaseAccess.ExecuteInsert(query))
            {
                szamlaszam.Clear();
                valuta.Clear();
                penz.Clear();
                szerzodesDatuma.ResetText();
            }
        }

        private void Modify()
        {
            var query = $"UPDATE `számla` SET `Számlaszám` = '{szamlaszam.Text}', " +
                $"`Valuta` = '{valuta.Text}', " +
                $"`Pénz` = '{penz.Text}', " +
                $"`Szerződés dátuma` = '{szerzodesDatuma.Value:yyyy-MM-dd}' " +
                $"WHERE `számla`.`Számlaszám` = '{szam}';";

            if (DatabaseAccess.ExecuteInsert(query))
            {
                DatabaseAccess.latestSQl = query;
                Close();

            }
        }

        private void ValutaListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuta.Text = ((ListBox)sender).SelectedItem.ToString();
        }

        private void SendAndClose(object sender, EventArgs e)
        {
            SendData(sender, e);
            Close();
        }
    }
}
