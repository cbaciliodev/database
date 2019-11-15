<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">

        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>

            <br />
            <label>Codigo</label>
            <asp:Label ID="codigo" runat="server" Text="Label"></asp:Label>
            <br />
            <label>Nombre</label>
            <asp:Label ID="nombre" runat="server" Text="Label"></asp:Label>

            <br />
            <label>Cuidad</label>
            <asp:Label ID="cuidad" runat="server" Text="Label"></asp:Label>

            <br />
            <label>Direccion</label>
            <asp:Label ID="direccion" runat="server" Text="Label"></asp:Label>
            <br />
            <label>Telefono</label>
            <asp:Label ID="telefono" runat="server" Text="Label"></asp:Label>

        </div>
    </div>

</asp:Content>
