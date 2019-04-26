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

public partial class plans_Manage : System.Web.UI.Page
{
    SP.BLL.plans bll = new SP.BLL.plans();
    SP.BLL.plansType bll2 = new SP.BLL.plansType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DataSet dstid = bll2.GetAllList();
            ddltid.DataSource = dstid;
            ddltid.DataTextField = "tname";
            ddltid.DataValueField = "tid";
            ddltid.DataBind();
            ddltid.Items.Insert(0, new ListItem("---全部---", ""));


            bind();
        }
    }

    /// <summary>
    /// 绑定
    /// </summary>
    private void bind()
    {
        string where = "  1=1 ";

        if (txt_title.Text != "")
        {
            where += " and title like '%" + txt_title.Text + "%' ";
        }

        if (ddltid.SelectedValue != "")
        {
            where += " and a.tid=" + ddltid.SelectedValue + "";
        }



        GridView1.DataSource = bll.GetList(where + " order by pid desc");
        GridView1.DataBind();

    }

    /// <summary>
    /// 分页事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }
   
    /// <summary>
    /// 搜索
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        bind();
    }
    
    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnk_Click(object sender, EventArgs e)
    {
        LinkButton lk = (LinkButton)sender;

        //删除相应的记录
       bll.Delete(int.Parse( lk.CommandName));

        //重新绑定数据源
        bind();
    }

}

