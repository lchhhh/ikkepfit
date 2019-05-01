<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="plan.aspx.cs" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
<%@ Register Src="~/lx.ascx" TagPrefix="uc1" TagName="lx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
	<div id="wrap">
        <div class="row">
                <uc1:lx runat="server" ID="lx1" />

                <div class="col-md-6 col-xl-4">
                    <div class="card" style="width: 925px; margin: 30px 3px 10px 0px">
                        <div class="card-header">
                            <div class="row">
                                <p style="margin: 0px 20px 0px 0px">
                                    您当前的位置：<span><a href="default.aspx">首页</a> &gt; 健身计划</span>
                                </p>
                            </div>
                        </div>
                        <div class="card-body">
                            <div class="row">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="col-sm-6">
                                        <div class="card" style="width: 350px;">
                                            <div class="card-body">
                                                <h5 class="card-title"><%# Eval("title") %></h5>
                                                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                                                <p class="card-text text-right" style="font-size: small; color: #808080">——<%#Eval("atime") %></p>
                                                <a href="planView.aspx?id=<%# Eval("pid") %>" class="btn btn-primary">加入计划</a>

                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>

                        </div>

                        <div class="showpages">
                            <div class="scott" style="padding-top: 10px;">
                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged" PageIndexBoxType="DropDownList" PageSize="10" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%"></webdiyer:AspNetPager>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

    	<%--<div class="main">
            <uc1:lx runat="server" ID="lx" />

            <div class="main_right">
            	<div class="dqwz">
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; 健身方案</span></div>
                    <div class="dqwz_contect">
                    	<ul>
                             
                        	
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                                 <li><div class="dqwz_text"><a href="planView.aspx?id=<%# Eval("pid") %>">&gt;&gt; <%# Eval("title") %></a><span><%# Eval("atime") %></span></div></li>
                                </ItemTemplate>
                            </asp:Repeater>
                       
                                
                                 
                                
                            
                        </ul>
                        <div class="showpages">
						<div class="scott" style="padding-top: 10px;">
                           
                            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"  PageIndexBoxType="DropDownList" PageSize="10" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%" ></webdiyer:AspNetPager>


                        </div>
                    </div>
                    </div>
                    
                </div>
            </div>
        </div>--%>
    </div>
</div>

</asp:Content>

