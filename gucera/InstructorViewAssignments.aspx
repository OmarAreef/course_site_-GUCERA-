﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorViewAssignments.aspx.cs" Inherits="GUCera.InstructorViewAssignments" %>

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
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" />
        </div>
    </form>
</body>
</html>
