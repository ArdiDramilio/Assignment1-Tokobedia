<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="Assignment.View.InsertProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyInProdType{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyInProdType">
    <p>
        Insert Product Type</p>
    <p>
        Product Type:<asp:TextBox ID="BoxProductType" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="BoxProductType" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
        <asp:Label ID="LabelUnique" runat="server"></asp:Label>
        <asp:RegularExpressionValidator ControlToValidate = "BoxProductType" ID="RegularExpressionValidator2" ValidationExpression = "^[\s\S]{5,}$" runat="server" ErrorMessage="Must be longer than 5 character"></asp:RegularExpressionValidator>
    </p>
    <p>
        Description:<asp:TextBox ID="BoxDesc" runat="server" Height="127px" Width="215px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="BoxDesc" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="BtnInsertProductType" runat="server" Text="Submit" OnClick="BtnInsertProductType_Click" />
    </p>
        </div>
</asp:Content>
