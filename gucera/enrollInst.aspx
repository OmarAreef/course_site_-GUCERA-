<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enrollInst.aspx.cs" Inherits="gucera.enrollInst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter the Instructor you want to enroll With<br />
            <br />
            Instructor ID:<br />
            <asp:TextBox ID="instructor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enroll" runat="server" Text="Enroll" OnClick="enroll_Click" />
        </div>
    </form>
</body>
</html>
