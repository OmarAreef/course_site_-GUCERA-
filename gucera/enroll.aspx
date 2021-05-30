<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="enroll.aspx.cs" Inherits="gucera.enroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter the Course ID to View its information and then you can enroll in it<br />
            <br />
            Course ID:<br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="view" runat="server" Text="View Course" OnClick="view_Click" />
        </div>
         <div>
            <asp:Button ID="enrollin" runat="server" Text="Choose the instructor to enroll with" Visible ="false" OnClick="enrollin_Click" />
        </div>
    </form>
    
       
   
</body>
</html>
