using adatbazisok_beadando.Forms;
using adatbazisok_beadando.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace adatbazisok_beadando
{
    public partial class MainForm : Form
    {
        private MediaType? type;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowAtutalasok(object sender, EventArgs e)
        {
            var sql = "SELECT * from átutalás";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            mainGrid.InsertData(reader, MediaType.Atutalas);
            type = MediaType.Atutalas;
            ChangeText(DatabaseAccess.latestSQl);
        }

        private void ShowUgyfelek(object sender, EventArgs e)
        {
            var sql = "SELECT * from ügyfél";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            mainGrid.InsertData(reader, MediaType.Ugyfel);
            type = MediaType.Ugyfel;
            ChangeText(DatabaseAccess.latestSQl);
        }

        private void ShowSzamlak(object sender, EventArgs e)
        {
            var sql = "SELECT * from számla";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            mainGrid.InsertData(reader, MediaType.Szamla);
            type = MediaType.Szamla;
            ChangeText(DatabaseAccess.latestSQl);
        }

        private void ShowBankkartyak(object sender, EventArgs e)
        {
            var sql = "SELECT * from bankkártya";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            mainGrid.InsertData(reader, MediaType.Bankkartya);
            type = MediaType.Bankkartya;
            ChangeText(DatabaseAccess.latestSQl);
        }

        private void ShowMeghtalmazasok(object sender, EventArgs e)
        {
            var sql = "SELECT `ügyfél`.`Megszólítás`,`ügyfél`.`Keresztnév`," +
                "`ügyfél`.`Vezetéknév`,`meghatalmazott`.`meghatalmazott azonosító`," +
                "`meghatalmazott`.`számlaszám` FROM `ügyfél`,`meghatalmazott` " +
                "WHERE `ügyfél`.`Ügyfél azonosító` = `meghatalmazott`.`meghatalmazott azonosító`";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            mainGrid.InsertData(reader, MediaType.Meghatalmazas);
            type = MediaType.Meghatalmazas;
            ChangeText(DatabaseAccess.latestSQl);
        }

        private void ShowTulajdonosok(object sender, EventArgs e)
        {
            var sql = "SELECT `ügyfél`.`Megszólítás`,`ügyfél`.`Keresztnév`," +
                "`ügyfél`.`Vezetéknév`,`tulajdonos`.`ügyfél azonosító`," +
                "`tulajdonos`.`számlaszám`, `tulajdonos`.`tulajdonrész` FROM `ügyfél`,`tulajdonos` " +
                "WHERE `ügyfél`.`Ügyfél azonosító` = `tulajdonos`.`ügyfél azonosító`";
            var reader = DatabaseAccess.ExcecuteRead(sql);
            mainGrid.InsertData(reader, MediaType.Tulajdonos);
            type = MediaType.Tulajdonos;
            ChangeText(DatabaseAccess.latestSQl);
        }

        private void AddAtutalas(object sender, EventArgs e)
        {
            new AddAtutalasForm().ShowDialog();
            ChangeText(DatabaseAccess.latestSQl);
            ShowAtutalasok(null, null);
        }

        private void AddUgyfel(object sender, EventArgs e)
        {
            new AddUgyfelForm().ShowDialog();
            ChangeText(DatabaseAccess.latestSQl);
            ShowUgyfelek(null, null);
        }

        private void AddSzamla(object sender, EventArgs e)
        {
            new AddSzamlaForm().ShowDialog();
            ChangeText(DatabaseAccess.latestSQl);
            ShowSzamlak(null, null);
        }

        private void AddBankkartya(object sender, EventArgs e)
        {
            new AddBankkartyaForm().ShowDialog();
            ChangeText(DatabaseAccess.latestSQl);
            ShowBankkartyak(null, null);
        }

        private void TorlesButton_Click(object sender, EventArgs e)
        {
            if (type == null || mainGrid.SelectedRows.Count == 0) return;
            var data = mainGrid.SelectedRows[0].Cells[0].Value.ToString();
            DatabaseAccess.ExecuteDelete(data, type);
            ChangeText(DatabaseAccess.latestSQl);
            UpdateForm();
        }

        private void ModositasButton_Click(object sender, EventArgs e)
        {
            if (mainGrid.SelectedRows.Count == 0) return;
            var data = mainGrid.SelectedRows[0].Cells;
            var list = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                list.Add(data[i].Value.ToString());
            }

            switch (type)
            {
                case MediaType.Atutalas:
                    new AddAtutalasForm(list).ShowDialog();
                    ChangeText(DatabaseAccess.latestSQl);
                    ShowAtutalasok(null, null);
                    break;
                case MediaType.Bankkartya:
                    new AddBankkartyaForm(list).ShowDialog();
                    ChangeText(DatabaseAccess.latestSQl);
                    ShowBankkartyak(null, null);
                    break;
                case MediaType.Szamla:
                    new AddSzamlaForm(list).ShowDialog();
                    ChangeText(DatabaseAccess.latestSQl);
                    ShowSzamlak(null, null);
                    break;
                case MediaType.Ugyfel:
                    new AddUgyfelForm(list).ShowDialog();
                    ChangeText(DatabaseAccess.latestSQl);
                    ShowUgyfelek(null, null);
                    break;
                default:
                    break;
            }
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

        private void ChangeText(string text)
        {
            sqlTextBox.Text += string.Format("Executed SQL: {0}" + Environment.NewLine, text);
        }

        private void SqlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1000)
            {
                var lastText = ((TextBox)sender).Text.Split('\n');
                ((TextBox)sender).Text = lastText[lastText.Length - 2] + "\n";
            }
        }

        private void TranzakciokGrafikonMutatasa(object sender, EventArgs e)
        {
            new ChartForm().ShowDialog();
        }
    }
}
