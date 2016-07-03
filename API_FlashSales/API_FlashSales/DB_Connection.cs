using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_FlashSales
{
    public class DB_Connection
    {

        public static DataTable ExecuteSP(string sp, SqlParameter[] parameters = null)
        {
            DataTable Tabla = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Flash_Sales"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sp, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            foreach (SqlParameter par in parameters)
                            {
                                cmd.Parameters.Add(par);
                            }
                        }

                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(Tabla);
                        con.Close();
                    }

                    return Tabla;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}