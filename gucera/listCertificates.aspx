<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listCertificates.aspx.cs" Inherits="gucera.listCertificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter The Course ID which do you want to see the certificates of
            <br />
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="View" runat="server" Text="View Certificates" OnClick="View_Click" />
        </div>
    </form>
</body>
</html>
