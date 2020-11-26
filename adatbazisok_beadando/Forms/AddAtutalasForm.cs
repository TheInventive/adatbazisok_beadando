using System;
using System.Windows.Forms;

namespace adatbazisok_beadando.Forms
{
    public partial class AddAtutalasForm : Form
    {
        public AddAtutalasForm()
        {
            InitializeComponent();
        }

        private void SendData(object sender, EventArgs e)
        {
            var query = "INSERT INTO átutalás (`Mennyiség`," +"`valuta`,"+
                "`Dátum`,`Megbízó azonosító`,`Célszámla számlaszáma`," +
                "`Eredetszámla számlaszáma`)" +
                "VALUES ('"
                + mennyiseg.Text + "','"
                + valuta.Text + "','"
                + datum.Value.ToString("yyyy-MM-dd") + "','"
                + megbizoAzonosito.Text + "','"
                + celszamlaSzamlaszama.Text + "','"
                + eredetszamlaSzamlaszama.Text
                + "');";

            DatabaseAccess.ExecuteInsert(query);
        }
    }
}
