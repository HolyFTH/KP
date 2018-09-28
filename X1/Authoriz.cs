using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace X1
{
    class Authoriz
    {
            public SqlConnection Connection()
            {
                string connectionString = "Data Source = DESKTOP-0PU11SR\\SQLEXPRESS; Initial Catalog = X1_Shop; Integrated Security=true;";
                SqlConnection sc = new SqlConnection(connectionString);
                sc.Open();
                //if (sc != null)
                //    Program.connectionstatus = true;
                return (sc);


            }

            public string Authz(string pas, string log)
            {
                SqlCommand command = new SqlCommand("SELECT Pass_Polz as PP, Log_Polz as LP, ID_Polz as ID FROM X1_Shop.dbo.Polz WHERE Pass_Polz = " + "'" + pas + "'" + " and Log_Polz = " + "'" + log + "'", Connection());
                SqlDataReader reader = command.ExecuteReader();
                string passlog = "";
                //int ID;
                while (reader.Read())
                {
                    passlog = reader["PP"].ToString();
                    passlog += " " + reader["LP"].ToString();
                    //ID = Convert.ToInt16(reader["ID"]);
                }
                return passlog;

            }
        
    }
}
