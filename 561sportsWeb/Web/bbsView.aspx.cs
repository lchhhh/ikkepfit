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
    SP.BLL.article bll = new SP.BLL.article();
    SP.BLL.reply bll2 = new SP.BLL.reply();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowInfo();
            bind();
        }
    }

    //初始化
    private void ShowInfo()
    {
        if (Request.QueryString["id"] != null)
        {
            SP.Model.article model = new SP.Model.article();
            model.aid = int.Parse(Request.QueryString["id"]);

            bll.Update(model);

            //绑定数据源
            DataSet ds = bll.GetList2(" a.aid=" + Request.QueryString["id"]);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow sdr = ds.Tables[0].Rows[0];
                Literal1.Text = sdr["title"].ToString();
                Literal3.Text = sdr["total1"].ToString();
                Literal2.Text = sdr["tt"].ToString();
                Literal4.Text = sdr["memo"].ToString();
            }

        }
    }

    /// <summary>
    /// 绑定数据
    /// </summary>
    protected void bind()
    {
        string where = " aid=" + Request.QueryString["id"];


        int pagesize = this.AspNetPager1.PageSize;
        int pageindex = this.AspNetPager1.CurrentPageIndex;
        Repeater1.DataSource = bll.GetListByPage2(where, " regtime desc ", 1 + (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex * AspNetPager1.PageSize);
        Repeater1.DataBind();
        this.AspNetPager1.RecordCount = bll.GetRecordCount2(where);
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



    /// <summary>
    /// 回复
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Session["lname"] == null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('必须登录后才能进行此操作！');</script>");
            return;
        }
        if (Textarea1.Value == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('回复内容不能为空！');</script>");
            return;
        }

        SP.Model.reply model = new SP.Model.reply();

        model.aid =int.Parse( Request.QueryString["id"]);
        model.rmemo = Textarea1.Value;
        model.lname = Session["lname"].ToString();
        model.rtime= DateTime.Now;

        bll2.Add(model);

        Textarea1.Value = "";

        ShowInfo();

        bind();

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('回复成功！');</script>");

    }
}
