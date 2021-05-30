<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssignments.aspx.cs" Inherits="GUCera.viewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Course ID:<br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewAssignmnets" runat="server" Text="view assignments" OnClick="viewAssignmnets_Click" />
            <br />
        </div>
    </form>
</body>
</html>
