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

public partial class members_Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowInfo();
        }
    }

    //初始化
    private void ShowInfo()
    {
        if (Request.QueryString["id"] != null)
        {
            SP.BLL.members bll = new SP.BLL.members();
            SP.Model.members model = bll.GetModel(Request.QueryString["id"]);
            this.lbllname.Text = model.lname;
            this.lblpass.Text = model.pass;
            this.lblmname.Text = model.mname;
            this.lblsex.Text = model.sex;
            this.lbltel.Text = model.tel;
            imgpic.ImageUrl = "../../uploads/" + model.pic;
               this.lblregtime.Text = model.regtime.ToString();

           
        }
    }
}

