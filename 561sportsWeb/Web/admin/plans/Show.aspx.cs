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

public partial class plans_Detail : System.Web.UI.Page
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
            SP.BLL.plans bll = new SP.BLL.plans();
            //根据编号得到相应的记录
            DataSet ds = bll.GetList("  pid=" + Request.QueryString["id"]);
            SP.Model.plans model = bll.GetModel(int.Parse(Request.QueryString["id"]));
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow sdr = ds.Tables[0].Rows[0];
                lblpid.Text = sdr["pid"].ToString();
                lbltitle.Text = sdr["title"].ToString();
                lbltid.Text = sdr["tname"].ToString();
                imgbgpic.ImageUrl = "../../uploads/" + model.bgpic;
                lblmark.Text = sdr["mark"].ToString();
                lblmemo.Text = sdr["memo"].ToString();
                lblremarks.Text = sdr["remarks"].ToString();
                lblatime.Text = sdr["atime"].ToString();
            }

        }
    }
}

