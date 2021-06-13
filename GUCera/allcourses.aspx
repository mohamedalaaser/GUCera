<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allcourses.aspx.cs" Inherits="GUCera.allcourses" %>

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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="HomePage" />
        <br />
         <br />
         <br />
        Courses:
    </form>
</body>
</html>
