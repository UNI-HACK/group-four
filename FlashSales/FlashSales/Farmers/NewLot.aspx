<%@ Page Title="" Language="C#" MasterPageFile="~/Granjero.Master" AutoEventWireup="true" CodeBehind="NewLot.aspx.cs" Inherits="FlashSales.Farmers.NewLot" %>
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
              <asp:DropDownList ID="ddlProducto" runat="server" CssClass="form-control"></asp:DropDownList>
          </div>
             
          <div class="form-group">
              Cantidad
              <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
          </div> 
              
          <div class="form-group">
              Fecha de vencimiento
              <asp:TextBox ID="txtVencimiento" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
          </div>    

         
          
          <asp:Button ID="btnAgregar" runat="server" Text="Agregar producto" CssClass="btn btn-primary" />
          <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" />
          
          
          
          </div>
  <div class="col-md-4"></div>
</div>
</div>

</asp:Content>
