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
    SP.BLL.news bll = new SP.BLL.news();
    SP.BLL.newsType bll2 = new SP.BLL.newsType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bind();
        }
    }

    /// <summary>
    /// 绑定数据
    /// </summary>
    protected void bind()
    {
        string where = " 1=1 ";

        if(Request.QueryString["tid"]!=null)
        {
            where += " and tid=" + Request.QueryString["tid"];

            //根据编号得到相应的记录
            DataSet ds = bll2.GetList(" tid=" + Request.QueryString["tid"]);

            if (ds.Tables[0].Rows.Count > 0)
            {
               Literal1.Text = ds.Tables[0].Rows[0]["tname"].ToString();
            }
        }
        else
        {
            Literal1.Text = "运动新闻";
        }

        int pagesize = this.AspNetPager1.PageSize;
        int pageindex = this.AspNetPager1.CurrentPageIndex;
        Repeater1.DataSource = bll.GetListByPage(where, " atime desc ", 1 + (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex * AspNetPager1.PageSize);
        Repeater1.DataBind();

        this.AspNetPager1.RecordCount = bll.GetRecordCount(where);
    }

    /// <summary>
    /// 分页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }
}
