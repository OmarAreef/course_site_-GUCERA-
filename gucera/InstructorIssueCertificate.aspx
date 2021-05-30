<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorIssueCertificate.aspx.cs" Inherits="GUCera.InstructorIssueCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            Course ID:<br />
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            Student ID:<br />
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
            <br />
           
            Issue Date:<br />
            <asp:TextBox ID="IssueDate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" />
            <br />
        </div>
    </form>
</body>
</html>
