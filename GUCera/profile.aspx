<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="GUCera.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1181px;
            height: 418px;
            direction: ltr;
        }
    </style>
</head>
<body style="height: 646px">
    <form id="myprofile" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="HomePage" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="fname" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="lname" runat="server" Text="Label"></asp:Label>
        <p>
        <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="address" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Gpa" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="cardnumber" runat="server" Text="card number"></asp:Label>
        <br />
        <asp:TextBox ID="cardnum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="cardname" runat="server" Text="Card Holder Name"></asp:Label>
        <br />
        <asp:TextBox ID="cardHname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="cc" runat="server" Text="CCV"></asp:Label>
        <br />
        <asp:TextBox ID="ccv" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="exdate" runat="server" Text="Expiry Date"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        <br />
        <br />
        <asp:Button ID="CreditCard" runat="server" Text="Add Card" OnClick="CreditCard_Click" />

        <br />
        <br />
        <br />
        <asp:Label ID="PhoneNum" runat="server" Text="Phone Number"></asp:Label>
        <br />
        <br />

        <asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>

        <br />

        <br />
        <asp:Button ID="NUM" runat="server" Text="Add Phone Number" OnClick="NUM_Click" />

        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Promocodes" OnClick="Button1_Click" />

    </form>
</body>
</html>
