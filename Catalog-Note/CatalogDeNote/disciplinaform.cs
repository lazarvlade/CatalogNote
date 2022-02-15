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
    public partial class disciplinaform : MaterialSkin.Controls.MaterialForm
    {
        //SqlDataAdapter dataAd = new SqlDataAdapter();
        // DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        int disciplinaselectata;

        public disciplinaform()
        {
            InitializeComponent();
        }

        private void listaload()
        {
            SqlDataAdapter dataAd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dataAd = new SqlDataAdapter("SELECT denumire, cod_disciplina FROM discipline WHERE sters=0", conectare.DeschidereConectare());
            dataAd.Fill(dt);
            listadiscipline.DataSource = dt;
            listadiscipline.DisplayMember = "denumire";
            listacod.DataSource = dt;
            listacod.DisplayMember = "cod_disciplina";
            conectare.InchidereConectare();
        }
        private void disciplineform_Load(object sender, EventArgs e)
        {
            listaload();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void denumiretxt_Click(object sender, EventArgs e)
        {

        }

        private void creditetxt_Click(object sender, EventArgs e)
        {

        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            mainform window = new mainform();
            this.Close();
            window.ShowDialog();
        }

        private void listastudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stergerebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE discipline SET sters = 1 WHERE cod_disciplina ='" + disciplinaselectata + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                listaload();
                MessageBox.Show("Disciplina a fost ștearsă");
                conectare.InchidereConectare();
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
                    cmd = new SqlCommand("UPDATE discipline SET denumire='" + textBox1.Text + "', nr_credite='" + textBox3.Text + "', cod_disciplina='" + textBox2.Text + "' WHERE cod_disciplina = '" + disciplinaselectata + "'", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    listaload();
                    MessageBox.Show("Datele disciplinei au fost modificate");

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
        private void adaugarebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    cmd = new SqlCommand("insert into discipline values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','0')", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    listaload();
                    MessageBox.Show("Disciplina a fost adăugată");
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

        private void codtxt_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clasadisclipine_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var sir = listacod.SelectedItem;
            string cod = ((System.Data.DataRowView)sir).Row.ItemArray[1].ToString();
            string denumire = ((System.Data.DataRowView)sir).Row.ItemArray[0].ToString();
            disciplinaselectata = Int32.Parse(cod);
            
            textBox1.Text = denumire;
            try
            {
                cmd = new SqlCommand("SELECT nr_credite FROM discipline WHERE cod_disciplina='" + cod + "'", conectare.DeschidereConectare());
                SqlDataReader da = cmd.ExecuteReader();

                while(da.Read())
                {
                    textBox3.Text = da.GetInt32(0).ToString();
                    System.Diagnostics.Debug.WriteLine(da.GetInt32(0).ToString());
                }
                conectare.InchidereConectare();
            }
            catch (Exception)
            {
                conectare.InchidereConectare();
            }
            textBox2.Text = cod;
        }
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}