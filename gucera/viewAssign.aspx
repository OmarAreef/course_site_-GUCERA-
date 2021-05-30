<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssign.aspx.cs" Inherits="gucera.viewAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID:<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="view" runat="server" Text="View Assignments" OnClick="view_Click" />
        </div>
    </form>
</body>
</html>
