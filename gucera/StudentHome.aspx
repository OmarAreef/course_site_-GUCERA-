<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="gucera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to your Home Page<br />
            <br />
            <br />
            <asp:Button ID="viewProfile" runat="server" Text="View my Profile" Width="172px" OnClick="viewProfile_Click" />
        &nbsp;<asp:Button ID="listCourses" runat="server" Text="View Available Courses" style="margin-left: 45px" OnClick="listCourses_Click" />
            <asp:Button ID="addCredit" runat="server" Text="Add Credit Card" style="margin-left: 45px" OnClick="addCredit_Click" />
            <asp:Button ID="viewPromoCodes" runat="server" style="margin-left: 45px" Text="View My PromoCodes" OnClick="viewPromoCodes_Click" />
            <br />
            <asp:Button ID="viewAssign" runat="server" style="margin-top: 50px" Text="View Assignments" OnClick="viewAssign_Click" />
            <asp:Button ID="addFeedback" runat="server" style="margin-left: 45px" Text="add Feedback" OnClick="addFeedback_Click" />
            <asp:Button ID="listCertificates" runat="server" style="margin-left: 45px" Text="List my Certificates" OnClick="listCertificates_Click" />
            <asp:Button ID="viewGrades" runat="server" Text="View Grades" style="margin-left: 45px" OnClick="viewGrades_Click" />
            <asp:Button ID="subAssignment" runat="server" Text="Submit asssignment" style="margin-left: 45px" OnClick="subAssignment_Click" Width="219px" />
            <br />
            <asp:Button ID="enroll" runat="server" style="margin-left: 400px; margin-top: 50px;" Text="Enroll In a Course" OnClick="enroll_Click" />
            <br />
        </div>
    </form>
</body>
</html>
