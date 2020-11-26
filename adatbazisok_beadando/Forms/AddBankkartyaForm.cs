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

            if (DatabaseAccess.ExecuteInsert(query))
            {
                bankkartyaszam.Clear();
                lejarat.ResetText();
                megerositoCod.Clear();
                tipus.Clear();
                limit.Clear();
                bankkartyaszam.Clear();
            }
        }

        private void AddBankkartyaForm_Load(object sender, EventArgs e)
        {
            var query = "SELECT * FROM számla LIMIT 100";
            var result = DatabaseAccess.ExcecuteRead(query);
            var szamlak = DataGridViewHelper.GetSzamla(result);
            foreach (var sz in szamlak)
            {
                bankszamaszamListbox.Items.Add(sz.Szamlaszam);
            }
        }

        private void BankszamaszamListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bankszamlaszam.Text = ((ListBox)sender).SelectedItem.ToString();
        }

        private void SendAndClose(object sender, EventArgs e)
        {
            SendData(sender, e);
            Close();
        }
    }
}
