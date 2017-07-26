using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;


public partial class login2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void login_ServerClick(object sender, EventArgs e)
    {
        string id = this.username.Text.Trim();
        string psd = this.psd.Text.Trim();

        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim(); 
        SqlConnection conn = new SqlConnection(connstr);
        string comm_str;
        if (this.RadioButtonList1.SelectedIndex == 0)
            comm_str = "select * from tlogin where 账号='" + id + "'";
        else
            comm_str = "select * from slogin where 学号='" + id + "'";

        SqlDataAdapter da = new SqlDataAdapter(comm_str, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = ds.Tables[0];

        if (dt.Rows.Count > 0)
        {
            if (psd == dt.Rows[0]["密码"].ToString())
            {
                Session["id"] = id;
                Response.Redirect("personinfo.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('密码错误！');</script>");
                this.psd.Focus();
            }
        }
        else
        {
            Response.Write("<script language=javascript>alert('此用户不存在！');</script>");
            this.username.Focus();
        }
    }
}
