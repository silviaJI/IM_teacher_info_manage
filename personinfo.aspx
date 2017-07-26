<%@ Page Language="C#" AutoEventWireup="true" CodeFile="personinfo.aspx.cs" Inherits="personinfo" %>

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
    .btn{float:left;margin-left:30px; width:60px;height:35px;font-size:15px;}
    .inputbox{background-color:inherit; border:0; width:90%; margin-left:1%;}
     td label{margin:1%;}
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
                                <a style="margin-left:20px;" href="logout.aspx" onclick="return confirm('确定要退出吗？')">退出系统</a></td>
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
        <table style="width:157px;float:left; margin:3% 3% 5% 5%;">
            
            <tr>
                <td class="left_nav_active" ><a href="personInfo.aspx">个人信息</a></td>
            </tr>
            <tr>
                <td class="left_nav"><a href="work.aspx">著作信息</a></td>
            </tr>
            <tr>
                
                <td class="left_nav" ><a href="award.aspx">获奖信息</a></td>
            </tr>
             <tr>
                 
                <td class="left_nav" ><a href="project.aspx">项目信息</a></td>
            </tr>  
        </table>
        
         <table width="60%" style="float:left; margin-top:3%;">
                        
                        <tr>
                            <td style="width: 122px; background-color: #ccccff;">
                                姓名：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="name" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 122px; background-color: #ccccff;">
                                工号：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="id" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 122px; background-color: #ccccff;">
                                性别：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="sex" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 122px; background-color: #ccccff;">
                                职称：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="prof_title" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 122px; background-color: #ccccff;">
                                职位：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="post" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 122px; background-color: #ccccff;">
                                系别：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="dept" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 122px; background-color: #ccccff;">
                                办公室：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="office" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 122px; background-color: #ccccff;">
                                邮箱：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="email" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 122px; background-color: #ccccff;">
                                办公电话：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="worktel" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                           
                            <td style="width: 122px; background-color: #ccccff;">
                                手机号码：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="tel" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 122px; background-color: #ccccff;">
                                开放咨询时间：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <asp:Label ID="opentime" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            
                            <td style="width: 122px; background-color: #ccccff;">
                                研究领域：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="field" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>                                                       
                        </tr>
                        <tr>
                           
                            <td style="width: 122px; background-color: #ccccff;">
                                教育背景：</td>
                            <td style="width: 246px; background-color: #ccccff;">
                                <input id="edu_bg" type="text" value="" class="inputbox" disabled="disabled" runat="server" /></td>                                                       
                        </tr>
                    </table>
                    <div style="clear:both;"></div>
                    <div style="margin:3% 40% 3% 45%;">
                        <input id="change" type="button"  value="修改" class="btn" style="display:inline;" onclick="return change_onclick()"/>
                        <input id="confirm" type="button"  value="确定" class="btn" style="display:none;" runat="server" onserverclick="confirm_ServerClick" />
                        <input id="cancel" type="button"  value="取消" class="btn" style="display:none;" runat="server" onserverclick="cancel_ServerClick" />
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
