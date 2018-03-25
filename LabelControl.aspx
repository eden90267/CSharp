<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LabelControl.aspx.cs" Inherits="LabelControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <asp:Label ID="txtInfo" runat="server" Text="這是 Label 控制項" ToolTip="Hello...Label控制項" BackColor="#FFFF99" ForeColor="Blue" Font-Names="標楷體"></asp:Label>
        <asp:Label ID="txtPrg" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
