using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class rdoDegress : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        txtMsg.Text = "";
        txtMsg.Text = (rdoSenior.Checked) ? "你的最高學歷為:" + rdoSenior.Text : "";
        txtMsg.Text = (String.IsNullOrEmpty(txtMsg.Text) && rdoUniversity.Checked) ? "你的最高學歷為:" + rdoUniversity.Text : "";
        txtMsg.Text = (String.IsNullOrEmpty(txtMsg.Text) && rdoMaster.Checked) ? "你的最高學歷為:" + rdoMaster.Text : "";
        txtMsg.Text = (String.IsNullOrEmpty(txtMsg.Text) && rdoDoctor.Checked) ? "你的最高學歷為:" + rdoDoctor.Text : "";
        txtMsg.Text = String.IsNullOrEmpty(txtMsg.Text) ? "請至少選擇一個學歷!" : "";
    }
}