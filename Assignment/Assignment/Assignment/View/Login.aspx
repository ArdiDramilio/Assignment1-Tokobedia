<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .DivLogin{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="DivLogin">
    <p class="auto-style1">Login</p>
    Email:<asp:TextBox ID="EmailLogin" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="EmailLogin" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailLogin" ErrorMessage="Wrong Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelLoginEmail" runat="server"></asp:Label>
    <br />
    Password<asp:TextBox ID="PasswordLogin" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordLogin" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
    <asp:Label ID="LabelLoginPassword" runat="server"></asp:Label>
    <br />
    <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />
        <br />
        <asp:Label ID="LabelBlocked" runat="server"></asp:Label>
    <br />
     <asp:Button ID="BtnRegister" runat="server"  Onclick="BtnRegister_Click" CssClass="SBtnRegister" Text="Register" CausesValidation="False" />
    <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" CssClass="SBtnLogin" />
        </div>
</asp:Content>
