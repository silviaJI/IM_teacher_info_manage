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

public partial class award_detail : System.Web.UI.Page
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
        sql1 = "select  * from award where ID='" + searchstr + "'";
        sql2 = "select  姓名 from teacher,award where 教师ID='" + Session["id"].ToString().Trim() + "'and award.教师ID=teacher.工号";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;

        SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);

        SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);

        this.award_name.Value = ds1.Tables[0].Rows[0]["奖项名"].ToString();
        this.award_tea.Value = ds2.Tables[0].Rows[0]["姓名"].ToString();
        this.award_pname.Value = ds1.Tables[0].Rows[0]["奖励名称"].ToString();
        this.award_time.Value = ds1.Tables[0].Rows[0]["获奖时间"].ToString();
        this.award_level.Value = ds1.Tables[0].Rows[0]["奖项等级"].ToString();
        this.award_depart.Value = ds1.Tables[0].Rows[0]["来源部门"].ToString();
        this.award_relaper.Value = ds1.Tables[0].Rows[0]["相关人员"].ToString();
        this.award_remark.Value = ds1.Tables[0].Rows[0]["备注"].ToString();
    }

    protected void confirm_ServerClick(object sender, EventArgs e)
    {
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
            string sql;
            searchstr = Request.QueryString["id"].ToString();

            sql = "update award set 奖项名='" + this.award_name.Value + "',奖励名称='" + this.award_pname.Value + "',获奖时间='" + this.award_time.Value + "',奖项等级='" + this.award_level.Value +
                "',来源部门='" + this.award_depart.Value + "',相关人员='" + this.award_relaper.Value + "',备注='" + this.award_remark.Value + "' where ID='" + searchstr + "'";

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
