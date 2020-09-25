<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="Assignment.View.ViewProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyViewProdTy{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyViewProdTy">
    <p>
        View Product Type</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BtnInsertProductType" runat="server" Text="Insert Product Type" OnClick="BtnInsertProductType_Click" />
        <asp:Button ID="BtnUpdateProductType" runat="server" Text="Update Product Type" OnClick="BtnUpdateProductType_Click"/>
        <asp:Button ID="BtnDeleteProductType" runat="server" Text="Delete Product Type" OnClick="BtnDeleteProductType_Click" />
    </p>
    <p>
        <asp:Label ID="LabelDelete" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelProductTypeID" runat="server" Text="Product Type ID:"></asp:Label>
        <asp:TextBox ID="BoxDeleteType" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click"/>
    </p>
        </div>
</asp:Content>
