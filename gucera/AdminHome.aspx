<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="gucera.AdminHome" %>

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
            <asp:Button ID="allCourses" runat="server" Text="List All Courses" OnClick="allCourses_Click" />
            <asp:Button ID="nonCourses" runat="server" style="margin-left: 45px" Text="List Non Accepted Courses" OnClick="nonCourses_Click" />
            <br />
            <asp:Button ID="accCourse" runat="server" style="margin-top: 50px" Text="Accept Course" OnClick="accCourse_Click" />
            <asp:Button ID="createPromo" runat="server" style="margin-left: 45px" Text="Create PromoCode" OnClick="createPromo_Click" />
            <asp:Button ID="issuePromo" runat="server" style="margin-left: 45px" Text="Issue PromoCode" OnClick="issuePromo_Click" />
        </div>
    </form>
</body>
</html>
