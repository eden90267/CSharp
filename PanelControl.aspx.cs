using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PanelControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        TextBox t1 = new TextBox();
        t1.Text = "動態加入第一個 TextBox";
        t1.BackColor = Color.LightBlue;

        Panel1.Controls.Add(t1);
    }
}