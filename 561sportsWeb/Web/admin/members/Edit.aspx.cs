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
using System.Security.Cryptography;

public partial class members_Modify : System.Web.UI.Page
{
    SP.BLL.members bll = new SP.BLL.members();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            chushi();
        }
    }


    private static string Md5Hash(string input)
    {
        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }

   /// <summary>
    /// 初始化
    /// </summary>
    protected void chushi()
    {

        //根据编号得到相应的记录
        DataSet ds =bll.GetList("  lname='" + Request.QueryString["id"] + "'");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_lname.Text = ds.Tables[0].Rows[0]["lname"].ToString();
            txt_pass.Text = ds.Tables[0].Rows[0]["pass"].ToString();
            txt_mname.Text = ds.Tables[0].Rows[0]["mname"].ToString();
            rtsex.SelectedValue=ds.Tables[0].Rows[0]["sex"].ToString();
            txt_tel.Text = ds.Tables[0].Rows[0]["tel"].ToString();
            Labelpic.Text = ds.Tables[0].Rows[0]["mpic"].ToString();
            if (Labelpic.Text != "" && Labelpic.Text.Length > 3)
            {
               Imagepic.ImageUrl = "../../uploads/" + Labelpic.Text;
               Imagepic.Visible = true;
             }
        }
    }

    /// <summary>
    /// 编辑
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
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

        string lname = txt_lname.Text;
        string pass = Md5Hash(txt_pass.Text);
        string mname = txt_mname.Text;
        string sex = rtsex.SelectedValue;
        string tel = txt_tel.Text;
        string mpic = addrpic;


        SP.Model.members model = new SP.Model.members();
        model.lname = lname;
        model.pass = pass;
        model.mname = mname;
        model.sex = sex;
        model.tel = tel;
        model.mpic = mpic;


        bll.Update(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }

}

