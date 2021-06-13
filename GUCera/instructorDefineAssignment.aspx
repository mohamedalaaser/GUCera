<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorDefineAssignment.aspx.cs" Inherits="GUCera.instructorDefineAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Define Assignment to Students</div>
        <p>
            Instructor Id
            <asp:TextBox ID="instructorId" runat="server"></asp:TextBox>
        </p>
        <p>
            Course Id
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox>
        </p>
        <p>
            Assignment Number
            <asp:TextBox ID="assignmentNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            Assignment Type
            <asp:TextBox ID="assignmentType" runat="server"></asp:TextBox>
        </p>
        <p>
            Full Grade
            <asp:TextBox ID="assignmentFullgrade" runat="server"></asp:TextBox>
        </p>
        <p>
            Weight&nbsp;
            <asp:TextBox ID="assignmentWeight" runat="server"></asp:TextBox>
        </p>
        <p>
            Deadline
            <asp:Calendar ID="deadline" runat="server" style="margin-top: 12px"></asp:Calendar>
        </p>
        Content
        <asp:TextBox ID="assignmentContent" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="defineAssignment" runat="server" Text="Define Assignment" OnClick="defineAssignment_Click" />
        </p>
    </form>
</body>
</html>
