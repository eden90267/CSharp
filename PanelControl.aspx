﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PanelControl.aspx.cs" Inherits="PanelControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>動態加入控制項到 Panel</h1>
        <asp:Panel ID="Panel1" runat="server" Width="450" Height="250"></asp:Panel>
        <asp:Button ID="btnAdd" runat="server" Text="加入控制項" OnClick="btnAdd_Click" />
    </div>
    </form>
</body>
</html>
