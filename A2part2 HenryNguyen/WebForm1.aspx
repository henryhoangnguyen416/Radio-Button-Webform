<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="A2part2_HenryNguyen.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select a programming language:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Visual Basic 2008</asp:ListItem>
                <asp:ListItem>Visual C# 2008</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>C++</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <asp:Button ID="submitbtn" runat="server" OnClick="submitbtn_Click" Text="Submit" />
    </form>
</body>
</html>
