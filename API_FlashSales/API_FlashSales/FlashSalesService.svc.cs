using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using API_FlashSales.Objects;
using System.Data;
using System.Data.SqlClient;

namespace API_FlashSales
{
    
    public class Service1 : FlashSalesService
    {
        public List<Lote> CargarInventario(int IDUsuario)
        {
            throw new NotImplementedException();
        }

        public Lote CargarLote(int IDLote)
        {
            throw new NotImplementedException();
        }

        public bool InsertarProducto(Product producto)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[5];

                parametros[0] = new SqlParameter("@Nombre_Producto", producto.Nombre);
                parametros[1] = new SqlParameter("@ID_TipoP", producto.IDTipo);
                parametros[2] = new SqlParameter("@ID_UndM", producto.IDUnidad);
                parametros[3] = new SqlParameter("@Precio", producto.Precio);
                parametros[4] = new SqlParameter("@Username", producto.Username);

                DB_Connection.ExecuteSP("insertarProducto", parametros);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
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

        public List<UnidadesProducto> Unidades()
        {
            try
            {
                List<UnidadesProducto> Lista = new List<UnidadesProducto>();
                DataTable Tipos = new DataTable();
                Tipos = DB_Connection.ExecuteSP("obtenerUnidades");

                foreach (DataRow row in Tipos.Rows)
                {
                    Lista.Add(
                                new UnidadesProducto
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
