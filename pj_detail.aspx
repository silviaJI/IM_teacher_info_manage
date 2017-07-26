<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pj_detail.aspx.cs" Inherits="pj_detail" %>

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
    .inputbox{background-color:inherit; border:0;margin-left:1%; width: 80%; margin-top:1%; margin-bottom:1%; }
    </style>
<script language="javascript" type="text/javascript">
// <!CDATA[

function change_onclick() {
    var obj = document.getElementsByClassName("inputbox");
    for(i = 0; i < obj.length; i++){
     obj[i].disabled="";
     obj[i].style="background-color:white; border:1; width:90%; margin-left:1%;";
    }
   var confirmbtn = document.getElementById("confirm");
    var cancelbtn = document.getElementById("cancel");
    var changebtn = document.getElementById("change");
    
    confirmbtn.style="display:inline;";
    cancelbtn.style="display:inline;";
    changebtn.style="display:none;";
    
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
                                项目名称：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_name" type="text" value="" class="inputbox" disabled="disabled" runat="server"  /></td>
                        </tr>
                        <tr>
                            <td style="width: 98px; background-color: #ccccff;">
                                教师姓名：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_tea" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                            <td style="width: 98px; background-color: #ccccff;">
                                项目来源：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_source" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                立项时间：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_pretime" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                研制时间段：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_time" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                项目金额：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_money" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 98px; background-color: #ccccff;">
                                来源部门：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_sour_depart" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 98px; background-color: #ccccff;">
                                合作部门：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_co_depart" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                项目成员：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_memb" type="text" value="" class="inputbox" disabled="disabled" runat="server"  /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 98px; background-color: #ccccff;">
                                备注：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="pj_remark" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                    </table>
          </div>
          <div style="margin:3% 40% 3% 45%;">
                 <input id="change" type="button"  value="修改" class="btn" onclick="return change_onclick()"/>
                 <input id="confirm" type="button"  value="确定" class="btn" style="display:none" runat="server" onserverclick="confirm_ServerClick" />
                 <input id="cancel" type="button"  value="取消" class="btn" style="display:none" runat="server" onserverclick="cancel_ServerClick" />
          </div>
    </form>

           
    <div style="clear:both;"></div>
     <div style="position:fixed;bottom:3%; width:100%;">
        <div style="height:15px; background-color:#ccccff; margin:3% 2.5% 1%;"></div>
        <div style="text-align:center; color:#231F20; font-size:13px;">
             Copyright 2017 南京大学信息管理学院 版权所有
        </div>
    </div>
</body>
</html>