<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyWebForm.aspx.cs" Inherits="MyWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtInput" runat="server" Width="300"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="確定" Width="80" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
