<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorGradeAssignments.aspx.cs" Inherits="GUCera.instructorGradeAssignments" %>

<!DOCTYPE html>
                                                


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Grade the following assignment<br />
        <br />
        Instructor Id <asp:TextBox ID="instructorId" runat="server"></asp:TextBox>
        <p>
            Student Id <asp:TextBox ID="studentId" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            Course Id <asp:TextBox ID="courseId" runat="server"></asp:TextBox>
        </p>
        <p>
            Assignment Number <asp:TextBox ID="assignmentNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            Assignment Type <asp:TextBox ID="assignmentType" runat="server"></asp:TextBox>
        </p>
        <p>
            Grade
            <asp:TextBox ID="grade" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="gradeAssignment" runat="server" Text="Grade" OnClick="gradeAssignment_Click" />
        </p>
    </form>
</body>
</html>
