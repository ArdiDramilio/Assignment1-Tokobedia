<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Assignment.View.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyViewProd{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyViewProd">

    
    <p>
        Product View<asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BtnInsertProduct" runat="server" Text="Insert Product" OnClick="BtnInsertProduct_Click" />
        <asp:Button ID="BtnUpdateProduct" runat="server" Text="Update Product" OnClick="BtnUpdateProduct_Click" />
        <asp:Button ID="BtnDeleteProduct" runat="server" Text="Delete Product"  OnClick="BtnDeleteProduct_Click"/>
    </p>
    <p>
        <asp:Label ID="LabelDelete" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelBox" runat="server" Text="Product ID:"></asp:Label>
        <asp:TextBox ID="BoxID" runat="server" Width="148px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
    </p>
        </div>
</asp:Content>
