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

public partial class password: System.Web.UI.Page
{
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
    /// 修改密码
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SP.BLL.members bll = new SP.BLL.members();

        //判断两次密码输入是否一致，如果不一致，则弹出提示信息，并返回
        if (TextBox1.Text == TextBox2.Text)
        {
            //根据用户编号和原密码得到用户信息
            DataSet ds = bll.GetList(" lname=" + Session["lname"].ToString() + " and pass='" + Md5Hash(txt_pwd.Text)+"'");

            //判断原密码是否正确
            if (ds.Tables[0].Rows.Count > 0)
            {
                //更新新密码
                SP.Model.members model = new SP.Model.members();
                model.pass =Md5Hash( TextBox1.Text);
                model.lname = Session["lname"].ToString();

                bll.Update(model);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('修改成功！');</script>");

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('原密码不正确！');</script>");
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('两次密码输入不一致！');</script>");
        }

    }
}

