<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    public string getTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Inline Code範例</h2>
    <div>
    現在伺服器時間是:<% =getTime() %>
    </div>
    </form>
</body>
</html>
