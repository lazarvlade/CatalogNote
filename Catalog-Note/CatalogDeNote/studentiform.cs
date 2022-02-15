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
    public partial class studentiform: MaterialSkin.Controls.MaterialForm
    {
        //SqlDataAdapter dataAd = new SqlDataAdapter();
        // DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        int studentselectat;

        public studentiform()
        {
            InitializeComponent();
        }

        private void listaload()
        {
            SqlDataAdapter dataAd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dataAd = new SqlDataAdapter("SELECT nume, prenume, nr_matricol FROM studenti WHERE sters=0 ORDER BY nume ASC", conectare.DeschidereConectare());
            dataAd.Fill(dt);
            listastudenti.DataSource = dt;
            dt.Columns.Add("student", typeof(string), "nume+' '+prenume");
            listastudenti.DisplayMember = "student";
            listacod.DataSource = dt;
            listacod.DisplayMember = "nr_matricol";
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            listaload();
        }
        private void iesirebtn_Click_2(object sender, EventArgs e)
        {
            mainform window = new mainform();
            this.Close();
            window.ShowDialog();
        }

        private void adaugarebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text!= "" && textBox2.Text!= "" && textBox3.Text!= "")
                {
                    cmd = new SqlCommand("insert into studenti values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','0')", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentul a fost adăugat");
                    listaload();
                }   
                else
                {
                    MessageBox.Show("Completați toate câmpurile");
                }

            }
            catch (Exception)
            {
                conectare.InchidereConectare();

            }
        }

        private void listacod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sir = listacod.SelectedItem;
            string cod = ((System.Data.DataRowView)sir).Row.ItemArray[2].ToString();
            string prenume = ((System.Data.DataRowView)sir).Row.ItemArray[1].ToString();
            string nume = ((System.Data.DataRowView)sir).Row.ItemArray[0].ToString();
            studentselectat = Int32.Parse(cod);
            System.Diagnostics.Debug.WriteLine(studentselectat);
            textBox1.Text = nume;
            textBox3.Text = prenume;
            textBox2.Text = cod;


        }

        private void stergerebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE studenti SET sters = 1 WHERE nr_matricol ='" + studentselectat + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                listaload();
                MessageBox.Show("Studentul a fost șters");
            }
            catch (Exception)
            {
                conectare.InchidereConectare();
            }
        }

        private void modificarebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    cmd = new SqlCommand("UPDATE studenti SET nume='" + textBox1.Text + "', prenume='"+textBox3.Text+"', nr_matricol='"+textBox2.Text+"' WHERE nr_matricol = '" + studentselectat + "'", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    listaload();
                    MessageBox.Show("Datele studentului au fost modificate");
                    
                }
                else
                {
                    MessageBox.Show("Completați toate câmpurile");
                }

            }
            catch (Exception)
            {
                conectare.InchidereConectare();

            }
        }

        private void clasastudenti_Enter(object sender, EventArgs e)
        {

        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listastudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
