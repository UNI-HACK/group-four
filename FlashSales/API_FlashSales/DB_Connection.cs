using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace API_FlashSales
{
    public class DB_Connection
    {

        public static DataTable ExecuteSP(string sp, SqlParameter[] parameters = null)
        {
            DataTable Reader = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Flash_Saless"].ConnectionString))
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
                        da.Fill(Reader);
                        con.Close();
                    }

                    return Reader;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}