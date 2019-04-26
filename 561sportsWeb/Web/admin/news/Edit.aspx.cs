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

public partial class news_Modify : System.Web.UI.Page
{
    SP.BLL.news bll = new SP.BLL.news();
    SP.BLL.newsType bll2 = new SP.BLL.newsType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            chushi();
        }
    }

   /// <summary>
    /// 初始化
    /// </summary>
    protected void chushi()
    {
        DataSet dstid = bll2.GetAllList();
        ddltid.DataSource = dstid;
        ddltid.DataTextField = "tname";
        ddltid.DataValueField = "tid";
        ddltid.DataBind();

        

        //根据编号得到相应的记录
        DataSet ds = bll.GetList("  nid=" + Request.QueryString["id"]);
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_title.Text = ds.Tables[0].Rows[0]["title"].ToString();
            ddltid.SelectedValue=ds.Tables[0].Rows[0]["tid"].ToString();
            Textarea1.Value = ds.Tables[0].Rows[0]["memo"].ToString();
        }
    }

    /// <summary>
    /// 编辑
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //更新   
        string title = txt_title.Text;
        int tid = int.Parse(ddltid.SelectedValue);
        string memo = Textarea1.Value;
  

        SP.Model.news model = new SP.Model.news();
        model.title = title;
        model.tid = tid;
        model.memo = memo;
        model.nid = int.Parse(Request.QueryString["id"]);


        bll.Update(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }

}

