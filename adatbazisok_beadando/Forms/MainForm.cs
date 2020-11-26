using System;
using System.Windows.Forms;
using adatbazisok_beadando.Forms;
using adatbazisok_beadando.Model;
using System.Linq;

namespace adatbazisok_beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowAtutalasok(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from átutalás");
            dataGridView1.InsertData(reader, MediaType.Atutalas);
        }

        private void ShowUgyfelek(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from ügyfél");
            dataGridView1.InsertData(reader, MediaType.Ugyfel);
        }

        private void ShowSzamlak(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from számla");
            dataGridView1.InsertData(reader, MediaType.Szamla);
        }

        private void ShowBankkartyak(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from bankkártya");
            dataGridView1.InsertData(reader, MediaType.Bankkartya);
        }

        private void AddAtutalas(object sender, EventArgs e)
        {
            new AddAtutalasForm().ShowDialog();
            ShowAtutalasok(null, null);
        }

        private void AddUgyfel(object sender, EventArgs e)
        {
            new AddUgyfelForm().ShowDialog();
            ShowUgyfelek(null, null);
        }

        private void AddSzamla(object sender, EventArgs e)
        {
            new AddSzamlaForm().ShowDialog();
            ShowSzamlak(null, null);
        }

        private void AddBankkartya(object sender, EventArgs e)
        {
            new AddBankkartyaForm().ShowDialog();
            ShowBankkartyak(null,null);
        }

        private void TorlesButton_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void ModositasButton_Click(object sender, EventArgs e)
        {

        }
    }
}
