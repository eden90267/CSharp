using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SwitchCase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void dwnJob_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (dwnJob.SelectedItem.Value)
        {
            case "1":
                txtSalary.Text = "每月薪資 100,000 元";
                break;
            case "2":
                txtSalary.Text = "每月薪資 60,000 元";
                break;
            case "3":
                txtSalary.Text = "每月薪資 35,000 元";
                break;
            case "4":
                txtSalary.Text = "每月薪資 20,000 元";
                break;
            default:
                txtSalary.Text = "";
                break;
        }
    }
}