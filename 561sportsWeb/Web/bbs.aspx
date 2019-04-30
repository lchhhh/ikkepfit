<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="bbs.aspx.cs" ValidateRequest="false" Inherits="about" %>



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


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
	<div id="wrap">
    	<div class="main">
            <uc1:lx runat="server" ID="lx" />

            <div class="main_right">
            	<div class="dqwz">
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; 论坛</span></div>
                    <div class="dqwz_contect">
                    	<ul>
                             
                        	
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                                 <li><div class="dqwz_text">
                                               <a href="bbsView.aspx?id=<%# Eval("aid") %>" title="<%# Eval("title") %>">&gt;&gt;<%# Eval("title") %></a><span>发布人：<%# Eval("lname") %>&nbsp;发布时间：<%# Eval("atime") %>&nbsp;阅读：<%# Eval("total1") %>/回复<b style="color:red"><%# Eval("tt") %></b></span></div></li>
                                </ItemTemplate>
                            </asp:Repeater>
                       
                                
                                 
                                
                            
                        </ul>
                        <div class="showpages">
						<div class="scott" style="padding-top: 10px;">
                           
                            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"  PageIndexBoxType="DropDownList" PageSize="10" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%" ></webdiyer:AspNetPager>


                        </div>
                                        <table width="95%" >
<tr>
    <td  style=" text-align:right; width:20%;">主题:</td>
        <td class="tbright"><div style="display:inline;float:left;"><asp:TextBox ID="txt_title" runat="server" ></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_titleTip" style="width:250px; display:inline;float:left; text-align:left;"></div> </td>
    </tr>
    <tr>
        <td  style=" text-align:right; width:20%;">内容:</td>
        <td class="tbright"><div style="display:inline;float:left;"><textarea id="Textarea1" runat="server" cols="100" rows="8" style="width:100%; height:200px; visibility:hidden;"></textarea></div> </td>
    </tr>
<tr>
<td  style=" text-align:right; width:20%;"></td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:Button ID="btnPass" runat="server"  Text=" 发 表 "   OnClick="btnMess_Click"  OnClientClick="return jQuery.formValidator.PageIsValid('1'); "  /></div>
 </td></tr>

 </table>

<script language="javascript" type="text/javascript">
    $(document).ready(function () {
        $.formValidator.initConfig({ onError: function (msg) { alert(msg) } });
        $("#ctl00_ContentPlaceHolder1_txt_title").formValidator({ onshow: "请输入主题", onfocus: "主题不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "主题不能为空,请确认" });
    });
</script>
                    </div>
                    </div>
                    
                </div>
            </div>
        </div>



    </div>
</div>

</asp:Content>

