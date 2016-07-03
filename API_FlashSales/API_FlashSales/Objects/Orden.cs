using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_FlashSales.Objects
{
    public class Orden
    {
        public int ID_ORDEN;
        public int ID_Direccion;
        public DateTime Fecha_acordada;
        public double Costo_Envio;
        public double Subtotal;
        public double Total;
        public int Estado;
        public string Comprador;
        public string Vendedor;
    }
}