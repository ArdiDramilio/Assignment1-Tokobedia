<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProduct2.aspx.cs" Inherits="Assignment.View.UpdateProduct2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyProd2{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyProd2">

    
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
    <p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Button" OnClick="BtnSubmit_Click"/>
    </p>
        </div>
</asp:Content>
