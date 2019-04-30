<%@ Page Language="C#" MasterPageFile="~/admin/site.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" ValidateRequest="false" Inherits="members_Add" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script src="../../js/jquery.js" type="text/javascript"></script>
<script src="../../js/formValidator.js" type="text/javascript"></script>  
<script src="../../js/formValidatorRegex.js" type="text/javascript"></script>
<link href="../../css/validator.css" rel="stylesheet" type="text/css" />


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
                        <td><label><span id="navTitle">用户管理---添加用户</span></label></td>
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
<td  style=" text-align:right; width:20%;">登录名:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_lname" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_lnameTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">登录密码:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_pass" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_passTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">昵称:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_mname" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_mnameTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">性别:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:RadioButtonList ID="rtsex" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem Selected="True">男</asp:ListItem>
    <asp:ListItem>女</asp:ListItem>
</asp:RadioButtonList>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">联系方式:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_tel" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_telTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">头像:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:FileUpload ID="fppic" runat="server" Width="250" />支持格式为：.jpg | .gif | .png
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
        $("#ctl00_ContentPlaceHolder1_txt_lname").formValidator({ onshow: "请输入登录名", onfocus: "登录名不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "登录名不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_pass").formValidator({ onshow: "请输入登录密码", onfocus: "登录密码不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "登录密码不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_mname").formValidator({ onshow: "请输入昵称", onfocus: "昵称不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "昵称不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_tel").formValidator({ onshow: "请输入联系方式", onfocus: "联系方式不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "联系方式不能为空,请确认" });
    });
</script>

</asp:Content>


