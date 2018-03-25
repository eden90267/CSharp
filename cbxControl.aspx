<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cbxControl.aspx.cs" Inherits="ctxControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2 style="width: 300px; text-align: center">使用者興趣調查問卷</h2>
        <asp:CheckBoxList ID="cbxHabits" runat="server" RepeatColumns="2" Width="300px">
            <asp:ListItem>打球</asp:ListItem>
            <asp:ListItem>游泳</asp:ListItem>
            <asp:ListItem>唱歌</asp:ListItem>
            <asp:ListItem>慢跑</asp:ListItem>
            <asp:ListItem>看電影</asp:ListItem>
            <asp:ListItem>登山</asp:ListItem>
            <asp:ListItem>騎車</asp:ListItem>
            <asp:ListItem>下棋</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="btnOk" runat="server" Text="確定" OnClick="btnOk_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
