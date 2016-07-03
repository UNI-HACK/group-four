using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using API_FlashSales.Objetos;
using System.Data;

namespace API_FlashSales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : API_Services
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<TipoProducto> Tipos()
        {
            try
            {
                List<TipoProducto> Lista = new List<TipoProducto>();
                DataTable Tipos = new DataTable();
                Tipos = DB_Connection.ExecuteSP("obtenerTipos");

                foreach (DataRow row in Tipos.Rows)
                {
                    Lista.Add(
                        new TipoProducto
                        {
                            ID = (int)row["ID"],
                            Nombre = row["Nombre"].ToString()
                        }
                        );
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
