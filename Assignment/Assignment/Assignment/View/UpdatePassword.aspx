<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="Assignment.View.UpdatePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .BodyUpdPass{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <div class="BodyUpdPass">

      
    <p>
        Update Password</p>
    <p>
        Old Password:<asp:TextBox ID="UpdateOldPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="LabelMatchPass" runat="server"></asp:Label>
    </p>
    <p>
        New Password:<asp:TextBox ID="UpdateNewPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RegularExpressionValidator ControlToValidate = "UpdateNewPassword" ID="RegularExpressionValidator2" ValidationExpression = "^[\s\S]{5,}$" runat="server" ErrorMessage="Must be longer than 5 character"></asp:RegularExpressionValidator>
    </p>
    <p>
        Confirm Password:<asp:TextBox ID="UpdateConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="UpdateNewPassword" ControlToValidate="UpdateConfirmPassword" ErrorMessage="Password not match"></asp:CompareValidator>
    </p>
    <p>
        <asp:Button ID="BtnUpdatePassword" runat="server" Text="Submit" OnClick="BtnUpdatePassword_Click" />
    </p>
            </div>
</asp:Content>
