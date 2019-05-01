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

public partial class news_Add : System.Web.UI.Page
{
    SP.BLL.news bll = new SP.BLL.news();
    SP.BLL.newsType bll2 = new SP.BLL.newsType();
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
        int tid = int.Parse(ddltid.SelectedValue);
        string bgpic = addrpic;
        string memo = Textarea1.Value;
        DateTime atime = DateTime.Now;

        SP.Model.news model = new SP.Model.news();
        model.title = title;
        model.tid = tid;
        model.bgpic = bgpic;
        model.memo = memo;
        model.atime = atime;


        bll.Add(model);

        txt_title.Text = Textarea1.Value = "";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');</script>");
    }
}

