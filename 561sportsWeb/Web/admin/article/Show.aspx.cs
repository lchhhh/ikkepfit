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

public partial class article_Detail : System.Web.UI.Page
{
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
            SP.BLL.article bll = new SP.BLL.article();
            SP.Model.article model = bll.GetModel(int.Parse(Request.QueryString["id"]));
            this.lblaid.Text = model.aid.ToString();
            this.lbltitle.Text = model.title;
            this.lblmemo.Text = model.memo;
            this.lbltotal1.Text = model.total1.ToString();
            this.lbllname.Text = model.lname;
            this.lblatime.Text = model.atime.ToString();

        }
    }
}

