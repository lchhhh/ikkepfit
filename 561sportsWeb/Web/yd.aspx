<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="yd.aspx.cs" Inherits="about" %>



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
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; 运动装备</span></div>
                    <div class="dqwz_contect1">
                        <div class="cp">
                    	<ul>
                             
                      <asp:Repeater ID="Repeater1" runat="server">
  <ItemTemplate>
                            
                                    <li style="text-align:center;"><a href="ydView.aspx?id=<%# Eval("id") %>"><img src="uploads/<%# Eval("pic") %>"><br />
                                        <%# Eval("title") %>
                                        </a>
                
              </li>
                        </ItemTemplate>
</asp:Repeater>         
           
                                
                            
                        </ul></div>
                        <div class="showpages">
						<div class="scott" style="padding-top: 10px;">
                           
<webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"  PageIndexBoxType="DropDownList" PageSize="12" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%" ></webdiyer:AspNetPager>

                        </div>
                    </div>
                    </div>
                    
                </div>
            </div>
        </div>



    </div>
</div>

</asp:Content>

