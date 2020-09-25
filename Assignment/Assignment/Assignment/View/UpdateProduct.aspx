<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="Assignment.View.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .BodyProd{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyProd">

    
    <p>
        Update Product</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        Product ID:<asp:TextBox ID="BoxProductID" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must be filled" ControlToValidate="BoxProductID"></asp:RequiredFieldValidator>
        <asp:Label ID="LabelID" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"/>
    </p>
        </div>
</asp:Content>
