using System;
using System.Windows.Forms;

namespace adatbazisok_beadando.Forms
{
    public partial class AddSzamlaForm : Form
    {
        public AddSzamlaForm()
        {
            InitializeComponent();
        }

        private void SendData(object sender, EventArgs e)
        {
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
