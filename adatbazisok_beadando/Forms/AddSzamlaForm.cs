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

            DatabaseAccess.ExecuteInsert(query);
        }
    }
}
