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
using System.IO;
using System.Diagnostics;

namespace CatalogDeNote
{
    public partial class mainform : MaterialSkin.Controls.MaterialForm
    {
        //SqlDataAdapter dataAd = new SqlDataAdapter();
        // DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        public mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            catalogform window = new catalogform();
            this.Hide();
            window.Show();
        }
        private void studentibtn_Click(object sender, EventArgs e)
        {
            studentiform window = new studentiform();
            this.Hide();
            window.ShowDialog();
        }

        private void disciplinebtn_Click(object sender, EventArgs e)
        {
            disciplinaform window = new disciplinaform();
            this.Hide();
            window.ShowDialog();
        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Ești sigur că vrei să ieși? ", "Exit", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                DataTable Report_DT = new DataTable();
                Report_DT = Raport_DataSet();
                var csv = new StringBuilder();

                string[] header = Report_DT.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                csv.AppendLine(string.Join(",", header));


                foreach (DataRow row in Report_DT.Rows)
                {
                    string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                    csv.AppendLine(string.Join(",", fields));
                }

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            File.WriteAllText("POO_PROGRAM_Raport.csv", csv.ToString());
                System.Diagnostics.Process.Start(@startupPath);

        }

        public DataTable Raport_DataSet()
        {
            SqlDataAdapter dataAd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                dataAd = new SqlDataAdapter("SELECT  dbo.studenti.nume, dbo.studenti.prenume, dbo.discipline.denumire, dbo.catalog_note.nota, AVG(catalog_note.nota) OVER(PARTITION BY dbo.studenti.nume) AS medie, SUM(dbo.discipline.nr_credite * dbo.catalog_note.nota) OVER(PARTITION BY dbo.studenti.nume) AS punctaj, CASE WHEN MIN(dbo.catalog_note.nota) OVER(PARTITION BY dbo.studenti.nume) >= 5 THEN 'Integralist' ELSE 'Neintegralist' END AS informatie FROM studenti LEFT JOIN catalog_note ON catalog_note.nr_matricol = studenti.nr_matricol LEFT JOIN discipline ON discipline.cod_disciplina = catalog_note.cod_disciplina GROUP BY dbo.studenti.nume, dbo.studenti.prenume, dbo.discipline.denumire, dbo.catalog_note.nota, dbo.discipline.nr_credite ORDER BY studenti.nume", conectare.DeschidereConectare());
                dataAd.Fill(dt);
                MessageBox.Show("Raportul a fost exportat");
                conectare.InchidereConectare();
               

            }
            catch (Exception)
            {
                
            }
            return dt;
        }
    }
}
