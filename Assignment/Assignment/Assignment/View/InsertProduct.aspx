<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="Assignment.View.InsertProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .BodyInProd{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyInProd">
    <p>
        Insert Product</p>
    Product Name:<asp:TextBox ID="BoxProductName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="BoxProductName" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
    <br />
    <br />
    Product Stock:<asp:TextBox ID="BoxProductStock" runat="server" Height="25px"></asp:TextBox>
        <asp:Label ID="LabelStock" runat="server"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="BoxProductStock" ErrorMessage="Must be number" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
    <br />
    <br />
    Product Price:<asp:TextBox ID="BoxProductPrice" runat="server"></asp:TextBox>
    <asp:Label ID="LabelPrice" runat="server"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="BoxProductPrice" ErrorMessage="Must be number" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    Product Type ID:<asp:TextBox ID="BoxTypeID" runat="server"></asp:TextBox>
    <asp:Label ID="LabelType" runat="server"></asp:Label>
    <br />
    <asp:Button ID="BtnInsertProduct" runat="server" Text="Submit" OnClick="BtnInsertProduct_Click" />
        </div>
</asp:Content>
