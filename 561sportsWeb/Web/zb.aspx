<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="zb.aspx.cs" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
<%@ Register Src="~/lx.ascx" TagPrefix="uc1" TagName="lx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
	<div id="wrap">
    	<div class="main">
            <uc1:lx runat="server" ID="lx" />

            <div class="main_right">
            	<div class="dqwz">
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; 装备选择</span></div>
                    <div class="dqwz_contect">
                    	<ul>
                             
                        	
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                                 <li><div class="dqwz_text"><a href="zbView.aspx?id=<%# Eval("id") %>">&gt;&gt; <%# Eval("title") %></a><span><%# Eval("atime") %></span></div></li>
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
        </div>



    </div>
</div>

</asp:Content>

