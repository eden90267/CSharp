<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InputData.aspx.cs" Inherits="InputData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="btnOk" runat="server" Text="Button" OnClick="btnOk_Click" />
    </div>
    </form>
</body>
</html>
