using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Images : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.ImageUrl = "http://s90.youtaker.com/other/2014/9-24/oth7833883065b6adba528e642fd9ee3ae7983aefaf30900.jpg";
        Image1.Width = Unit.Pixel(100);
        Image1.Height = Unit.Pixel(100);
    }
}