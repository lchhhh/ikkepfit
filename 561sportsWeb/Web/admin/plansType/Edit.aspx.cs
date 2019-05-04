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

public partial class plansType_Modify : System.Web.UI.Page
{
    SP.BLL.plansType bll = new SP.BLL.plansType();
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
        //根据编号得到相应的记录
        DataSet ds = bll.GetList(" tid=" + Request.QueryString["id"]);

        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_tname.Text = ds.Tables[0].Rows[0]["tname"].ToString();
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
        string tname = txt_tname.Text;

        SP.Model.plansType model = new SP.Model.plansType();
        model.tname = tname;
        model.tid = int.Parse(Request.QueryString["id"]);

        //提交到数据库
        bll.Update(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }

}

