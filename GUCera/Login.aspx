<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera</title>
      <style type="text/css">

     .auto-style1 {
         width: 1px;
    white-space: nowrap;
        }
           .auto-style2{
               width: 20%;
            margin:0 auto;
        }

          .center-text {
            text-align:center;
        }
         .center-button {
          width:45%;
            margin:0 auto;
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
        <hr />
          

        <table class="auto-style2">
            <tr>
               <td colspan="2"><h3 class="center-text"> Login</h3></td>
            </tr>
            <tr>

                <td class="auto-style1"><span>Username</span></td>
                <td class=" auto-style1"> <asp:TextBox ID="username" runat="server" required="true"></asp:TextBox> </td>
            </tr>
            <tr>
                <td><span>Password</span></td>
                <td><asp:TextBox ID="password" runat="server" textmode="Password" required="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><div class="center-button"><asp:Button ID="Button1" runat="server" OnClick="LoginButton" Text="Login" Width="100%" /></div></td>
            </tr>
        </table>

        <div class="label"><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></div>

        


    </form>
</body>
</html>
