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

public partial class selection_Add : System.Web.UI.Page
{
    SP.BLL.selection bll = new SP.BLL.selection();
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
        string title = txt_title.Text;
        string memo = Textarea1.Value;
        DateTime atime = DateTime.Now;

        SP.Model.selection model = new SP.Model.selection();
        model.title = title;
        model.memo = memo;
        model.atime = atime;

  
        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='Add.aspx';</script>");
    }
}

