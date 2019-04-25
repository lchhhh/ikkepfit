<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg" %>

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
                	<div class="dqwz_title"><p>您当前的位置：</p><span><a href="default.aspx">首页</a> &gt; <a href="#">用户注册</a></span></div>
                    <div class="dqwz_contect">
                    	<div class="ntitle">
                        <h3>
                            <asp:Label ID="lblkeys" runat="server" Text="用户注册"></asp:Label></h3>
                        <div class="ninfo">
                            <div style=" text-align:center; padding:5px 0 5px 0;">
                                </div>
                        </div>
                        
                        <div class="ncontent" style="text-indent:24px; line-height:29px;">
                         <p class="MsoNormal" style="margin-left:6.0000pt;text-align:left;background:#FFFFFF;">
	
<table width="100%"  border="0" align="center" cellpadding="5" cellspacing="1" style="font-size:12px;">
             <tr>
<td  style=" text-align:right; width:20%;">登录名:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_lname" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_lnameTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">登录密码:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_pass" runat="server" width="200" TextMode="Password"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_passTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">重复密码:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_pass2" runat="server" width="200" TextMode="Password"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_pass2Tip" style="width:250px;display:inline;float:left;text-align:left;"></div>
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
                  <asp:Button ID="btnSave" runat="server" Text="注  册" Width="70" Height="25" OnClick="btnSave_Click"  BackColor="#F4FBFF" CssClass="bt"  OnClientClick="return jQuery.formValidator.PageIsValid('1');"></asp:Button>
              </td>
            </tr>
        
          </table>
<script language="javascript" type="text/javascript">
    $(document).ready(function() {
        $.formValidator.initConfig({ onError: function(msg) { alert(msg) } });
        $("#ctl00_ContentPlaceHolder1_txt_lname").formValidator({ onshow: "请输入登录名", onfocus: "登录名不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "登录名不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_pass").formValidator({ onshow: "请输入登录密码", onfocus: "登录密码不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "登录密码不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_pass2").formValidator({ onshow: "请输入重复密码", onfocus: "重复密码不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "重复密码不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_mname").formValidator({ onshow: "请输入昵称", onfocus: "昵称不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "昵称不能为空,请确认" });
        $("#ctl00_ContentPlaceHolder1_txt_tel").formValidator({ onshow: "请输入联系方式", onfocus: "联系方式不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "联系方式不能为空,请确认" });
    });
</script>

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

