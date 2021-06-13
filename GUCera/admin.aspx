<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="GUCera.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Admin<p>
            <asp:Button ID="ViewCourse" runat="server" Text="View Courses" style="direction: ltr" OnClick="ViewCourse_Click" />
            <asp:Button ID="Button2" runat="server" Text="Issue Promocode" OnClick="Button2_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
