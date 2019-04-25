using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class main  : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            
            
        }
    }

    /// <summary>
    /// 登录
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SP.BLL.members bll = new SP.BLL.members();
        //根据用户名和密码得到用户信息
        DataSet ds = bll.GetList(" lname='" + txt_lname.Text + "' and pass='" + txt_pass.Text + "'");

        //判断用户是否存在
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];


            //把用户信息存入到Session
            Session["lname"] = dr["lname"].ToString();

            //跳转          
            Response.Redirect("default.aspx");

        }
        else
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('用户名或密码错误！');</script>");

            return;
        }
    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("default.aspx");
    }
}
