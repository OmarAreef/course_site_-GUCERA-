<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="subAssignment.aspx.cs" Inherits="gucera.subAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Assignment details
            <br />
            <br />
            Assignment Number:<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
            <br />
            <br />
            Course ID:<br />
            <asp:TextBox ID="coureseID" runat="server"></asp:TextBox>
            <br />
            <br />
            Assignment Type:<br />
            <asp:DropDownList ID="type" runat="server">
                <asp:ListItem>quiz</asp:ListItem>
                <asp:ListItem>exam</asp:ListItem>
                <asp:ListItem>project</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="sub" runat="server" Text="Submit Assign" OnClick="sub_Click"  />
        </div>
    </form>
</body>
</html>
