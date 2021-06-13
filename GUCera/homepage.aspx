<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="GUCera.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera</title>
     <style type="text/css">


          .center-text {
            text-align:center;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">

         <h1 class="center-text"> GUCera</h1>
               <hr/>


            <asp:Button ID="profile" runat="server" Text="My Profile" OnClick="profile_Click" />
            <asp:Button ID="courses" runat="server" Text="View all courses" OnClick="courses_Click" />
            <asp:Button ID="Button1" runat="server" Text="Enrolled Courses" OnClick="my_courses_Click" />
            <asp:Button ID="Button2" runat="server" Text="My Certificates" OnClick="my_certificates_Click" />


    </form>
</body>
</html>
