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

public partial class personinfo : System.Web.UI.Page
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
        string sql;
        searchstr = Session["id"].ToString().Trim();
        sql = "select  * from teacher where 工号='" + searchstr + "'";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataView dv = new DataView(ds.Tables[0]);

       this.name.Text=ds.Tables[0].Rows[0]["姓名"].ToString();
       this.id.Text=ds.Tables[0].Rows[0]["工号"].ToString();
       this.sex.Text=ds.Tables[0].Rows[0]["性别"].ToString();
       this.prof_title.Text=ds.Tables[0].Rows[0]["职称"].ToString();
       this.post.Text=ds.Tables[0].Rows[0]["职位"].ToString();
       this.dept.Text=ds.Tables[0].Rows[0]["系别"].ToString();        
       this.office.Text=ds.Tables[0].Rows[0]["办公室"].ToString();
       this.email.Value=ds.Tables[0].Rows[0]["邮箱"].ToString();
       this.worktel.Value=ds.Tables[0].Rows[0]["办公电话"].ToString();
       this.tel.Value=ds.Tables[0].Rows[0]["手机号码"].ToString();
       this.opentime.Text=ds.Tables[0].Rows[0]["开放咨询时间"].ToString();
       this.field.Value=ds.Tables[0].Rows[0]["研究领域"].ToString();
       this.edu_bg.Value=ds.Tables[0].Rows[0]["教育背景"].ToString();                        
    }
    protected void confirm_ServerClick(object sender, EventArgs e)
    {

        if (this.email.Value != null && this.worktel.Value != null && this.tel.Value != null && this.field.Value != null && this.edu_bg.Value != null)
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
            string sql;
            searchstr = Session["id"].ToString().Trim();
            sql = "update teacher set 邮箱='" + this.email.Value + "',办公电话='" + this.worktel.Value + "',手机号码='" + this.tel.Value + "',研究领域='" + this.field.Value +
                "',教育背景='" + this.edu_bg.Value + "' where 工号='" + searchstr + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstr;
            conn.Open();
            SqlCommand cmd = new SqlCommand( sql,conn);

            if(cmd.ExecuteNonQuery()>0)
                Response.Write("<script language=javascript>alert('修改成功！');window.location = 'personinfo.aspx';</script>");
            else
                Response.Write("<script language=javascript>alert('修改失败成功！请重试！');window.location = 'personinfo.aspx';</script>");
       }
    }
    protected void cancel_ServerClick(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.location = 'personinfo.aspx';</script>");
    }
}
