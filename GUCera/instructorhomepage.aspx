<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorhomepage.aspx.cs" Inherits="GUCera.instructorhomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Instructor Homepage<br />
            <br />
        </div>
        <asp:Button ID="addCourses" runat="server" Text="Add Courses To Teach" OnClick="addCourses_Click" />
        <p>
            <asp:Button ID="issueCertificate" runat="server" Text="Issue a Certificate to Student" OnClick="issueCertificate_Click" />
        </p>
        <p>
            <asp:Button ID="defineAssignment" runat="server" Text="Define Assignment" OnClick="defineAssignment_Click" />
        </p>
        <p>
            <asp:Button ID="viewFeedbackandAssignments" runat="server" Text="View Feedback and Assignments" OnClick="viewFeedbackandAssignments_Click" />
        </p>
        <p>
            <asp:Button ID="gradeAssignment" runat="server" Text="Grade Assignment" OnClick="gradeAssignment_Click" />
        </p>
    </form>
</body>
</html>
