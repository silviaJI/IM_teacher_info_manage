<%@ Page Language="C#" AutoEventWireup="true" CodeFile="award_add.aspx.cs" Inherits="award_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>信息管理系统-信息管理学院</title>
    <style type="text/css">
     a{text-decoration:none;color: inherit;}
    .left_nav a:hover{color:white}
    .left_nav{width: 157px; height:30px; background-color: #ccccff; text-align:center;}
    .left_nav:hover{background-color: #496158; color:white;}
    .left_nav_active{width: 157px; height:30px; background-color: #496158; color:white;text-align:center;}
    .btn{margin-left:30px; width:60px;height:35px;font-size:15px; float:left;}
    .inputbox{ border:0;margin-left:1%; width: 80%; margin-top:1%; margin-bottom:1%; }
    </style>

</head>
<body>
<form id="form1" runat="server">
    <div>
     <table style="width: 100%; height: 18px; background-color:#ccccff">
            <tr>
                <td>
                <img src="logo.png" alt="logo" /></td>
                <td align="left">
                    <table style="width: 100%;height:100%;">
                        <tr>
                            <td align="right" style="width: 412px">
                    <asp:Label ID="welcometext" runat="server" Text="欢迎进入系统" Width="135px"></asp:Label>
                                [<a href="psdchange.aspx">修改密码</a>]
                                <a style="margin-left:20px;" href="logout.aspx">退出系统</a></td>
                        </tr>
                        <tr>
                            <td style="height: 23px; width: 412px;" align="left"></td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 412px"></td>
                        </tr>
                    </table>
                </td>
                </tr>        
        </table>
         <hr style="width:100%; height: 5px; background-color:Black" />
    </div>

        


          <div style="clear:both;"></div>
          <div>
          <table width="60%" style=" margin-top:3%; margin-left:20%">
                        
                        <tr>
                            <td style="width: 98px; background-color: #ccccff;">
                                奖项名：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_name" type="text" value="" class="inputbox"  runat="server"  /></td>
                        </tr>
                        <tr>
                            <td style="width: 98px; background-color: #ccccff;">
                                教师姓名：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_tea" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                            <td style="width: 98px; background-color: #ccccff;">
                                奖励名称：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_pname" type="text" value="" class="inputbox"  runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                获奖时间：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_time" type="text" value="" class="inputbox"  runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                奖项等级：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_level" type="text" value="" class="inputbox"  runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                来源部门：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_depart" type="text" value="" class="inputbox" runat="server" /></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 98px; background-color: #ccccff;">
                                相关人员：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_relaper" type="text" value="" class="inputbox" runat="server" /></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 98px; background-color: #ccccff;">
                                备注：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="award_remark" type="text" value="" class="inputbox"  runat="server" /></td>
                        </tr>
                        
                    </table>
          </div>
          <div style="margin:3% 40% 3% 45%;">
                 <input id="confirm" type="button"  value="确定" class="btn"  runat="server" onserverclick="confirm_ServerClick"  />
                 <input id="cancel" type="button"  value="取消" class="btn"  runat="server" onserverclick="cancel_ServerClick"  />
          </div>
    </form>

           
    <div style="position:fixed;bottom:3%; width:100%;">
        <div style="height:15px; background-color:#ccccff; margin:3% 2.5% 1%;"></div>
        <div style="text-align:center; color:#231F20; font-size:13px;">
             Copyright 2017 南京大学信息管理学院 版权所有
        </div>
    </div>
</body>
</html>
