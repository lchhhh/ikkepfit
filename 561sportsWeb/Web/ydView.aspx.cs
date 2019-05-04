using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class about  : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowInfo();
        }
    }

    //≥ı ºªØ
    private void ShowInfo()
    {
        if (Request.QueryString["id"] != null)
        {
            SP.BLL.equip bll = new SP.BLL.equip();
            SP.Model.equip model = bll.GetModel(int.Parse(Request.QueryString["id"]));

            this.lbltitle.Text = model.title;
            imgpic.ImageUrl = "uploads/" + model.pic;
            this.lblmemo.Text = model.memo;
            this.lblatime.Text = model.atime.ToString();
        }
    }
}
