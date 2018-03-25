using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BrowserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpBrowserCapabilities browser = Request.Browser;

        StringBuilder info = new StringBuilder();
        info.Append("<ul>");
        info.Append(string.Format("<li>名稱:{0}</li>", browser.Browser));
        info.Append(string.Format("<li>版本:{0}</li>", browser.Version));
        info.Append(string.Format("<li>ECMAScrpt 版本:{0}</li>", browser.EcmaScriptVersion));
        info.Append("</ul>");
        txtInfo.Text = info.ToString();
    }
}