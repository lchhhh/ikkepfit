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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowInfo();
        }
    }

    //��ʼ��
    private void ShowInfo()
    {
        if (Request.QueryString["id"] != null)
        {
            SP.BLL.selection bll = new SP.BLL.selection();
            //���ݱ�ŵõ���Ӧ�ļ�¼
            DataSet ds = bll.GetList("  id=" + Request.QueryString["id"]);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow sdr = ds.Tables[0].Rows[0];
                lbltitle.Text = sdr["title"].ToString();
                lblmemo.Text = sdr["memo"].ToString();
                lblatime.Text = sdr["atime"].ToString();
            }

        }
    }
}
