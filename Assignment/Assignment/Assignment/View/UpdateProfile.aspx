<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Assignment.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyUpdProfile{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="BodyUpdProfile">

    
    <p>
         Update Profile</p>
     <p>
        Email:<asp:TextBox ID="UpdateEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="UpdateEmail" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UpdateEmail" ErrorMessage="Wrong Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelEmail" runat="server"></asp:Label>
    </p>
    <p>
        Name:<asp:TextBox ID="UpdateNama" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UpdateNama" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
    </p>
     <p>
        Gender:<asp:RadioButtonList ID="UpdateGender" runat="server">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="UpdateGender" ErrorMessage="Must be filled"></asp:RequiredFieldValidator>
</p>
     <p>
         <asp:Button ID="BtnUpdate" runat="server" Text="Submit" OnClick="BtnUpdate_Click" />
</p>
        </div> 
</asp:Content>
