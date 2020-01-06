using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionStore
{
    class Sql_Raccourcis
    {
        // Declaration
        public SqlConnection Connex = new SqlConnection();
        public SqlCommand Comm = new SqlCommand();
        public SqlDataReader Rd;

        public DataTable DT = new DataTable();

        // Declaration methode connecter 
        public void CONNECTER()
        {
            if (Connex.State == ConnectionState.Closed || Connex.State == ConnectionState.Broken)
            {
                Connex.ConnectionString = "Data Source=Hyrkul;Initial Catalog=GestionStore;Integrated Security=True";
                Connex.Open();
            }
        }
        // Declaration methode Deconnecter
        public void DECONNECTER()
        {
            if (Connex.State == ConnectionState.Open)
            {
                Connex.Close();
            }
        }
    }
}
