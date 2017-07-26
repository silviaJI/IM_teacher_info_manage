<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>登陆</title>
    <style type="text/css">
    .main_bg{width: 430px; height: 298px; opacity:0.8; margin-top:6%;}
    .
    </style>
<script language="javascript" type="text/javascript">

</script>
</head>
<body style="background-color:#ccccff">
    <form id="form1" runat="server">
    <div>
    <table style="width: 100%; height: 18px;">
            <tr>
                <td>
        <img src="logo.png" alt="logo" /></td>
                <td align="left">
                </td>
                </tr>
        </table>
        </div>
        <hr style="width:100%; height: 5px; background-color:Black" />
        <table style="width: 100%; height: 280px">
            <tr>
                <td style="width: 50%; height: 365px;" align="center"
                >
                    <img src="main_bg.png" class="main_bg" alt="logo" /></td>
                <td align="right" style="height: 365px">
                    <table style="width: 100%;">
                        <tr>
                            <td style="height: 65px; width: 60%; " >
                                &nbsp;
                            </td>
                                <td rowspan="4" align="left">
                                    <br />
                                    <br />
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                        <asp:ListItem Selected="True">教师登录</asp:ListItem>
                                        <asp:ListItem>学生登录</asp:ListItem>
                                    </asp:RadioButtonList></td>
                        </tr>
                        <tr>
                            <td style="height: 60px; width: 60%; "align="center">
                                <asp:Label ID="Label4" runat="server" Text="用户名："></asp:Label><asp:TextBox ID="username" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="height: 60px; width: 70%; "align="center">
                                <asp:Label ID="Label5" runat="server" Text="密码：  "></asp:Label>&nbsp;
                                <asp:TextBox ID="psd" runat="server" TextMode="Password"></asp:TextBox></td>
                           
                        </tr>
                        <tr><td style="width:60%" align="center">
                            <input id="login" type="button" value="登录" style="width: 59px; height: 34px" onserverclick="login_ServerClick" runat="server"  /></td>
                        </tr>
                    </table>
                </td>
               
            </tr></table>
           <table style="width: 100%;height:200px;position:fixed;bottom:3%;">
            <tr><td align="center">
                <img src="logo3.png" alt="logo"/></td>
                    <td style="color:Gray; font-size:13px;"> 
                    <div> 地址：南京市栖霞区仙林大道163号</div>
                    <div>邮编：210023</div>
                    <div>E-mail：imtuanwei@163.com</div>
                    <div>Copyright 2017 南京大学信息管理学院 版权所有</div>
               </td></tr>
        </table>
    </form>
</body>
</html>