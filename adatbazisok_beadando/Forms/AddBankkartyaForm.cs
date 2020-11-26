using System;
using System.Windows.Forms;

namespace adatbazisok_beadando.Forms
{
    public partial class AddBankkartyaForm : Form
    {
        public AddBankkartyaForm()
        {
            InitializeComponent();
        }

        private void SendData(object sender, EventArgs e)
        {
            var query = "INSERT INTO bankkártya " +
                "VALUES ('"
                + bankkartyaszam.Text + "','"
                + lejarat.Value.ToString("yyyy-MM-dd") + "','"
                + megerositoCod.Text + "','"
                + tipus.Text + "','"
                + limit.Text + "','"
                + bankszamlaszam.Text
                + "');";

            DatabaseAccess.ExecuteInsert(query);
        }
    }
}
