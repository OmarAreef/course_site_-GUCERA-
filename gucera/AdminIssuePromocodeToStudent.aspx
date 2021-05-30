<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIssuePromocodeToStudent.aspx.cs" Inherits="GUCera.AdminIssuePromocodeToStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID:<br />
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
            <br />
            Promocode ID:<br />
            <asp:TextBox ID="PromocodeID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" />
            <br />
        </div>
    </form>
</body>
</html>
