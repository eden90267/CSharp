<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IfStatement.aspx.cs" Inherits="IfStatement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtSource" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnOK" runat="server" Text="判斷成績是否合格" OnClick="btnOK_Click" />
        <br />
        <asp:Label ID="txtMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
