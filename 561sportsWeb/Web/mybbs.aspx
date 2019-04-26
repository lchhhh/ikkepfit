<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="mybbs.aspx.cs" ValidateRequest="false" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
<%@ Register Src="~/lx.ascx" TagPrefix="uc1" TagName="lx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script src="js/jquery.js" type="text/javascript"></script>
<script src="js/formValidator.js" type="text/javascript"></script>  
<script src="js/formValidatorRegex.js" type="text/javascript"></script>
<link href="css/validator.css" rel="stylesheet" type="text/css" />



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
	<div id="wrap">
    	<div class="main">
            <uc1:lx runat="server" ID="lx" />

            <div class="main_right">
            	<div class="dqwz">
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; 我的帖子</span></div>
                    <div class="dqwz_contect">
                    	<ul>
                             
                        	
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                                 <li><div class="dqwz_text">
                                               <a href="bbsView.aspx?id=<%# Eval("aid") %>" title="<%# Eval("title") %>">&gt;&gt;<%# Eval("title") %></a><span>发布人：<%# Eval("lname") %>&nbsp;发布时间：<%# Eval("atime") %>&nbsp;阅读：<%# Eval("total1") %>/回复<b style="color:red"><%# Eval("tt") %></b>&nbsp;&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False"   CommandName='<%#Eval("aid") %>' OnClick="lnk_Click" Text="删除" OnClientClick='return confirm("您确定要删除此信息么？");' style="float:right;"></asp:LinkButton></span></div></li>
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

