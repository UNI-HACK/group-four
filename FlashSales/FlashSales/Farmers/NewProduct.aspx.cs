using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlashSales.API;

namespace FlashSales.Farmers
{
    public partial class NewProduct : System.Web.UI.Page
    {
        API.FlashSalesServiceClient cliente = new FlashSalesServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                CargarTipos();
                CargarUnidades();
            }
        }

        private void CargarTipos()
        {
            ddlTipo.DataSource = cliente.Tipos();
            ddlTipo.DataTextField = "Nombre";
            ddlTipo.DataValueField = "ID";
            ddlTipo.DataBind();
        }

        private void CargarUnidades()
        {
            ddlUnidad.DataSource = cliente.Unidades();
            ddlUnidad.DataTextField = "Nombre";
            ddlUnidad.DataValueField = "ID";
            ddlUnidad.DataBind();
        }

    }
}