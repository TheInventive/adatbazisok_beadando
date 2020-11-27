using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public partial class AddUgyfelForm : Form
    {
        public AddUgyfelForm()
        {
            InitializeComponent();
        }

        public AddUgyfelForm(List<string> list)
        {
            InitializeComponent();
            if (list.Count != 12) return;
            keresztnev.Text = list[1];
            vezeteknev.Text = list[2];
            megszolitas.Text = list[3];
            telefonszam.Text = list[4];
            emailcim.Text = list[5];
            lakcim.Text = list[6];
            szemelyiIgazolvanySzam.Text = list[7];
            adoazonositoJel.Text = list[8];
            allampolgarsag.Text = list[9];
            szuletesiDatum.Value = DateTime.Parse(list[11]);
            anyjaLeanykoriNeve.Text = list[10];
        }

        private void SendData(object sender, EventArgs e)
        {
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
    }
}
