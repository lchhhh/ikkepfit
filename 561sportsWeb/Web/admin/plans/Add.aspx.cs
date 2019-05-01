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
        int mark = int.Parse(txt_mark.Text);
        int tid = int.Parse(ddltid.SelectedValue);
        string bgpic = addrpic;
        string memo = Textarea1.Value;
        string remarks = txt_remarks.Text;
        DateTime atime = DateTime.Now;

        SP.Model.plans model = new SP.Model.plans();
        model.title = title;
        model.tid = tid;
        model.bgpic = bgpic;
        model.mark = mark;
        model.memo = memo;
        model.remarks = remarks;
        model.atime = atime;

        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='Add.aspx';</script>");
    }
}

