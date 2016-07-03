using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using API_FlashSales.Objects;

namespace API_FlashSales
{
    
    [ServiceContract]
    public interface FlashSalesService
    {

        [OperationContract]
        List<TipoProducto> Tipos();

        [OperationContract]
        List<UnidadesProducto> Unidades();

        [OperationContract]
        Lote CargarLote(int IDLote);

        [OperationContract]
        List<Lote> CargarInventario(int IDUsuario);

        [OperationContract]
        bool InsertarProducto(Product producto);

    }

}
