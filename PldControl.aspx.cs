using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PldControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AddControls();
    }
    protected void AddControls()
    {
        Label capName = new Label();
        capName.Text = "姓名";

        TextBox txtName = new TextBox();
        txtName.ID = "UserName";

        PlaceHolder1.Controls.Add(capName);
        PlaceHolder1.Controls.Add(txtName);
        PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));

        Button btnOK = new Button();
        btnOK.Text = "確定";

        PlaceHolder1.Controls.Add(btnOK);
        PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));

        btnOK.Click += btnOK_Click;
    }

    void btnOK_Click(object sender, EventArgs e)
    {
        Label txtMsg = new Label();
        txtMsg.Text = "<br/>你輸入的個人資料是:<br/>";
        txtMsg.Text += ((TextBox)form1.FindControl("UserName")).Text + "<br/>";
        PlaceHolder1.Controls.Add(txtMsg);
    }
}