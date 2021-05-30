<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="gucera.studentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            please enter your details and password you want to register with<br />
            First Name:<br />
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <br />
            Last Name:<br />
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="pass" runat="server"></asp:TextBox>
            <br />
            Email:<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            Address:<br />
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
            <br />
            Gender:
            <br />
            <asp:DropDownList ID="gender" runat="server">
                <asp:ListItem Value="false">Male</asp:ListItem>
                <asp:ListItem Value="true">Female</asp:ListItem>
            </asp:DropDownList>
&nbsp;
            <br />
            Register As:<br />
            <asp:DropDownList ID="type" runat="server">
                <asp:ListItem Value="false">Instructor</asp:ListItem>
                <asp:ListItem Value="true">Student</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" />
            <br />
        </div>
    </form>
</body>
</html>
