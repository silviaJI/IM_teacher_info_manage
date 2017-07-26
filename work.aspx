﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="work.aspx.cs" Inherits="work" %>

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
        
        <table style="width:157px;float:left; margin:3% 3% 5% 5%;">
            
            <tr>
                <td class="left_nav" ><a href="personInfo.aspx">个人信息</a></td>
            </tr>
            <tr>
                <td class="left_nav_active"><a href="work.aspx">著作信息</a></td>
            </tr>
            <tr>
                
                <td class="left_nav" ><a href="award.aspx">获奖信息</a></td>
            </tr>
             <tr>
                 
                <td class="left_nav" ><a href="project.aspx">项目信息</a></td>
            </tr>  
        </table>
        
         <div style="float:right; margin-right:22%; margin-top:1%; margin-bottom:3%;">
                <asp:Label id="Label_search" runat="server" Height="16px">名称关键字：</asp:Label>
				<asp:TextBox id="TextBox_subject" runat="server" Width="120px" Height="23px" AutoPostBack="True"></asp:TextBox>
				<asp:Button id="Button_search" runat="server" Width="64px" Height="22px" Text="查询" OnClick="Button_search_Click"></asp:Button>
         </div>
        
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_Del" AutoGenerateColumns="False" Width="60%" style="margin-top" DataKeyNames="ID" >
                        <Columns>
                            <asp:BoundField HeaderText="论文编号" DataField="ID" Visible="false" />
                            <asp:TemplateField HeaderText="论文名称">
                                <ItemTemplate>
                                    <asp:HyperLink  Target="_blank" ID="HyperLink1" runat="server" NavigateUrl='<%# "work_detail.aspx?id="+DataBinder.Eval(Container.DataItem,"id").ToString()%>'><%# DataBinder.Eval(Container.DataItem,"著作名").ToString()%></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="刊物名称">
                                <ItemTemplate>
                                    <asp:Label ID="work_jour" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "发表期刊或出版社").ToString()%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="分类号">
                                <ItemTemplate>
                                     <asp:Label ID="work_ty" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "分类号").ToString()%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="发表年份">
                                <ItemTemplate>
                                    <asp:Label ID="work_time" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "发表年份").ToString()%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="卷-期-页">
                                <ItemTemplate>
                                    <asp:Label ID="work_page" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "卷期页码").ToString()%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="操作">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="delbutton" runat="server" CommandName="Delete" CausesValidation="false">删除</asp:LinkButton>
                                    </ItemTemplate>
                                
                            </asp:TemplateField>
                        </Columns>
         </asp:GridView>
          <div style="clear:both;"></div>
          <div style="margin:3% 40% 3% 45%;">
            <input id="lbtnDel" type="button"  value="添加" class="btn" onserverclick="Button1_ServerClick" runat="server"/>&nbsp;
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
