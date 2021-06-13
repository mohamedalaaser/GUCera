<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courseinfo.aspx.cs" Inherits="GUCera.courseinfo" EnableViewState="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera</title>
        <style type="text/css">

             .label {
            color:red;
        }
                 .center-text {
            text-align:center;
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
            <br />
            <br />
            Pick Instructor:
            <asp:DropDownList ID="DropDownList1" runat="server">

            </asp:DropDownList>
            <br />
            <asp:Button ID="enroll" runat="server" Text="Enroll in Course" OnClick="enroll_Click" />
            <br />

         <div class="label"><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></div>

 
    </form>
</body>
</html>
