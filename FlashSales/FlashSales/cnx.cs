using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FlashSales
{
    public class cnx
    {
        public static DataTable ExecuteSP(string sp, SqlParameter[] parameters = null)
        {
            DataTable Reader = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=40.0.0.158; Initial Catalog=FLASH_SALES; User Id=campos; password=campos;"))
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
                        //Reader = cmd.exe;

                        //con.Close();
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