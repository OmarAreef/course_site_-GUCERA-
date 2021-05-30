<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addFeedback.aspx.cs" Inherits="gucera.addFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID:<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
            <br />
            <br />
            Comment:<br />
            <asp:TextBox ID="comm" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="sub" runat="server" style="margin-left: 47px" Text="Submit Comment" OnClick="sub_Click" />
        </div>
    </form>
</body>
</html>
