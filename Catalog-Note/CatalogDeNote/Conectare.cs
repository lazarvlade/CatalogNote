using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CatalogDeNote
{
    class Conectare
    {
        SqlConnection conectare;

        public Conectare()
        {
            conectare = new SqlConnection("Server=DESKTOP-8BGN49D\\SQLEXPRESS;Database=catalog;Trusted_Connection=True;");
        }

        public SqlConnection DeschidereConectare()
        {
            try
            {
                conectare.Open();
            }
            catch (Exception)
            {

            }

            return conectare;
        }

        public void InchidereConectare()
        {
            try
            {
                conectare.Close();
            }
            catch (Exception)
            {

            }
        }



    }

}