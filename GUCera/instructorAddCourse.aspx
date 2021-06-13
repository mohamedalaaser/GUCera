<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorAddCourse.aspx.cs" Inherits="GUCera.instructorAddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Add&nbsp; New Course<p>
            CreditHours
            <asp:TextBox ID="creditHours" runat="server"></asp:TextBox>
        </p>
        Course Name
        <asp:TextBox ID="courseName" runat="server"></asp:TextBox>
        <p>
            Price
            <asp:TextBox ID="price" runat="server"></asp:TextBox>
        </p>
        Instructor ID
        <asp:TextBox ID="instructorId" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="addCourse" runat="server" Text="Add Course" OnClick="addCourse_Click" />
        </p>
    </form>
</body>
</html>
