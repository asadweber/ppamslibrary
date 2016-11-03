<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="UI_BookCategory.aspx.cs" Inherits="PPAMS.WEB.UI.UI_BookCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="style1">
        <tr>
            <td>
                Name</td>
            <td>
                <asp:HiddenField ID="hhdId" runat="server" />
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
