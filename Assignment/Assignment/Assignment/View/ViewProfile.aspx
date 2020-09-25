<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Assignment.View.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyViewProfile{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyViewProfile">

    
    <p>
        Name :<asp:Label ID="LabelName" runat="server"></asp:Label>
    </p>
    <p>
        Email:<asp:Label ID="LabelEmail" runat="server"></asp:Label>
    </p>
    <p>
        Gender:<asp:Label ID="LabelGender" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnUpdateProfile" runat="server" Text="Update Profile" OnClick="BtnUpdateProfile_Click" />
        <asp:Button ID="BtnUpdatePassword" runat="server" Text="Update Password" OnClick="BtnUpdatePassword_Click" />
    </p>
        </div>
</asp:Content>
