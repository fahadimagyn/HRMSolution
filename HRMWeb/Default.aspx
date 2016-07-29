<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HRMWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="designation" runat="server" BackColor="#33CCFF" Height="59px">
            <asp:Label ID="companyName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="user" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="desg" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <asp:Menu ID="mymenu"  runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" Height="36px" Orientation="Horizontal" StaticSubMenuIndent="10px" CssClass="menu">
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#E3EAEB" />
            <DynamicSelectedStyle BackColor="#1C5E55" />
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#1C5E55" />
        </asp:Menu>
    </form>
</body>
</html>
