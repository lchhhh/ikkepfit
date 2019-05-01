<%@ Page Language="C#" MasterPageFile="~/admin/site.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="newsType_Modify" ValidateRequest="false" Title="" %>

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
                        <td><label><span id="navTitle">健身资讯管理---编辑资讯类别</span></label></td>
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
<td  style=" text-align:right; width:20%;">类别名称:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_tname" runat="server" width="200"></asp:TextBox></div><div id="ctl00_ContentPlaceHolder1_txt_tnameTip" style="width:250px;display:inline;float:left;text-align:left;"></div>
 </td></tr>

            
            <tr>
              <td >&nbsp;</td>
              <td >  
                  <asp:Button ID="btnSave" runat="server" Text="编 辑" OnClick="btnSave_Click"  BackColor="#F4FBFF" CssClass="bt" OnClientClick="return jQuery.formValidator.PageIsValid('1');"></asp:Button>
              </td>
            </tr>
        
          </table>
          

</div>
<span class="frmbar" style="margin:0 11px;"></span><span class="frmbar" style="margin:0 12px;"></span>
</div>
<script language="javascript" type="text/javascript">
    $(document).ready(function() {
        $.formValidator.initConfig({ onError: function(msg) { alert(msg) } });
        $("#ctl00_ContentPlaceHolder1_txt_tname").formValidator({ onshow: "请输入类别名称", onfocus: "类别名称不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "类别名称不能为空,请确认" });
    });
</script>

</asp:Content>


