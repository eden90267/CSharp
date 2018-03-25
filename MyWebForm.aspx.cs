﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyWebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string time = getTime();
        Response.Write("現在時間是:" + time + "<br/>");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Response.Write("您輸入的文字是:" + txtInput.Text);
    }
    protected string getTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
}