<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="Assignment.View.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyViewUs{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyViewUs">

    
    <p>
        View User</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BtnChangeRole" runat="server" Text="Change User Role" OnClick="BtnChangeRole_Click" />
        <asp:Button runat="server" Text="Change User Status" ID="BtnChangeStatus" OnClick="BtnChangeStatus_Click" />
    </p>
    
    <p>
        <asp:Label ID="ValidatorUserID" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelUserID" runat="server" Text="User ID:"></asp:Label>
        <asp:TextBox ID="IDChangeRole" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelNewUserRole" runat="server" Text="New User Role:"></asp:Label>
        <asp:TextBox ID="IDNewRole" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnSubmitUpdateRole" runat="server" Text="Submit" OnClick="BtnSubmitUpdateRole_Click" />
    </p>
    <p>
        <asp:Button ID="BtnToggle" runat="server" Text="Toggle Status" OnClick="BtnToggle_Click" />
    </p>
        </div>
</asp:Content>
