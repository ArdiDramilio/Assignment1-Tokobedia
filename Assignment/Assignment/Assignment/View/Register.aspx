<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .DivRegis{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="DivRegis">
    <div runat="server" >
    <p>
        Register</p>
    <p>
        Email:<asp:TextBox ID="RegisEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RegisEmail" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="RegisEmail" ErrorMessage="Wrong Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelEmail" runat="server"></asp:Label>
    </p>
    <p>
        Name:<asp:TextBox ID="RegisNama" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RegisNama" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
    </p>
    <p>
        Password:<asp:TextBox ID="RegisPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="RegisPassword" ErrorMessage="Must Be Filled"></asp:RequiredFieldValidator>
    </p>
    <p>
        Confirm Password:<asp:TextBox ID="ConfirmPass" TextMode="Password" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="RegisPassword" ControlToValidate="ConfirmPass" ErrorMessage="Password not Same"></asp:CompareValidator>
</p>
    <p>
        Gender:<asp:RadioButtonList ID="RegisGender" runat="server">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RegisGender" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
</p>
<p>
        <asp:Button ID="Button1" runat="server" OnClick="BtnInsertRegister" Text="Submit" />
</p>
        </div>
        </div>
</asp:Content>
