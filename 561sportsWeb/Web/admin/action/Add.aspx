<%@ Page Language="C#" MasterPageFile="~/admin/site.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" ValidateRequest="false" Inherits="action_Add" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script src="../../js/jquery.js" type="text/javascript"></script>
<script src="../../js/formValidator.js" type="text/javascript"></script>  
<script src="../../js/formValidatorRegex.js" type="text/javascript"></script>
<link href="../../css/validator.css" rel="stylesheet" type="text/css" />

     <link rel="stylesheet" href="../../kindeditor/themes/default/default.css" />
     <link rel="stylesheet" href="../../kindeditor/plugins/code/prettify.css" />
     <script charset="utf-8" src="../../kindeditor/kindeditor.js"></script>
     <script charset="utf-8" src="../../kindeditor/lang/zh_CN.js"></script>
     <script charset="utf-8" src="../../kindeditor/plugins/code/prettify.js"></script>
	<script>
	    KindEditor.ready(function (K) {
	        var editor1 = K.create('#ctl00_ContentPlaceHolder1_Textarea1', {
	            cssPath: '../../kindeditor/plugins/code/prettify.css',
	            uploadJson: '../../kindeditor/asp.net/upload_json.ashx',
	            fileManagerJson: '../../kindeditor/asp.net/file_manager_json.ashx',
	            allowFileManager: true,
	            afterCreate: function () {
	                var self = this;
	                K.ctrl(document, 13, function () {
	                    self.sync();
	                    K('form[name=aspnetForm]')[0].submit();
	                });
	                K.ctrl(self.edit.doc, 13, function () {
	                    self.sync();
	                    K('form[name=aspnetForm]')[0].submit();
	                });
	            }
	        });
	        prettyPrint();
	    });
	</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="frmstatic" style="display:block">
    <span class="frmbar" style="margin:0 12px;"></span><span class="frmbar" style="margin:0 11px;"></span>
    <div class="nav_menu">
        <table cellspacing="0" cellpadding="0" border="0" width="100%">
          <tr>
            <td align="left">
                <table>
                    <tr>
                        <td><img src="../../images/main_home.gif" width="16" height="16" /></td>
                        <td><label><span id="navTitle">动作库管理---添加运动动作</span></label></td>
                    </tr>
                </table>
            </td>
            <td align="right">
                <table>
                    <tr>
                        <td><img src="../../images/arrow_left.png" width="16" height="16" /></td>
                        <td><label><a href="List.aspx" class="sub_menu">返回</a></label></td>
                    </tr>
                </table>
            </td>
          </tr>
        </table>
    </div>
    <span class="frmbar" style="margin:0 11px;"></span><span class="frmbar" style="margin:0 12px;"></span>
</div>

<div class="frmstatic" style="display:block; margin-top:10px;">
<span class="frmbar" style="margin:0 12px;"></span><span class="frmbar" style="margin:0 11px;"></span>
<div class="controls">
            
          <table width="100%"  border="0" align="center" cellpadding="5" cellspacing="1" bgcolor="#ecf5ff">
             <tr>
<td  style=" text-align:right; width:20%;">动作名称:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_title" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_titleTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">动作图片:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:FileUpload ID="fppic" runat="server" Width="250" />支持格式为：.jpg | .gif | .png
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">动作描述:</td>
<td class="tbright"><div style="display:inline;float:left;">
<textarea id="Textarea1" runat="server" cols="100" rows="8" style="width:700px;height:300px;visibility:hidden;"></textarea></div>
 </td></tr>

            
            <tr>
              <td >&nbsp;</td>
              <td >  
                  <asp:Button ID="btnSave" runat="server" Text="添 加" OnClick="btnSave_Click"  BackColor="#F4FBFF" CssClass="bt"  OnClientClick="return jQuery.formValidator.PageIsValid('1');"></asp:Button>
              </td>
            </tr>
        
          </table>
          

</div>
<span class="frmbar" style="margin:0 11px;"></span><span class="frmbar" style="margin:0 12px;"></span>
</div>
<script language="javascript" type="text/javascript">
    $(document).ready(function() {
        $.formValidator.initConfig({ onError: function(msg) { alert(msg) } });
        $("#ctl00_ContentPlaceHolder1_txt_title").formValidator({ onshow: "请输入动作名称", onfocus: "动作名称不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "动作名称不能为空,请确认" });
    });
</script>

</asp:Content>


