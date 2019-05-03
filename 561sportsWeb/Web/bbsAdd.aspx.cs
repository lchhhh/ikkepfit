using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class about : System.Web.UI.Page
{
    SP.BLL.article bll = new SP.BLL.article();
    protected void Page_Load(object sender, EventArgs e)
    {
    }


    /// <summary>
    /// 发表
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnMess_Click(object sender, EventArgs e)
    {
        if (Session["lname"] == null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('必须登录后才能进行此操作！');</script>");
            return;
        }

        string addrpic = "";
        if (fppic.HasFile)
        {
            string name = this.fppic.PostedFile.FileName;
            int i = name.LastIndexOf('.');
            string extname = name.Substring(i);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            string path = filename + extname;
            string savePath = Server.MapPath(@"uploads\" + filename + extname);
            fppic.PostedFile.SaveAs(savePath);
            addrpic = path;
        }

        SP.Model.article model = new SP.Model.article();

        model.title = txt_title.Text;
        model.memo = Textarea1.Value;
        model.total1 = 0;
        model.lname = Session["lname"].ToString();
        model.atime = DateTime.Now;
        model.pic = addrpic;

        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('恭喜您发表成功!');location.href='" + Request.Url.ToString() + "';</script>");
    }

}
