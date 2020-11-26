using System;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public partial class AddUgyfelForm : Form
    {
        public AddUgyfelForm()
        {
            InitializeComponent();
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

            DatabaseAccess.ExecuteInsert(query);
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

        private void AddUgyfelForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SendAndClose(object sender, EventArgs e)
        {
            SendData(sender, e);
            this.Close();
        }
    }
}
