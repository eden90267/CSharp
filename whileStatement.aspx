<%@ Page Language="C#" AutoEventWireup="true" CodeFile="whileStatement.aspx.cs" Inherits="whileStatement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>while 陳述式的應用</h1>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="dwnHeight" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dwnHeight_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <asp:Label ID="txtMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
