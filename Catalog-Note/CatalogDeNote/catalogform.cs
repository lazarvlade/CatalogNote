using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CatalogDeNote
{

    public partial class catalogform : MaterialSkin.Controls.MaterialForm
    {

        SqlCommand cmd;
        Conectare conectare = new Conectare();
        int studentselectat;
        int disciplinaselectata;
        int notaselectata;
        public catalogform()
        {
            InitializeComponent();
        }
        
        private void listaload()
        {
            // STUDENTI LIST
            SqlDataAdapter dataAd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dataAd = new SqlDataAdapter("SELECT nume, prenume, nr_matricol FROM studenti WHERE sters=0", conectare.DeschidereConectare());
            dataAd.Fill(dt);
            studentlist.DataSource = dt;
            dt.Columns.Add("student", typeof(string), "nume+' '+prenume");
            studentlist.DisplayMember = "student";
            listastudenti.DataSource = dt;
            listastudenti.DisplayMember = "nr_matricol";

            // DISCIPLINE LIST
            SqlDataAdapter dataAd2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            dataAd2 = new SqlDataAdapter("SELECT denumire, cod_disciplina FROM discipline WHERE sters=0", conectare.DeschidereConectare());
            dataAd2.Fill(dt2);
            disciplinalist.DataSource = dt2;
            disciplinalist.DisplayMember = "denumire";
            listadiscipline.DataSource = dt2;
            listadiscipline.DisplayMember = "cod_disciplina";
        }

        private void noteload()
        {
            SqlDataAdapter dataAd3 = new SqlDataAdapter();
            DataTable dt3 = new DataTable();
            dataAd3 = new SqlDataAdapter("SELECT nota FROM catalog_note WHERE cod_disciplina='" + disciplinaselectata + "' AND nr_matricol='" + studentselectat + "' AND sters=0", conectare.DeschidereConectare());
            dataAd3.Fill(dt3);
            notelist.DataSource = dt3;
            notelist.DisplayMember = "nota";
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            listaload();
            noteload();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            mainform window = new mainform();
            this.Close();
            window.ShowDialog();
        }

        private void adaugarebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (noteadd.Text != "")
                {
                    cmd = new SqlCommand("insert into catalog_note values('" + disciplinaselectata + "','" + studentselectat + "','" + noteadd.Text + "','0')", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    noteload();
                    MessageBox.Show("Nota a fost adăugată");
                }
                else
                {
                    MessageBox.Show("Completați toate câmpurile");
                }
                conectare.InchidereConectare();
            }
            catch (Exception)
            {
                conectare.InchidereConectare();
            }
        }

        private void studentlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void disciplinalist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listastudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sir = listastudenti.SelectedItem;
            string cod = ((System.Data.DataRowView)sir).Row.ItemArray[2].ToString();
            studentselectat = Int32.Parse(cod);
            System.Diagnostics.Debug.WriteLine(studentselectat);
            noteload();

        }

        private void listadiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sir = listadiscipline.SelectedItem;
            string cod = ((System.Data.DataRowView)sir).Row.ItemArray[1].ToString();
            disciplinaselectata = Int32.Parse(cod);
            System.Diagnostics.Debug.WriteLine(disciplinaselectata);
            noteload();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void noteadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void notelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sir = notelist.SelectedItem;
            string cod = ((System.Data.DataRowView)sir).Row.ItemArray[0].ToString();
            System.Diagnostics.Debug.WriteLine(notaselectata);
            notaselectata = Int32.Parse(cod);
        }

        private void stergerebtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE catalog_note SET sters=1 WHERE cod_disciplina='" + disciplinaselectata + "' AND nr_matricol='" + studentselectat + "'AND nota='" + notaselectata + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                noteload();
                MessageBox.Show("Nota a fost ștearsă");
            }
            catch (Exception)
            {
                conectare.InchidereConectare();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void noteadd_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
  }
