<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SwitchCase.aspx.cs" Inherits="SwitchCase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>switch 陳述式的多重判斷</h1>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="dwnJob" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dwnJob_SelectedIndexChanged">
            <asp:ListItem Selected="True" Value="0">==請選擇職務==</asp:ListItem>
            <asp:ListItem Value="1">總經理</asp:ListItem>
            <asp:ListItem Value="2">經理</asp:ListItem>
            <asp:ListItem Value="3">工程師</asp:ListItem>
            <asp:ListItem Value="4">助理</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="txtSalary" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
