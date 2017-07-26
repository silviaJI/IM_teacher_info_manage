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

public partial class psdchange : System.Web.UI.Page
{
    private string searchstr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Session["id"] == null)
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

    protected void Button3_ServerClick(object sender, EventArgs e)
    {
        searchstr = Session["id"].ToString().Trim();
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim(); 
        SqlConnection conn = new SqlConnection(connstr);
        string comm_str;
        comm_str = "select * from tlogin where 账号='" + searchstr + "'";
        SqlDataAdapter da = new SqlDataAdapter(comm_str, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = ds.Tables[0];
        
       
        if (this.TextBox1.Text == dt.Rows[0]["密码"].ToString() && this.TextBox2.Text == this.TextBox3.Text)
        {
            string sql;
            sql = "update tlogin set 密码='" + this.TextBox2.Text + "' where 账号='" + searchstr + "'";
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = connstr;
            conn1.Open();
            SqlCommand cmd = new SqlCommand(sql, conn1);

            if (cmd.ExecuteNonQuery() > 0)
                Response.Write("<script language=javascript>alert('修改成功！请重新登入！');window.location = 'logout.aspx';</script>");
            else
                Response.Write("<script language=javascript>alert('修改失败！请重试！');window.location.href=document.URL;</script>");
        }

        else if (this.TextBox1.Text != dt.Rows[0]["密码"].ToString())
        {
            Response.Write("<script>alert('旧密码错误！');</script>");
        }
        else if (this.TextBox2.Text != this.TextBox3.Text)
        {
            Response.Write("<script>alert('请重新验证密码！');</script>");
        }
    }
}
