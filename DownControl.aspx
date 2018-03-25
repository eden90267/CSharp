<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DownControl.aspx.cs" Inherits="DownControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="dwnRegion" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dwnRegion_SelectedIndexChanged">
            <asp:ListItem Selected="True" Value="0">--請選擇居住地區--</asp:ListItem>
            <asp:ListItem Value="1">美國</asp:ListItem>
            <asp:ListItem Value="2">大陸</asp:ListItem>
            <asp:ListItem Value="3">台灣</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="dwnCity" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="dwnCity_SelectedIndexChanged"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
