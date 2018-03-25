using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class whileStatement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dwnHeight.Items.Add("==請選擇身高==");
            int i = 160;
            while (i <= 185)
            {
                dwnHeight.Items.Add(i.ToString() + "cm");
                i++;
            }
        }
    }
    protected void dwnHeight_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dwnHeight.SelectedItem.Text != "==請選擇身高==")
        {
            txtMsg.Text = "您的身高為:" + dwnHeight.SelectedItem.Text;
        }
        else
        {
            txtMsg.Text = "";
        }
    }
}