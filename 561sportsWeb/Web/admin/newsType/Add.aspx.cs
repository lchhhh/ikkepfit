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

public partial class newsType_Add : System.Web.UI.Page
{
    SP.BLL.newsType bll = new SP.BLL.newsType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }
    }

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string tname = txt_tname.Text;

        SP.Model.newsType model = new SP.Model.newsType();
        model.tname = tname;

        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }
}

