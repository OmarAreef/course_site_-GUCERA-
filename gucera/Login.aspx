<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="gucera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 210px">
    <form id="form1" runat="server">
        <br />
        Username<br />
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="submit" runat="server" Text="Log In" OnClick="login" />
        <br />
        <br />
        <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <asp:Button ID="number" runat="server" Text="Add Telephone number" OnClick="number_Click" />
        <br />
        <br />
    </form>
</body>
</html>
