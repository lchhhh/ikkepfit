<%@ Page Language="C#" MasterPageFile="~/admin/site.master" AutoEventWireup="true" CodeFile="password.aspx.cs" Inherits="password" ValidateRequest="false"  %>

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
                        <td><label><span id="navTitle">修改密码</span></label></td>
                    </tr>
                </table>
            </td>
            <td align="right">
                <table>
                    <tr>
                        <td><img src="../../images/arrow_left.png" width="16" height="16" /></td>
                        <td><label><a href="Default.aspx" class="sub_menu">返回</a></label></td>
                        <td><label></label></td>
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
    <td  style=" text-align:right; width:30%;">原密码:</td>
        <td class="tbright"><div style="display:inline;float:left;"><asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_pwdTip" style="width:250px; display:inline;float:left; text-align:left;"></div> </td>
    </tr>
    <tr>
        <td  style=" text-align:right; width:30%;">新密码:</td>
        <td class="tbright"><div style="display:inline;float:left;"><asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_TextBox1Tip" style="width:250px; display:inline;float:left; text-align:left;"></div> </td>
    </tr>
        <tr>
        <td  style=" text-align:right; width:30%;">确认密码:</td>
        <td class="tbright"><div style="display:inline;float:left;"><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_TextBox2Tip" style="width:250px; display:inline;float:left; text-align:left;"></div> </td>
    </tr>
            
            <tr>
              <td >&nbsp;</td>
              <td >  
                  <asp:Button ID="btnSave" runat="server" Text="修 改" OnClick="btnSave_Click"  BackColor="#F4FBFF" CssClass="bt"  OnClientClick="return jQuery.formValidator.PageIsValid('1');"></asp:Button>
              </td>
            </tr>
        
          </table>
          

</div>
<span class="frmbar" style="margin:0 11px;"></span><span class="frmbar" style="margin:0 12px;"></span>
</div>
<script language="javascript" type="text/javascript">
    $(document).ready(function () {
        $.formValidator.initConfig({ onError: function (msg) { alert(msg) } });
        $("#ctl00_ContentPlaceHolder1_txt_pwd").formValidator({ onshow: "请输入原密码", onfocus: "原密码不能为空", oncorrect: "密码合法" }).InputValidator({ min: 1, onerror: "原密码不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_TextBox1").formValidator({ onshow: "请输入新密码", onfocus: "新密码不能为空", oncorrect: "密码合法" }).InputValidator({ min: 1, onerror: "新密码不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_TextBox2").formValidator({ onshow: "请输入重复密码", onfocus: "两次密码必须一致哦", oncorrect: "密码合法" }).InputValidator({ min: 1, onerror: "重复密码不能为空,请确认" });
    });
</script>

</asp:Content>


