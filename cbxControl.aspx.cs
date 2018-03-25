using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ctxControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        lblMsg.Text = "";
        for (int i = 0; i < cbxHabits.Items.Count; i++)
        {
            if (cbxHabits.Items[i].Selected)
            {
                lblMsg.Text += cbxHabits.Items[i].Text + "<br/>";
            }
        }
    }
}