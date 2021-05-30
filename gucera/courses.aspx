<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courses.aspx.cs" Inherits="GUCera.couses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 326px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        course name:<br />
        <asp:TextBox ID="courseName" runat="server"></asp:TextBox>
        <br />
        credit hours:<br />
        <asp:TextBox ID="creditHour" runat="server"></asp:TextBox>
        <br />
        price:<br />
        <asp:TextBox ID="Price" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addCourse" runat="server" Text="Add course" OnClick="addCourse_Click" />
    </form>
</body>
</html>
