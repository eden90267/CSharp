<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rdoDegree.aspx.cs" Inherits="rdoDegress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rdoSenior" runat="server" Text="高中" GroupName="Degree" />
        <asp:RadioButton ID="rdoUniversity" runat="server" Text="大學/專科" GroupName="Degree" />
        <asp:RadioButton ID="rdoMaster" runat="server" Text="碩士" GroupName="Degree" />
        <asp:RadioButton ID="rdoDoctor" runat="server" Text="博士" GroupName="Degree" />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="確定" OnClick="btnOK_Click" />
        <br />
        <asp:Label ID="txtMsg" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
