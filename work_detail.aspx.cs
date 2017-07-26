using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class work_detail : System.Web.UI.Page
{
    private string searchstr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Session["id"] != null)
            {
                BindData();
            }
            else
            {
                Response.Redirect("login.aspx");
            }

        }

        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
        string sql;
        searchstr = Session["id"].ToString().Trim();
        sql = "select  * from teacher where 工号='" + searchstr + "'";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataView dv = new DataView(ds.Tables[0]);

        welcometext.Text = "欢迎" + ds.Tables[0].Rows[0]["姓名"] + "进入系统";
    }

    public void BindData()
    {
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
        string sql1, sql2;
        searchstr = Request.QueryString["id"].ToString();
        sql1 = "select  * from work where ID='" + searchstr + "'";
        sql2 = "select  姓名 from teacher,work where 作者ID='" + Session["id"].ToString().Trim() + "'and work.作者ID=teacher.工号";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;

        SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);

        SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);

        this.work_name.Value = ds1.Tables[0].Rows[0]["著作名"].ToString();
        this.work_jour.Value = ds1.Tables[0].Rows[0]["发表期刊或出版社"].ToString();
        this.work_ty.Value = ds1.Tables[0].Rows[0]["分类号"].ToString();
        this.work_sub.Value = ds1.Tables[0].Rows[0]["学科"].ToString();
        this.work_time.Value = ds1.Tables[0].Rows[0]["发表年份"].ToString();
        this.work_page.Value = ds1.Tables[0].Rows[0]["卷期页码"].ToString();
        this.work_type.Value = ds1.Tables[0].Rows[0]["类型"].ToString();
        this.work_auth.Value = ds2.Tables[0].Rows[0]["姓名"].ToString();
        this.work_oauth.Value = ds1.Tables[0].Rows[0]["其他作者"].ToString();
        this.work_organ.Value = ds1.Tables[0].Rows[0]["作者机构"].ToString();
        this.work_fund.Value = ds1.Tables[0].Rows[0]["基金"].ToString();
        this.work_remark.Value = ds1.Tables[0].Rows[0]["备注"].ToString();

    }

    protected void confirm_ServerClick(object sender, EventArgs e)
    {
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
            string sql;
            searchstr = Request.QueryString["id"].ToString();

            sql = "update work set 著作名='" + this.work_name.Value + "',发表期刊或出版社='" + this.work_jour.Value + "',分类号='" + this.work_ty.Value + "',学科='" + this.work_sub.Value +
                "',发表年份='" + this.work_time.Value + "',卷期页码='" + this.work_page.Value + "',类型='" + this.work_type.Value +
                "',其他作者='" + this.work_oauth.Value + "',作者机构='" + this.work_organ.Value + "',基金='" + this.work_fund.Value + "',备注='" + this.work_remark.Value + "' where ID='" + searchstr + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstr;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (cmd.ExecuteNonQuery() > 0)
                Response.Write("<script language=javascript>alert('修改成功！');window.location.href=work.aspx;</script>");
            else
                Response.Write("<script language=javascript>alert('修改失败！请重试！');window.location.href=document.URL;</script>");
        }
    }
    protected void cancel_ServerClick(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.history.go(-1)';</script>");
    }
}
