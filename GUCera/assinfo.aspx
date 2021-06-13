<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assinfo.aspx.cs" Inherits="GUCera.assinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>GUCera</title>
      <style type="text/css">
          .center-text {
            text-align:center;
        }
            .label {
            text-align:center;
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <h1 class="center-text"> GUCera</h1>
               <hr/>

            <asp:Button ID="Button2" runat="server" Text="HomePage" OnClick="Button2_Click" />
        <br />

            Course ID:
            <asp:Label ID="courseid" runat="server" Text="courseid"></asp:Label>
            <br />
             Assignment Type:
             <asp:Label ID="at" runat="server" Text="assignment type"></asp:Label>
            <br />
            Assignment Number:
            <asp:Label ID="an" runat="server" Text="assignment number"></asp:Label>
            <br />
            Deadline:
             <asp:Label ID="dl" runat="server" Text="deadline"></asp:Label>
            <br />
            Weight:
             <asp:Label ID="w" runat="server" Text="weight"></asp:Label>
            <br />
            Full Grade:
             <asp:Label ID="fg" runat="server" Text="fullgrade"></asp:Label>
            <br /> 
            Content:
             <asp:Label ID="c" runat="server" Text="content"></asp:Label>
            <br /> 
                My Grade:
        <asp:Label ID="gg" runat="server" Text=" "></asp:Label>
           <br /> 

        <asp:Button ID="Button1" runat="server" Text="Submit Assignment" OnClick="Button1_Click" />

        <asp:Label CssClass="label" ID="Label2" runat="server" Text=" "></asp:Label>

        <br />


    </form>
</body>
</html>
