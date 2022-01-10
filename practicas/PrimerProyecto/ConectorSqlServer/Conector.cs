using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectorSqlServer
{
    public class Conector
    {
		public void conexion()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "DESKTOP-191H2VS",
                    //UserID = "DESKTOP-191H2VS\VladiZ",
                    //Password ="",
                    InitialCatalog ="SocialMedia" 
                };
                using (SqlConnection conexion= new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("Conexion a BD");
                    string query = "select top(5) from dbo.Comentario*";
                    using (SqlCommand cmd=new SqlCommand(query,conexion))
                    {
                        conexion.Open();
                        using (SqlDataReader reader=cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}",reader.GetString(1), reader.GetString(2));
                            }
                        }
                    }
                }

        }
            catch (Exception e)
            {
                Console.WriteLine("+--+{1}",2);
            }
        }
    }
}
