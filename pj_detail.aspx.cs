using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class pj_detail : System.Web.UI.Page
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
        string sql1,sql2;
        searchstr = Request.QueryString["id"].ToString();
        sql1 = "select  * from project where ID='" + searchstr + "'";
        sql2 = "select  姓名 from teacher,project where 教师ID='" + Session["id"].ToString().Trim() + "'and project.教师ID=teacher.工号";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;
        
        SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        
        SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);

        this.pj_name.Value = ds1.Tables[0].Rows[0]["项目名"].ToString();
        this.pj_tea.Value = ds2.Tables[0].Rows[0]["姓名"].ToString();
        this.pj_source.Value = ds1.Tables[0].Rows[0]["项目来源"].ToString();
        this.pj_pretime.Value = ds1.Tables[0].Rows[0]["立项时间"].ToString();
        this.pj_time.Value = ds1.Tables[0].Rows[0]["研制时间段"].ToString();
        this.pj_money.Value = ds1.Tables[0].Rows[0]["项目金额"].ToString();
        this.pj_sour_depart.Value = ds1.Tables[0].Rows[0]["来源部门"].ToString();
        this.pj_co_depart.Value = ds1.Tables[0].Rows[0]["合作部门"].ToString();
        this.pj_memb.Value = ds1.Tables[0].Rows[0]["项目成员"].ToString();
        this.pj_remark.Value = ds1.Tables[0].Rows[0]["备注"].ToString();
    }

    protected void confirm_ServerClick(object sender, EventArgs e)
    {
        bool b=this.pj_name.Value != null &&this.pj_tea.Value != null && this.pj_source.Value != null && this.pj_pretime.Value != null && this.pj_time.Value != null && this.pj_money.Value != null && this.pj_sour_depart.Value != null && this.pj_co_depart.Value != null && this.pj_memb.Value != null && this.pj_remark.Value!= null;
        if (b)
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
            string sql;
            searchstr = Request.QueryString["id"].ToString();

            sql = "update project set 项目名='" + this.pj_name.Value + "',项目来源='" + this.pj_source.Value + "',立项时间='" + this.pj_pretime.Value + "',研制时间段='" + pj_time.Value +
                "',项目金额='" + this.pj_money.Value + "',来源部门='" + this.pj_sour_depart.Value + "',合作部门='" + this.pj_co_depart.Value + "',项目成员='" + this.pj_memb.Value +
                "',备注='" + this.pj_remark.Value + "' where ID='" + searchstr + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstr;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (cmd.ExecuteNonQuery() > 0)
                Response.Write("<script language=javascript>alert('修改成功！');window.location.href=document.URL;</script>");
            else
                Response.Write("<script language=javascript>alert('修改失败成功！请重试！');window.location.href=document.URL;</script>");
        }
    }
    protected void cancel_ServerClick(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.history.go(-1)';</script>");
    }
}
