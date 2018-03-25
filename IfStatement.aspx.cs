using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IfStatement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        int source = 0;
        bool result;

        if (!string.IsNullOrEmpty(txtSource.Text))
        {
            result = int.TryParse(txtSource.Text, out source);

            if (result)
            {
                if (source >= 60)
                {
                    txtMsg.Text = "合格!";
                    txtMsg.BackColor = Color.Aqua;
                }
                else
                {
                    txtMsg.Text = "不合格!";
                    txtMsg.BackColor = Color.Red;
                }
            }
            else
            {
                Response.Write("<script>alert('成績限輸入阿拉伯數字，不得為英文字母或其他符號!')</script>");
            }
        }
        else 
        {
            Response.Write("<script>alert('不得為空白!')</script>");
        }
    }
}