<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="bbsView.aspx.cs" ValidateRequest="false" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
<%@ Register Src="~/lx.ascx" TagPrefix="uc1" TagName="lx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script src="js/jquery.js" type="text/javascript"></script>
<script src="js/formValidator.js" type="text/javascript"></script>  
<script src="js/formValidatorRegex.js" type="text/javascript"></script>
<link href="css/validator.css" rel="stylesheet" type="text/css" />
    
        <link rel="stylesheet" href="kindeditor/themes/default/default.css" />
		<script charset="utf-8" src="kindeditor/kindeditor-min.js"></script>
		<script charset="utf-8" src="kindeditor/lang/zh_CN.js"></script>
		<script>
			var editor;
			KindEditor.ready(function(K) {
				editor = K.create('#ctl00_ContentPlaceHolder1_Textarea1', {
					resizeType : 1,
					allowPreviewEmoticons : false,
					allowImageUpload : false,
					items : [
						'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
						'removeformat', '|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
						'insertunorderedlist', '|', 'emoticons', 'image', 'link']
				});
			});
		</script>
                   <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
	<div id="wrap">
    	<div class="main">
            <uc1:lx runat="server" ID="lx" />

            <div class="main_right">
            	<div class="dqwz">
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; 帖子详情</span></div>
                    <div class="dqwz_contect">             
                        <div class="showpages">
                            <table class="auto-style1">
    
                             <tr>
                                 <td style="font-size:16px; font-weight:bold;" width="60%"><asp:Literal ID="Literal1" runat="server"></asp:Literal></td>
                                 <td align="right">回复：<Font style="color:red"><asp:Literal ID="Literal2" runat="server"></asp:Literal></Font> &nbsp; &nbsp; 浏览人次：<asp:Literal ID="Literal3" runat="server"></asp:Literal></td>
                             </tr>
                             <tr>
                                 <td colspan="2">

                                 <asp:Repeater ID="Repeater1" runat="server">
                                     <ItemTemplate>
                                                   <table class="auto-style1" style="border-bottom-style: dashed; border-bottom-width:1px; border-bottom-color: #339933">
                                         <tr>
                                             <td rowspan="2" width="120" valign="top" align="center">
<img width="100" height="120" src="uploads/<%#Eval("pic") %>" /><br />
                           <table  width="100%" style=" margin-left:8px;" >
          <tr>
            <td align="center">
                <%#Eval("mname") %></td>
        </tr>

    </table>
                                             </td>
                                             <td><%#Eval("memo") %></td>
                                         </tr>
                                         <tr>
                                             <td align="right" height="24p"><%#Eval("atime") %></td>
                                         </tr>
                                     </table>
                                     </ItemTemplate>
                                 </asp:Repeater>

                                 </td>
                             </tr>
                           <tr>
                                 <td colspan="2">
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"  PageIndexBoxType="DropDownList" PageSize="10" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%" ></webdiyer:AspNetPager> </td></tr>

                          <tr>
                                 <td colspan="2">
                                    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#BBD3EB">       
        <tr>       
        <td align="center" bgcolor="#FFFFFF">
            <table style="width: 100%;line-height:25px;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">                
                <table cellSpacing="0" cellPadding="0" width="100%" border="0">
    
<tr>
<td  style=" text-align:right; width:10%;">内容:</td>
<td class="tbright"><div style="display:inline;float:left;">
<textarea id="Textarea1" runat="server" cols="100" rows="8" style="width:100%;height:150px;visibility:hidden;"></textarea></div>
 </td></tr>




                </table>
            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">  
                <asp:Button ID="Button1" runat="server" Text=" 回 复" OnClick="btnSave_Click" class="inputbutton" ></asp:Button>

            </td>
        </tr>
    </table>
        </td>
        </tr>       
    </table> </td></tr>
                         </table>
                    </div>
                    </div>
                    
                </div>
            </div>
        </div>



    </div>
</div>

</asp:Content>

