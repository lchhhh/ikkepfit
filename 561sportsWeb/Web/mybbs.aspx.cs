using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class about  : System.Web.UI.Page
{
    SP.BLL.article bll = new SP.BLL.article();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bind();
        }
    }

    /// <summary>
    /// ������
    /// </summary>
    protected void bind()
    {
        string where = " lname='" + Session["lname"].ToString()+"' ";

       
        int pagesize = this.AspNetPager1.PageSize;
        int pageindex = this.AspNetPager1.CurrentPageIndex;
        Repeater1.DataSource = bll.GetListByPage(where, " atime desc ", 1 + (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex * AspNetPager1.PageSize);
        Repeater1.DataBind();

        this.AspNetPager1.RecordCount = bll.GetRecordCount(where);
    }

    /// <summary>
    /// ��ҳ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bind();
    }

    /// <summary>
    /// ɾ��
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnk_Click(object sender, EventArgs e)
    {
        LinkButton lk = (LinkButton)sender;

        //ɾ����Ӧ�ļ�¼
        bll.Delete(int.Parse(lk.CommandName));

        //���°�����Դ
        bind();
    }

}
