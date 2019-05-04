<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="zbView.aspx.cs" Inherits="about" %>

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
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; <a href="#">装备选择详情</a></span></div>
                    <div class="dqwz_contect">
                    	<div class="ntitle">
                        <h3>
                            <asp:Label ID="lbltitle" runat="server" Text=""></asp:Label> </h3>
                        <div class="ninfo">
                            <div style=" text-align:center; padding:5px 0 5px 0;">

&nbsp;&nbsp; 发布时间： 
                                <asp:Label ID="lblatime" runat="server" Text=""></asp:Label>

                                </div>
                        </div>
                        
                        <div class="ncontent" style="text-indent:24px; line-height:29px;">
                         <p class="MsoNormal" style="margin-left:6.0000pt;text-align:left;background:#FFFFFF;">
	<asp:Literal ID="lblmemo" runat="server"></asp:Literal>
</p>
                  
                        </div>
                        
                    </div>
                    <div class="clear"></div>
                    
                    </div>
                    
                </div>
            </div>
        </div>



    </div>
</div>

</asp:Content>

