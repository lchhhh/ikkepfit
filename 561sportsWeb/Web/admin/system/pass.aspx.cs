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

public partial class pass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }


    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SP.BLL.admin bll = new SP.BLL.admin();

                //判断两次密码输入是否一致，如果不一致，则弹出提示信息，并返回
        if (TextBox1.Text == TextBox2.Text)
        {
            //根据用户编号和原密码得到用户信息
            DataSet  ds = bll.GetList(" aid=" + Session["id"].ToString() + " and pwd='" + txt_pwd.Text + "'");

            //判断原密码是否正确
            if (ds.Tables[0].Rows.Count > 0)
            {
                //更新新密码
                SP.Model.admin model = new SP.Model.admin();
                model.pwd = TextBox1.Text;
                model.aid = int.Parse(Session["id"].ToString());

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

