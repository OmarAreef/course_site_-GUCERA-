<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePromocode.aspx.cs" Inherits="GUCera.CreatePromocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Code:<br />
            <asp:TextBox ID="Code" runat="server"></asp:TextBox>
            <br />
            Issue Date:<br />
            <asp:TextBox ID="IssueDate" runat="server"></asp:TextBox>
            <br />
            Expiry Date:<br />
            <asp:TextBox ID="ExpiryDate" runat="server"></asp:TextBox>
            <br />
            Discount:<br />
            <asp:TextBox ID="Discount" runat="server"></asp:TextBox>
            <br />
           
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" />
            <br />
        </div>
    </form>
</body>
</html>
