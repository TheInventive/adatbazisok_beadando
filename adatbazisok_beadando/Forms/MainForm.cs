using System;
using System.Linq;
using System.Windows.Forms;
using adatbazisok_beadando.Forms;
using adatbazisok_beadando.Model;

namespace adatbazisok_beadando
{
    public partial class Form1 : Form
    {
        private MediaType? type;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowAtutalasok(object sender, EventArgs e)
        {
            var sql = "SELECT * from átutalás";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            dataGridView1.InsertData(reader, MediaType.Atutalas);
            type = MediaType.Atutalas;
            sqlLabel.Text += string.Format("Executed SQL: {0}\n", sql);
        }

        private void ShowUgyfelek(object sender, EventArgs e)
        {
            var sql = "SELECT * from ügyfél";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            dataGridView1.InsertData(reader, MediaType.Ugyfel);
            type = MediaType.Ugyfel;
            sqlLabel.Text += string.Format("Executed SQL: {0}\n", sql);
        }

        private void ShowSzamlak(object sender, EventArgs e)
        {
            var sql = "SELECT * from számla";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            dataGridView1.InsertData(reader, MediaType.Szamla);
            type = MediaType.Szamla;
            sqlLabel.Text += string.Format("Executed SQL: {0}\n", sql);
        }

        private void ShowBankkartyak(object sender, EventArgs e)
        {
            var sql = "SELECT * from bankkártya";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            dataGridView1.InsertData(reader, MediaType.Bankkartya);
            type = MediaType.Bankkartya;
            sqlLabel.Text += string.Format("Executed SQL: {0}\n", sql);
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
            ShowBankkartyak(null, null);
        }

        private void TorlesButton_Click(object sender, EventArgs e)
        {
            if (type != null)
            {
                var data = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                sqlLabel.Text += string.Format("Executed SQL: {0}\n", DatabaseAccess.ExecuteDelete(data, type));
                UpdateForm();
            }
        }

        private void ModositasButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm()
        {
            switch (type)
            {
                case MediaType.Atutalas:
                    ShowAtutalasok(null, null);
                    break;
                case MediaType.Bankkartya:
                    ShowBankkartyak(null, null);
                    break;
                case MediaType.Szamla:
                    ShowSzamlak(null, null);
                    break;
                case MediaType.Ugyfel:
                    ShowUgyfelek(null, null);
                    break;
                default:
                    break;
            }
        }

        private void SqlLabel_TextChanged(object sender, EventArgs e)
        {
            if (((Label)sender).Text.Length > 300)
            {
                var lastText = ((Label)sender).Text.Split('\n');
                ((Label)sender).Text = string.Empty;
                ((Label)sender).Text = lastText[lastText.Length-1];
            }
        }
    }
}
