<%@ Page Language="C#" AutoEventWireup="true" CodeFile="psdchange.aspx.cs" Inherits="psdchange" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>修改密码</title>
    <style type="text/css">
     a{text-decoration:none;color: inherit;}
     .btn{float:left;margin-left:40px; width:60px;height:35px;font-size:15px;}

     </style>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
    window.location="personinfo.aspx";
}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="width: 100%; height: 18px; background-color:#ccccff">
            <tr>
                <td>
        <img src="logo.png" alt="logo"/></td>
                <td align="left"/>
                    <table style="width: 100%;height:100%">
                        <tr>
                            <td align="right" style="width: 412px">
                    <asp:Label ID="welcometext" runat="server" Text="欢迎进入系统" Width="135px"></asp:Label>
                                [<a href="psdchange.aspx">修改密码</a>]
                                <a style="margin-left:20px;" href="logout.aspx">退出系统</a></td>
                        </tr>
                        <tr>
                            <td style="height: 23px; width: 412px;" align="left"/>
                        </tr>
                        <tr>
                            <td align="left" style="width: 412px"/>
                        </tr>
                    </table>
                
        </table>
         <hr style="width:100%; height: 5px; background-color:Black" />
    </div>
        <table style="width:100%; margin-left:40%;">
            <tr>
                
                <td style="height: 229px">
                    <asp:Label ID="Label2" runat="server" Text="旧密码：" Width="100px"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox><br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="新密码：" Width="100px"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="确认新密码：" Width="100px"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="left" colspan="2" rowspan="1" valign="top">
                    <input id="Button3" type="button" class="btn" value="修改"  onserverclick="Button3_ServerClick" runat="server" />
                    <input id="Button1" type="button" class="btn" value="取消" onclick="return Button1_onclick()"  /></td>
            </tr>
        </table>
    </form>
    
   <div style="position:fixed;bottom:3%; width:100%;">
        <div style="height:15px; background-color:#ccccff; margin:3% 2.5% 1%;"></div>
        <div style="text-align:center; color:#231F20; font-size:13px;">
             Copyright 2017 南京大学信息管理学院 版权所有
        </div>
    </div>
</body>
</html>
