using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _login : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            litIP.Text = Request.UserHostAddress;
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SP.BLL.admin bll = new SP.BLL.admin();
        DataSet ds = bll.GetList(" lname='" + this.username.Value + "' and pwd='" + this.password.Value + "'");

        //判断用户是否存在
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];

            //把用户信息存入到Session
            Session["id"] = dr["aid"].ToString();
            Session["username"] = dr["lname"].ToString();
            Session["userrole"] = "系统管理员";

            //跳转到后台
            Response.Redirect("Default.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('用户名或密码错误，请重试!');</script>");
            return;
        }
    }
}
