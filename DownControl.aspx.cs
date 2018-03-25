using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DownControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void dwnRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        dwnCity.Items.Clear();

        switch (dwnRegion.SelectedValue)
        {
            case "0":
                dwnCity.Items.Add(new ListItem("==請選擇城市==", "0"));
                dwnCity.Enabled = false;
                break;
            case "1":
                dwnCity.Items.Add(new ListItem("==請選擇城市==", "0"));
                dwnCity.Items.Add(new ListItem("紐約", "1"));
                dwnCity.Items.Add(new ListItem("芝加哥", "2"));
                dwnCity.Items.Add(new ListItem("拉斯維加斯", "3"));
                dwnCity.Enabled = true;
                break;
            case "2":
                break;
            case "3":
                break;
        }
    }
    protected void dwnCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(string.Format("你居住的地點為{0}，{1}", dwnRegion.SelectedItem.Text, dwnCity.SelectedItem.Text));
    }
}