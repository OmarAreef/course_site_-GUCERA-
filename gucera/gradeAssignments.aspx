<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gradeAssignments.aspx.cs" Inherits="GUCera.gradeAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br />
            Student ID:<br />
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
            <br />
            Course ID:<br />
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            Assignment Number:<br />
            <asp:TextBox ID="AssignmentNumber" runat="server"></asp:TextBox>
            <br />
            Type:<br />
             <asp:DropDownList ID="Type" runat="server">
                <asp:ListItem>quiz</asp:ListItem>
                <asp:ListItem>exam</asp:ListItem>
                <asp:ListItem>project</asp:ListItem>
            </asp:DropDownList>
            <br />
            Grade:<br />
            <asp:TextBox ID="Grade" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" />
            <br />
        </div>
    </form>
</body>
</html>
