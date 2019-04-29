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

public partial class members_Add : System.Web.UI.Page
{
    SP.BLL.members bll = new SP.BLL.members();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
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
    /// 添加
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {   
        //验证是否已经存在
        if (bll.Exists( txt_lname.Text))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('该登录名已存在，请重新输入！');</script>");
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
            string savePath = Server.MapPath(@"..\..\uploads\" + filename + extname);
            fppic.PostedFile.SaveAs(savePath);
            addrpic = path;
        }

        string lname = txt_lname.Text;
        string pass = Md5Hash(txt_pass.Text);
        string mname = txt_mname.Text;
        string sex = rtsex.SelectedValue;
        string tel = txt_tel.Text;
        string pic = addrpic;
        DateTime regtime = DateTime.Now;

        SP.Model.members model = new SP.Model.members();
        model.lname = lname;
        model.pass = pass;
        model.mname = mname;
        model.sex = sex;
        model.tel = tel;
        model.pic = pic;
        model.regtime = regtime;

        bll.Add(model);

        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('操作成功，请返回!');location.href='List.aspx';</script>");
    }
}

