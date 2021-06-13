<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enrolledcourseinfo.aspx.cs" Inherits="GUCera.enrolledcourseinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera</title>
        <style type="text/css">
              .center-text {
            text-align:center;
        }
             .label {
            color:red;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h1 class="center-text"> GUCera</h1>
               <hr/>

            <asp:Button ID="Button1" runat="server" Text="HomePage" OnClick="Button1_Click" />
        <br />

            Course ID:
            <asp:Label ID="courseid" runat="server" Text="courseid"></asp:Label>
            <br />
             Credit hours:
             <asp:Label ID="ch" runat="server" Text="credit hours"></asp:Label>
            <br />
            Course Name:
            <asp:Label ID="cn" runat="server" Text="name"></asp:Label>
            <br />
             Description:
             <asp:Label ID="cd" runat="server" Text="description"></asp:Label>
            <br />
             Price:
             <asp:Label ID="p" runat="server" Text="price"></asp:Label>
            <br />
              Content:
             <asp:Label ID="con" runat="server" Text="content"></asp:Label>
            <br /> 
            <asp:Panel ID="Panel1" runat="server">Assignments: 
                <asp:Label ID="Label2" runat="server" Text="no assignments"></asp:Label>
            </asp:Panel>
            <br />
   

 
    </form>
</body>
</html>
