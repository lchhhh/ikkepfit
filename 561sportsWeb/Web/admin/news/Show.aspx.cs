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

public partial class news_Detail : System.Web.UI.Page
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
            SP.BLL.news bll = new SP.BLL.news();
            //根据编号得到相应的记录
            DataSet ds = bll.GetList("  nid=" + Request.QueryString["id"]);
            SP.Model.news model = bll.GetModel(int.Parse(Request.QueryString["id"]));
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                
                DataRow sdr = ds.Tables[0].Rows[0];
                lblnid.Text = sdr["nid"].ToString();
                lbltitle.Text = sdr["title"].ToString();
                lbltid.Text = sdr["tname"].ToString();
                imgbgpic.ImageUrl = "../../uploads/" + model.bgpic;
                lblmemo.Text = sdr["memo"].ToString();
                lblatime.Text = sdr["atime"].ToString();
            }
  
        }
    }
}

