using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class nav : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            Repeater1.DataSource = new SP.BLL.plans().GetList(5, "", "pid desc");
            Repeater1.DataBind();

            Repeater2.DataSource = new SP.BLL.news().GetList(5, "", "nid desc");
            Repeater2.DataBind();

            Repeater3.DataSource = new SP.BLL.newsType().GetAllList();
            Repeater3.DataBind();
        }
    }
}