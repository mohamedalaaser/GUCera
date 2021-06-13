<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorFeedbackandViewAssignments.aspx.cs" Inherits="GUCera.instructorFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Feedback and Viewing Assignments <p>
            Instructor Id
            <asp:TextBox ID="instructorId" runat="server"></asp:TextBox>
        </p>
        Course Id
        <asp:TextBox ID="courseId" runat="server" OnTextChanged="courseId_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="viewFeedback" runat="server" OnClick="Button1_Click" Text="View Feedback" />
        </p>
        <asp:Button ID="viewAssignments" runat="server" Text="View Assignments Submitted" OnClick="viewAssignments_Click" />
    </form>
</body>
</html>
