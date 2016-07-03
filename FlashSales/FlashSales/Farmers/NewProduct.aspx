<%@ Page Title="Nuevo Producto" Language="C#" MasterPageFile="~/Granjero.Master" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="FlashSales.Farmers.NewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
	<div class="row">
  		<div class="col-md-4"></div>
          <div class="col-md-4">
          <h1>Nuevo producto</h1>
          <br/>
          
          <div class="form-group">
              Producto
              <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>
          </div>

          <div class="form-group">
              Descripción
              <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
          </div>
              
          <div class="form-group">
              Tipo del producto
              <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
          </div>
              
          <div class="form-group">
              Unidad de medida
              <asp:DropDownList ID="ddlUnidad" runat="server" CssClass="form-control"></asp:DropDownList>
          </div>
                

          <div class="form-group">
          	Precio de venta
          	<div class="input-group">
            	<div class="input-group-addon">&nbsp;&nbsp;$</div>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
          </div>
         
          
          <asp:Button ID="btnAgregar" runat="server" Text="Agregar producto" CssClass="btn btn-primary" />
          <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" />
          
          
          
          </div>
  <div class="col-md-4"></div>
</div>
</div>

</asp:Content>
