<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminaccept.aspx.cs" Inherits="GUCera.adminaccept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Accept Course:id
        </p>
        <p>
        <asp:TextBox ID="CourseID" runat="server" OnTextChanged="TextBox1_TextChanged" style="height: 25px"></asp:TextBox>
            <asp:Button ID="acceptcourse" runat="server" Text="Accept" OnClick="acceptcourse_Click" />
        </p>
        <p>
            Pending Courses</p>
    </form>
</body>
</html>
