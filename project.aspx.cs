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

public partial class project : System.Web.UI.Page
{
    private string searchstr;
    private string search;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Session["id"] != null)
            {
                search = "";
                ViewState["search"] = search;
                BindGrid();
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
    public void BindGrid()
    {
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
        string sql;
        searchstr = Session["id"].ToString().Trim();
        search = ViewState["search"].ToString().Trim();
        sql = "select  * from project where 教师ID ='" + searchstr + "'and 项目名 like '%" + search + "%' order by ID";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connstr;
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataView dv = new DataView(ds.Tables[0]);

        this.GridView1.DataSource = dv;
        this.GridView1.DataBind();
    }
    protected void Button_search_Click(object sender, EventArgs e)
    {
        search = this.TextBox_subject.Text.Trim();
        ViewState["search"] = search;
        BindGrid();
    }

    public void GridView1_Del(object sender, GridViewDeleteEventArgs e)
    {
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim();
        SqlConnection conn = new SqlConnection(connstr);
        int idint = Convert.ToInt16(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
        string sql;
        sql = "delete from project where ID=" + idint;

        SqlCommand comm = new SqlCommand(sql, conn);
        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
        }
        catch
        {
            Response.Write("<script>alert('删除失败！');</script>");
        }
        finally
        {
            conn.Close();
        }
        
        BindGrid();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex < 0) return;

        LinkButton lbtnDel = (LinkButton)e.Row.FindControl("delbutton");
        lbtnDel.Attributes.Add("onclick", "return confirm('您真的要删除该行吗？');");
    }
    protected void Button1_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("pj_add.aspx");
    }
}
