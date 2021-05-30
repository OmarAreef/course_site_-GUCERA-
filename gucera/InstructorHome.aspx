<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorHome.aspx.cs" Inherits="gucera.InstructorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to your Home Page
            <br />
            <br />
            <br />
            <asp:Button ID="addCourse" runat="server" Text="AddNewCourse" OnClick="addCourse_Click" />
            <asp:Button ID="defAssign" runat="server" style="margin-left: 45px" Text="Define Assignments" OnClick="defAssign_Click" />
            <asp:Button ID="viewAssign" runat="server" style="margin-left: 45px" Text="View Assignments" OnClick="viewAssign_Click" />
            <br />
            <asp:Button ID="gradeAssign" runat="server" style="margin-top: 50px" Text="Grade Assignments" OnClick="gradeAssign_Click" />
            <asp:Button ID="viewFeed" runat="server" style="margin-left: 45px" Text="View Feedback" OnClick="viewFeed_Click" />
            <asp:Button ID="issueCert" runat="server" style="margin-left: 45px" Text="Issue Certificate" OnClick="issueCert_Click" />
        </div>
    </form>
</body>
</html>
