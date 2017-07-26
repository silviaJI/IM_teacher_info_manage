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

public partial class work_add : System.Web.UI.Page
{
    private string searchstr;
    public void BindData()
    {
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

        this.welcometext.Text = "欢迎" + ds.Tables[0].Rows[0]["姓名"] + "进入系统";
        this.work_auth.Value = ds.Tables[0].Rows[0]["姓名"].ToString();
    }
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
    }
    protected void confirm_ServerClick(object sender, EventArgs e)
    {
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
        string sql;
        searchstr = Session["id"].ToString().Trim();

        sql = "insert into work(著作名,发表期刊或出版社,分类号,学科,发表年份,卷期页码,类型,作者ID,其他作者,作者机构,基金,备注) values('" + this.work_name.Value + "','"
            + this.work_jour.Value + "','" + this.work_ty.Value + "','" + this.work_sub.Value + "','" + this.work_time.Value + "','" + this.work_page.Value + "','"
            + this.work_type.Value + "','" + searchstr + "','" + this.work_oauth.Value + "','" + this.work_organ.Value + "','" + this.work_fund.Value + "','" + this.work_remark.Value + "')";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);

        if (cmd.ExecuteNonQuery() > 0)
            Response.Write("<script language=javascript>alert('修改成功！');window.location='work.aspx';</script>");
        else
            Response.Write("<script language=javascript>alert('修改失败！请重试！');window.location.href=document.URL;</script>");
    }
    protected void cancel_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("work.aspx");
    }
}
