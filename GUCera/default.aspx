<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GUCera._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera</title>
      <style type="text/css">


          .center-text {
            text-align:center;
        }
         .center-button {
          width:15%;
          height:6vh;
            margin:0 auto;
        }



    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1 class="center-text"> GUCera</h1>
               <hr/>
             <br />
             <br />

            <div class="center-button"> <asp:Button ID="LoginButton" runat="server" Text="Login" Width="100%"  height="100%" OnClick="LoginButton_Click" /></div>
           
            <br />
            <div class="center-button"><asp:Button ID="RegisterButton" runat="server" Text="Sign Up"  Width="100%" OnClick="RegisterButton_Click" Height="100%" /></div>
            

        </div>
    </form>
</body>
</html>
