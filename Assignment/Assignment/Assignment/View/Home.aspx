<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .BodyHome{
            margin-left:15px
        }
       .BtnNav{
           margin-left:10px;
           }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BodyHome">
    <br />
<asp:Button ID="BtnViewProduct" runat="server" Text="View Product" Width="9%" Height="29px" OnClick="BtnViewProduct_Click" />
 
    <asp:Button ID="BtnViewProfile" runat="server" Text="View Profile" Height="29px" style="margin-top: 6px" Width="9%" OnClick="BtnViewProfile_Click" CssClass="BtnNav"/>
 
    <asp:Button ID="BtnViewUser" runat="server" Text="View User" Width="9%" Height="29px" OnClick="BtnViewUser_Click" CssClass="BtnNav"/>
    <asp:Button ID="BtnInsertProduct" runat="server" Text="Insert Product" Width="10%" Height="29px" OnClick="BtnInsertProduct_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnUpdateProduct" runat="server" Text="Update Product" Width="10%" Height="29px" OnClick="BtnUpdateProduct_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnViewProductType" runat="server" Text="View Product Type" Width="12%" Height="29px" OnClick="BtnViewProductType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnInsertProductType" runat="server" Text="Insert Product Type" Width="12%" Height="29px" OnClick="BtnInsertProductType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnUpdateProductType" runat="server" Text="Update Product Type" Width="13%" Height="29px" OnClick="BtnUpdateProductType_Click" CssClass="BtnNav" />
 
    <br />
 
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    
    </div>
</asp:Content>
