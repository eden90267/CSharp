using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LabelControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Literal1.Text = "<h2>Label控制項建立與屬性設定</h2>";
            txtPrg.Font.Name = "標楷體";
            txtPrg.ForeColor = Color.Aqua;
        }
    }
}