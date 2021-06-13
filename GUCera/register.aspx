<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="GUCera.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera</title>
    <style type="text/css">

        .auto-style1 {
         width: 1px;
    white-space: nowrap;
        }
           .auto-style2 {
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
 
        <h1 class="center-text">GUCera</h1>
        <hr />
        

            <table class="auto-style2">
                <tr>
                    <td colspan="2"><h3 class="center-text">Sign Up</h3></td>
                </tr>
                <tr>
                    <td class="auto-style1"><span>I am</span></td>
                    <td class="auto-style1"><asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True" Value="2">a Student</asp:ListItem>
            <asp:ListItem Value="0">an Instructor</asp:ListItem>
        </asp:DropDownList></td>
                </tr>

                <tr>
                    <td class="auto-style1"><span> First name:</span></td>
                    <td class="auto-style1"><asp:TextBox ID="firstname"  runat="server" required="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><span>Last name:</span></td>
                    <td class="auto-style1"><asp:TextBox ID="lastname" runat="server" required="true"></asp:TextBox></td>
                </tr>

                <tr>
                    <td class="auto-style1"><span>Gender:</span></td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Selected="True" Value="0">Male</asp:ListItem>
            <asp:ListItem Value="1">Female</asp:ListItem>
        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><span>Email:</span></td>
                    <td class="auto-style1"><asp:TextBox ID="email" TextMode="Email" runat="server" required="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><span>Password:</span></td>
                    <td class="auto-style1"><asp:TextBox ID="password" TextMode="Password" runat="server" required="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><span>Address:</span></td>
                    <td class="auto-style1"><asp:TextBox ID="address" runat="server" required="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2"><div class="center-button"><asp:Button ID="signup" runat="server" Text="Sign Up" OnClick="signup_Click" Width="100%"/></div></td>
                </tr>
                    
            </table>
        <div class="label"><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></div>
        
        

     </form>
</body>
</html>
