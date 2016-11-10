using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace ClassLibraryForRegisterDB
{
    class DAL
    {

        SqlConnection con = new SqlConnection("Data Source=DMNLANUNAG;Initial Catalog=Registration;Integrated Security=True");
        void AddDummy(String Name) {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO dummy VALUES ('@" + Name + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void DeleteDummy(int Delete_ID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE * FROM dummy WHERE ID = ('@" + Delete_ID + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        DataTable ViewDummy()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Dummy)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // datagridview.datasource = dt;
            con.Close();
            return dt;   // use  dt DataTable as datasource
                         
        }



        
        
    }
}
