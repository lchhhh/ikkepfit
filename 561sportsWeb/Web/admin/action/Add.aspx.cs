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

public partial class action_Add : System.Web.UI.Page
{
    SP.BLL.action bll = new SP.BLL.action();
    SP.BLL.actionType bll2 = new SP.BLL.actionType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet dstid = bll2.GetAllList();
            ddllevid.DataSource = dstid;
            ddllevid.DataTextField = "levname";
            ddllevid.DataValueField = "levid";
            ddllevid.DataBind();
        }
    }

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {

        string addrpic = "";
        if (fppic.HasFile)
        {
            string name = this.fppic.PostedFile.FileName;
            int i = name.LastIndexOf('.');
            string extname = name.Substring(i);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            string path = filename + extname;
            string savePath = Server.MapPath(@"..\..\uploads\" + filename + extname);
            fppic.PostedFile.SaveAs(savePath);
            addrpic = path;
        }

        string title = txt_title.Text;
        string pic = addrpic;
        int levid = int.Parse(ddllevid.SelectedValue);
        int acal = int.Parse(txt_acal.Text);
        string memo = Textarea1.Value;
        DateTime atime = DateTime.Now;

        SP.Model.action model = new SP.Model.action();
        model.title = title;
        model.pic = pic;
        model.levid = levid;
        model.acal = acal;
        model.memo = memo;
        model.atime = atime;

        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='add.aspx';</script>");
    }
}

