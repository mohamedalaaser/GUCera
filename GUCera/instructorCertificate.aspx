<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorCertificate.aspx.cs" Inherits="GUCera.instructorCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Issue a Certificate<br />
            <br />
        </div>
        Course id <asp:TextBox ID="courseId" runat="server"></asp:TextBox>
        <p>
            Student id
            <asp:TextBox ID="studentId" runat="server"></asp:TextBox>
        </p>
        <p>
            Instructor Id
            <asp:TextBox ID="instructorId" runat="server"></asp:TextBox>
        </p>
        <p>
            Issue date</p>
        <p>
            &nbsp;<asp:Calendar ID="issueDate" runat="server" OnSelectionChanged="issueDate_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="issueCertificate" runat="server" Text="Issue" OnClick="issueCertificate_Click" style="height: 35px" />
        </p>
    </form>
</body>
</html>
