using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public partial class AddUgyfelForm : Form
    {
        private readonly bool isModify;
        private readonly int ugyfelAzonosito;
        public AddUgyfelForm()
        {
            isModify = false;
            InitializeComponent();
        }

        public AddUgyfelForm(List<string> list)
        {
            InitializeComponent();
            sendDataButton.Visible = false;
            ugyfelAzonosito = int.Parse(list[0]);
            isModify = true;
            if (list.Count != 12) return;
            keresztnev.Text = list[1];
            vezeteknev.Text = list[2];
            telefonszam.Text = list[3];
            megszolitas.Text = list[4];
            szemelyiIgazolvanySzam.Text = list[5];
            adoazonositoJel.Text = list[6];
            emailcim.Text = list[7];
            lakcim.Text = list[8];
            allampolgarsag.Text = list[9];
            anyjaLeanykoriNeve.Text = list[10];
            szuletesiDatum.Value = DateTime.Parse(list[11]);

        }

        private void SendData(object sender, EventArgs e)
        {
            if (isModify)
            {
                Modify();
                return;
            }
            var query = "INSERT INTO ügyfél (`Keresztnév`," +
                "`Vezetéknév`,`Megszólítás`,`Telefonszám`," + "`Email`," +
                "`Lakcím`,`Személyi igazolvány szám`,`Adóazonosító jel`," +
                "`Állampolgárság`,`Születési dátum`,`Anyja leánykori neve`)" +
                "VALUES ('"
                + keresztnev.Text + "','"
                + vezeteknev.Text + "','"
                + megszolitas.Text + "','"
                + telefonszam.Text + "','"
                + emailcim.Text + "','"
                + lakcim.Text + "','"
                + szemelyiIgazolvanySzam.Text + "','"
                + adoazonositoJel.Text + "','"
                + allampolgarsag.Text + "','"
                + szuletesiDatum.Value.ToString("yyyy-MM-dd") + "','"
                + anyjaLeanykoriNeve.Text + "');";

            if (DatabaseAccess.ExecuteInsert(query))
            {
                keresztnev.Clear();
                vezeteknev.Clear();
                megszolitas.Clear();
                telefonszam.Clear();
                emailcim.Clear();
                lakcim.Clear();
                szemelyiIgazolvanySzam.Clear();
                adoazonositoJel.Clear();
                allampolgarsag.Clear();
                szuletesiDatum.ResetText();
                anyjaLeanykoriNeve.Clear();
            }
        }

        private void SendAndClose(object sender, EventArgs e)
        {
            SendData(sender, e);
            Close();
        }

        private void Modify()
        {
            var query = $"UPDATE `ügyfél` SET `Keresztnév` = '{keresztnev.Text}', " +
                $"`Vezetéknév` = '{vezeteknev.Text}', " +
                $"`Megszólítás` = '{megszolitas.Text}', " +
                $"`Telefonszám` = '{telefonszam.Text}', " +
                $"`Lakcím` = '{lakcim.Text}', " +
                $"`Személyi igazolvány szám` = '{szemelyiIgazolvanySzam.Text}', " +
                $"`Adóazonosító jel` = '{adoazonositoJel.Text}', " +
                $"`Állampolgárság` = '{allampolgarsag.Text}', " +
                $"`Születési dátum` = '{szuletesiDatum.Value:yyyy-MM-dd}', " +
                $"`Anyja leánykori neve` = '{anyjaLeanykoriNeve.Text}', " +
                $"`Email` = '{emailcim.Text}' " +
                $"WHERE `ügyfél`.`Ügyfél azonosító` = {ugyfelAzonosito};";

            if (DatabaseAccess.ExecuteInsert(query))
            {
                DatabaseAccess.latestSQl = query;
                Close();
            }
        }
    }
}
