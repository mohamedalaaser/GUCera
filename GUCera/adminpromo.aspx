<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminpromo.aspx.cs" Inherits="GUCera.adminpromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CREATE NEW PROMOCODE<br />
            <br />
            Code </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        Issue Date<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        Expiry Date<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        <br />
        Discount<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="createpromo" runat="server" Text="Create" OnClick="createpromo_Click" style="height: 29px" />
        <br />
        <br />
        ISSUE TO A STUDENT<br />
        <br />
        Student ID<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Promocode</p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="issuestudent" runat="server" Text="Issue" OnClick="issuestudent_Click" />
    </form>
</body>
</html>
