using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LBoxControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbxSource.Items.Add(new ListItem("CPU主機板", "0"));
            lbxSource.Items.Add(new ListItem("主機板"));
            lbxSource.Items.Add(new ListItem("記憶體"));
            lbxSource.Items.Add(new ListItem("顯示卡"));
            lbxSource.Items.Add(new ListItem("硬碟"));
            lbxSource.Items.Add(new ListItem("DVD 燒錄器"));
            lbxSource.Items.Add(new ListItem("滑鼠"));
            lbxSource.Items.Add(new ListItem("LCD 液晶螢幕"));
            lbxSource.Items.Add(new ListItem("電源延長線"));
            lbxSource.Items.Add(new ListItem("散熱風扇"));
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < lbxSource.Items.Count; i++)
        {
            if (lbxSource.Items[i].Selected)
            {
                lbxTarget.Items.Add(lbxSource.Items[i].Text);
                lbxSource.Items[i].Enabled = false;
            }
        }

        for (int i = lbxSource.Items.Count - 1; i >= 0; i--)
        {
            if (lbxSource.Items[i].Enabled == false)
            {
                lbxSource.Items.RemoveAt(i);
            }
        }
    }
    protected void btnAddAll_Click(object sender, EventArgs e)
    {
        if (lbxSource.Items.Count > 0)
        {
            for (int i = 0; i < lbxSource.Items.Count; i++)
                lbxTarget.Items.Add(lbxSource.Items[i].Text);
        }
        lbxSource.Items.Clear();
    }
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < lbxSource.Items.Count; i++)
        {
            if (lbxTarget.Items[i].Selected)
            {
                lbxSource.Items.Add(lbxTarget.Items[i].Text);
                lbxTarget.Items[i].Enabled = false;
            }
        }

        for (int i = lbxSource.Items.Count - 1; i >= 0; i--)
        {
            if (lbxTarget.Items[i].Enabled == false)
            {
                lbxTarget.Items.RemoveAt(i);
            }
        }
    }
    protected void btnRemoveAll_Click(object sender, EventArgs e)
    {
        if (lbxTarget.Items.Count > 0)
        {
            for (int i = 0; i < lbxTarget.Items.Count; i++)
                lbxSource.Items.Add(lbxTarget.Items[i].Text);
        }
        lbxTarget.Items.Clear();
    }
}