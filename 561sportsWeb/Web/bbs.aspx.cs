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
        string where = " 1=1 ";

        int pagesize = this.AspNetPager1.PageSize;
        int pageindex = this.AspNetPager1.CurrentPageIndex;
        //Repeater1.DataSource = bll.GetListByPage(where, " atime desc ", 1 + (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex * AspNetPager1.PageSize);
        Repeater1.DataSource = bll.GetList(10, "", "aid");
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
    /// ����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void btnMess_Click(object sender, EventArgs e)
    //{
    //    if (Session["lname"] == null)
    //    {
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('�����¼����ܽ��д˲�����');</script>");
    //        return;
    //    }

    //    SP.Model.article model = new SP.Model.article();

    //    model.title = txt_title.Text;
    //    model.memo = Textarea1.Value;
    //    model.total1 = 0;
    //    model.lname = Session["lname"].ToString();
    //    model.atime = DateTime.Now;

    //    bll.Add(model);

    //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('��ϲ������ɹ�!');location.href='" + Request.Url.ToString() + "';</script>");
    //}

}
