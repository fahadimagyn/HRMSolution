<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="HRMWeb.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/style.css"/>
</head>
<body>
<div id="content" class="container" >
    <form id="form1" runat="server">
    
     
          
                                         <div class="TextBox" >
                                        <h1>Login Form</h1>
                            
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                             <asp:TextBox ID="UserName" runat="server" OnTextChanged="UserName_TextChanged1"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                            ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                            ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                             <br />
                                
                                        <br />
                                
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                    &nbsp;<asp:TextBox ID="Password" runat="server" TextMode="Password" OnTextChanged="Password_TextChanged"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                            ControlToValidate="Password" ErrorMessage="Password is required." 
                                            ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                  
                                        <br />
                                  
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                   
                                        <br />
                                   
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    
                                        <asp:Button ID="LoginButton" runat="server" 
                                            onclick="LoginButton_Click" Text="Log In" ValidationGroup="Login1" class="button"/>
                                    
       
                                             
                                    
       
                                        </div>
    </form>
     </div>
</body>

</html>
