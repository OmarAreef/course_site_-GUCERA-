<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addNumber.aspx.cs" Inherits="gucera.addNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            please enter the mobile number you wish to submit<br />
            <br />
            UserID:<br />
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <br />
            Mobile Number:<br />
            <asp:TextBox ID="mob" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addMobile" runat="server" Text="Submit" OnClick="addMobile_Click" />
        </div>
    </form>
</body>
</html>
