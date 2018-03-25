using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class rdoBloodType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void rdoBlood_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMsg.Text = "你的血型:" + rdoBlood.SelectedItem.Text;
    }
}