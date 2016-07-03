using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_FlashSales.Objects
{
    public class Lote
    {
        public int ID_Lote;
        public int ID_Producto;
        public double Precio_Und;
        public int Cantidad;
        public int Valor_lote;
        public DateTime Fecha_creacion;
        public DateTime Fecha_caducidad;
    }
}