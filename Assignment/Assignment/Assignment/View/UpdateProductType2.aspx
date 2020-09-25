<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProductType2.aspx.cs" Inherits="Assignment.View.UpdateProductType2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
        .BodyProdType2{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyProdType2">

    
    <p>
        Product Type Name:<asp:TextBox ID="BoxTypeName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="BoxTypeName">Must Be filled</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ControlToValidate = "BoxTypeName" ID="RegularExpressionValidator2" ValidationExpression = "^[\s\S]{5,}$" runat="server" ErrorMessage="Must be longer than 5 character"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelUnique" runat="server"></asp:Label>
    </p>
    <p>
        Product Type Description:<asp:TextBox ID="BoxTypeDesc" runat="server" Height="67px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="BoxTypeDesc">Must be filled</asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
    </p>
        </div>
</asp:Content>
