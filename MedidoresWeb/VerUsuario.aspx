<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerUsuario.aspx.cs" Inherits="MedidoresWeb.VerUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="row">

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
                          <div class="row mt-5">
                    <asp:GridView 
                        CssClass="table table-hover table-bordered"
                        ID="grillaAsistente"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        EmptyDataText="No hay registros"
                        runat="server"
                        OnRowCommand="grillaAsistente_RowCommand">
                        <Columns>
                            <asp:BoundField HeaderText="Rut" DataField="Nombre" />
                            <asp:BoundField HeaderText="Nombre" DataField="Apellido" />
                            <asp:BoundField HeaderText="Email" DataField="Empresa" />
                            <asp:TemplateField HeaderText="Acciones">
                                <ItemTemplate>
                                    <asp:Button CssClass="btn btn-danger" runat="server"
                                        CommandName="eliminar" Text="Eliminar"
                                        CommandArgument='<%#Eval("Id") %>'
                                        />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
              </ContentTemplate>
            </asp:UpdatePanel>
 
          
        </div>
</asp:Content>
