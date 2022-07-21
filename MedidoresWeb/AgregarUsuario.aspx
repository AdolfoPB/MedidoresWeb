<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="MedidoresWeb.AgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="rutTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar el Rut"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="contrasenaTxt">Contraseña</label>
                        <asp:TextBox ID="contrasenaTxt" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="emailTxt">Email</label>
                        <asp:TextBox ID="emailTxt" TextMode="Email" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
            
                    <asp:Button runat="server" CssClass="btn btn-secondary"  OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
