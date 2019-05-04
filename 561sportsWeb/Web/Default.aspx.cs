using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class _Default  : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            
            bind();
        }
    }

  

    /// <summary>
    /// ������
    /// </summary>
    protected void bind()
    {

        Repeater1.DataSource = new SP.BLL.equip().GetList(15, "", " atime desc");
        Repeater1.DataBind();

        Repeater2.DataSource = new SP.BLL.news().GetList(10, "", " atime desc ");
        Repeater2.DataBind();

        Repeater3.DataSource = new SP.BLL.plans().GetList(6, "", " atime desc ");
        Repeater3.DataBind();

        Repeater4.DataSource = new SP.BLL.selection().GetList(10, "", " atime desc ");
        Repeater4.DataBind();

        Repeater5.DataSource = new SP.BLL.plansType().GetList(5,""," tid");
        Repeater5.DataBind();

    }



}
