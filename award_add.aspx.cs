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

public partial class award_add : System.Web.UI.Page
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
    }

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

        welcometext.Text = "欢迎" + ds.Tables[0].Rows[0]["姓名"] + "进入系统";
        this.award_tea.Value = ds.Tables[0].Rows[0]["姓名"].ToString();
    }

    protected void confirm_ServerClick(object sender, EventArgs e)
    {
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
        string sql;
        searchstr = Session["id"].ToString().Trim();

        sql = "insert into award(奖项名,教师ID,奖励名称,获奖时间,奖项等级,来源部门,相关人员,备注) values('" + this.award_name.Value + "','" + searchstr + "','" + this.award_pname.Value + "','" 
            + this.award_time.Value + "','" + this.award_level.Value + "','" + this.award_depart.Value + "','" + this.award_relaper.Value + "','" + this.award_remark.Value  + "')";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);

        if (cmd.ExecuteNonQuery() > 0)
            Response.Write("<script language=javascript>alert('修改成功！');window.location='award.aspx';</script>");
        else
            Response.Write("<script language=javascript>alert('修改失败！请重试！');window.location.href=document.URL;</script>");
    }
    protected void cancel_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("award.aspx");
    }

}
