<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HRMWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link rel="stylesheet" href="css/StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        
            <asp:Label ID="companyName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="user" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="desg" runat="server" Text="Label"></asp:Label>
        
        <div >
        <asp:Panel ID="p2" runat="server" BackColor="#F7F6F3" Height="36px" CssClass="panel" >
        <asp:Menu ID="mymenu" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px" BorderStyle="Solid" BorderColor="Black" Height="32px">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
        </asp:Panel>
        </div>
    </form>
</body>
</html>
