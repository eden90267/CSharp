<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rdoBloodType.aspx.cs" Inherits="rdoBloodType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>請選擇血型</h2>
        <asp:RadioButtonList ID="rdoBlood" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rdoBlood_SelectedIndexChanged">
            <asp:ListItem>A型</asp:ListItem>
            <asp:ListItem>B型</asp:ListItem>
            <asp:ListItem>O型</asp:ListItem>
            <asp:ListItem>AB型</asp:ListItem>
            <asp:ListItem>RH型</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="txtMsg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
