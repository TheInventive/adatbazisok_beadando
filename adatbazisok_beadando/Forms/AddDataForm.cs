using System;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                + felefonszam.Text + "','"
                + emailcim.Text + "','"
                + lakcim.Text + "','"
                + szemelyiIgazolvanySzam.Text + "','"
                + adoazonositoJel.Text + "','"
                + allampolgarsag.Text + "','"
                + szuletesiDatum.Value.ToString("yyyy-MM-dd") + "','"
                + anyjaLeanykoriNeve.Text + "');";

            DatabaseAccess.ExecuteInsert(query);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
