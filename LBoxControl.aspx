<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LBoxControl.aspx.cs" Inherits="LBoxControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lbxSource" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" Text=">" OnClick="btnAdd_Click" />
        <asp:Button ID="btnAddAll" runat="server" Text=">>" OnClick="btnAddAll_Click" />
        <asp:Button ID="btnRemove" runat="server" Text="<" OnClick="btnRemove_Click" />
        <asp:Button ID="btnRemoveAll" runat="server" Text="<<" OnClick="btnRemoveAll_Click" />
        <asp:ListBox ID="lbxTarget" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <br />
        <asp:Button ID="btnBuy" runat="server" Text="結帳" />
    </div>
    </form>
</body>
</html>
