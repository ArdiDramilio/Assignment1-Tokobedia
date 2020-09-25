<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="Assignment.View.UpdateProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyProdType{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyProdType">
    <p>
        Update Product</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        Product Type ID:<asp:TextBox ID="BoxTypeID" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must be filled" ControlToValidate="BoxTypeID"></asp:RequiredFieldValidator>
        <asp:Label ID="LabelID" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
    </p>
        </div>
</asp:Content>
