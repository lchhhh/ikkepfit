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

public partial class plans_Add : System.Web.UI.Page
{
    SP.BLL.plans bll = new SP.BLL.plans();
    SP.BLL.plansType bll2 = new SP.BLL.plansType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet dstid = bll2.GetAllList();
            ddltid.DataSource = dstid;
            ddltid.DataTextField = "tname";
            ddltid.DataValueField = "tid";
            ddltid.DataBind();


        }
    }

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string title = txt_title.Text;
        string memo = Textarea1.Value;
        DateTime atime = DateTime.Now;

        SP.Model.plans model = new SP.Model.plans();
        model.title = title;
        model.memo = memo;
        model.atime = atime;

        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='Add.aspx';</script>");
    }
}

