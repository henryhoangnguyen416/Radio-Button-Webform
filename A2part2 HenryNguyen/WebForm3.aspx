<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="A2part2_HenryNguyen.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Recommendations</h2></div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">Click here to choose another language</asp:HyperLink>
    </form>
</body>
</html>
