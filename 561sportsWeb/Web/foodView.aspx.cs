using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;

public partial class about : System.Web.UI.Page
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
            SP.BLL.food bll = new SP.BLL.food();
            //根据编号得到相应的记录
            DataSet ds = bll.GetList("  id=" + Request.QueryString["id"]);
            SP.Model.food model = bll.GetModel(int.Parse(Request.QueryString["id"]));
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow sdr = ds.Tables[0].Rows[0];
                lbltitle.Text = sdr["title"].ToString();
                imgpic.ImageUrl = "../../uploads/" + model.pic;
                lblmemo.Text = sdr["memo"].ToString();
               // lblfcal.Text = sdr["fcal"].ToString()+"卡路里/100g";
                lblatime.Text = sdr["atime"].ToString();
            }

        }
    }
}