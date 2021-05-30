<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defineAssignments.aspx.cs" Inherits="GUCera.defineAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            Course ID:<br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            Number:<br />
            <asp:TextBox ID="Number" runat="server"></asp:TextBox>
            <br />
            Type:<br />
             <asp:DropDownList ID="Type" runat="server">
                <asp:ListItem>quiz</asp:ListItem>
                <asp:ListItem>exam</asp:ListItem>
                <asp:ListItem>project</asp:ListItem>
            </asp:DropDownList>
            <br />
            Full Grade:<br />
            <asp:TextBox ID="FullGrade" runat="server"></asp:TextBox>
            <br />
            Weight:<br />
            <asp:TextBox ID="Weight" runat="server"></asp:TextBox>
            <br />
            Deadline:<br />
            <asp:TextBox ID="Deadline" runat="server"></asp:TextBox>
            <br />
            Content:<br />
            <asp:TextBox ID="Content" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="defineAssignment" runat="server" Text="Define" OnClick="defineAssignment_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
