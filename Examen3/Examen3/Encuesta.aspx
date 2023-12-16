<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Encuesta.aspx.cs" Inherits="Examen3.Encuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>  
   <h1>ENCUESTA</h1>
</div>
<div class="container text-center">
        Nombre: <asp:TextBox ID="txtNom" class="form-control" runat="server"></asp:TextBox>
        Edad: <asp:TextBox ID="txtEdad" class="form-control" runat="server"></asp:TextBox>
        Correo Electronico: <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" type="email" required="true"/>
<label for="Partidos" class="form-label">Partidos:</label>
<asp:DropDownList ID="DropDown"  class="form-control" runat="server" OnSelectedIndexChanged="Page_Load"></asp:DropDownList>
</div>

 
        <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="Añadir" OnClick="Button1_Click"  /> 
</asp:Content>
