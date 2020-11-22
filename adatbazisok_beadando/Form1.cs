using System;
using System.Windows.Forms;
using adatbazisok_beadando.Model;

namespace adatbazisok_beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UgyfelMegjelenitese(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ÜgyfelekMutatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from ügyfél");
            dataGridView1.InsertData(reader, MediaType.Ugyfel);
        }

        private void ÁtutalásokMutatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from átutalás");
            dataGridView1.InsertData(reader, MediaType.Atutalas);
        }

        private void SzámlákMutatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from számla");
            dataGridView1.InsertData(reader, MediaType.Szamla);
        }

        private void bankkártyákMutatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reader = DatabaseAccess.ExcecuteRead("SELECT * from bankkártya");
            dataGridView1.InsertData(reader, MediaType.Bankkartya);
        }
    }
}
