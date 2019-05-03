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

public partial class action_Modify : System.Web.UI.Page
{
    SP.BLL.action bll = new SP.BLL.action();
    SP.BLL.actionType bll2 = new SP.BLL.actionType();
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
        ddllevid.DataSource = dstid;
        ddllevid.DataTextField = "levname";
        ddllevid.DataValueField = "levid";
        ddllevid.DataBind();

        //根据编号得到相应的记录
        DataSet ds = bll.GetList("  id=" + Request.QueryString["id"]);
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_title.Text = ds.Tables[0].Rows[0]["title"].ToString();
            Labelpic.Text = ds.Tables[0].Rows[0]["pic"].ToString();
            if (Labelpic.Text != "" && Labelpic.Text.Length > 3)
            {
                Imagepic.ImageUrl = "../../uploads/" + Labelpic.Text;
                Imagepic.Visible = true;
            }
            ddllevid.SelectedValue = ds.Tables[0].Rows[0]["levid"].ToString();
            txt_acal.Text = ds.Tables[0].Rows[0]["acal"].ToString();
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
        string addrpic = Labelpic.Text;
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
        model.id = int.Parse(Request.QueryString["id"]);

        bll.Update(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }

}

