﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace adatbazisok_beadando.Forms
{
    public partial class AddAtutalasForm : Form
    {
        public AddAtutalasForm()
        {
            InitializeComponent();
        }

        public AddAtutalasForm(List<string> data)
        {
            InitializeComponent();
            if (data.Count != 7) return;
            mennyiseg.Text = data[1];
            valuta.Text = data[2];
            datum.Text = data[3];
            megbizoAzonosito.Text = data[4];
            celszamlaSzamlaszama.Text = data[5];
            eredetszamlaSzamlaszama.Text = data[6];
        }

        private void SendData(object sender, EventArgs e)
        {
            var query = "INSERT INTO átutalás (`Mennyiség`," + "`valuta`," +
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

            if (DatabaseAccess.ExecuteInsert(query))
            {
                mennyiseg.Clear();
                valuta.Clear();
                datum.ResetText();
                megbizoAzonosito.Clear();
                celszamlaSzamlaszama.Clear();
                eredetszamlaSzamlaszama.Clear();
            }
        }

        private void SendAndClose(object sender, EventArgs e)
        {
            SendData(sender, e);
            Close();
        }

        private void AddAtutalasForm_Load(object sender, EventArgs e)
        {
            FillSzamlaBox();
        }

        private void CelListBoxChanged(object sender, EventArgs e)
        {
            celszamlaSzamlaszama.Text = ((ListBox)sender).SelectedItem.ToString();
        }

        private void ErderListBoxChanged(object sender, EventArgs e)
        {
            eredetszamlaSzamlaszama.Text = ((ListBox)sender).SelectedItem.ToString();
            FillMegbizoBox(eredetszamlaSzamlaszama.Text);
        }

        private void ValutaListBoxChanged(object sender, EventArgs e)
        {
            valuta.Text = ((ListBox)sender).SelectedItem.ToString();
        }


        private void MegbizoListBoxChanged(object sender, EventArgs e)
        {
            megbizoAzonosito.Text = ((ListBox)sender).SelectedItem.ToString().Split(' ').Last();
        }

        private void FillSzamlaBox()
        {
            var query = "SELECT * from számla LIMIT 100";
            var result = DatabaseAccess.ExcecuteRead(query);
            var data = DataGridViewHelper.GetSzamla(result);
            var list = data.Select(_ => _.Szamlaszam);
            foreach (var l in list)
            {
                celListBox.Items.Add(l);
                eredetListBox.Items.Add(l);
            }
        }

        private void FillMegbizoBox(string celszamlaSzamlaszama)
        {
            megbizoListbox.Items.Clear();
            var query = "SELECT DISTINCT  `ügyfél`. `Ügyfél azonosító`,`ügyfél`.`Keresztnév`,`ügyfél`.`Vezetéknév`,`ügyfél`.`Megszólítás` " +
                "FROM `ügyfél` " +
                "WHERE `ügyfél`.`Ügyfél azonosító` IN " +
                "(SELECT `meghatalmazott`.`meghatalmazott azonosító` FROM `meghatalmazott` " +
                $"WHERE `meghatalmazott`.`számlaszám` = '{celszamlaSzamlaszama}') " +
                "OR `ügyfél`.`Ügyfél azonosító` IN " +
                "(SELECT `tulajdonos`.`ügyfél azonosító` FROM `tulajdonos`" +
                $"WHERE `tulajdonos`.`számlaszám` = '{celszamlaSzamlaszama}') " +
                "ORDER BY `Ügyfél azonosító`;";
            var result = DatabaseAccess.ExcecuteRead(query);
            var data = DataGridViewHelper.GetUgyfel(result);
            foreach (var l in data)
            {
                megbizoListbox.Items.Add(l.ToString());
            }
        }
    }
}
