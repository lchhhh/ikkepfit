using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.Data.SqlClient;

public partial class food_Detail : System.Web.UI.Page
{
    SP.BLL.food bll = new SP.BLL.food();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowInfo();
        }
    }

    //初始化
    private void ShowInfo()
    {
        if (Request.QueryString["id"] != null)
        {

            SP.BLL.food bll = new SP.BLL.food();
            SP.Model.food model = bll.GetModel(int.Parse(Request.QueryString["id"]));
            this.lblid.Text = model.id.ToString();
            this.lbltitle.Text = model.title;
            imgpic.ImageUrl = "../../uploads/" + model.pic;
            this.lblmemo.Text = model.memo;
            this.lblatime.Text = model.atime.ToString();
        }
    }
}

