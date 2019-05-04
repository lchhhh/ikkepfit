<%@ Page Language="C#" MasterPageFile="~/admin/site.master" AutoEventWireup="true" CodeFile="Show.aspx.cs" Inherits="members_Detail" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
                        <td><label><span id="navTitle">用户管理---查看用户</span></label></td>
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
	<td height="25" width="20%" align="right">登录名：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbllname" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">登录密码：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblpass" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">昵称：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblmname" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">性别：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblsex" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">联系方式：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbltel" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">头像：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Image ID="imgpic" runat="server" Width="120" Height="120" /></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">注册时间：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblregtime" runat="server" Text=""></asp:Label></td>
	</tr>
            
            <tr>
              <td>&nbsp;</td>
              <td>  
                  <input id="Button1" type="button" value="返回列表" onclick="history.go(-1);"  class="bt" />                  
              </td>
            </tr>
        
          </table>
          

</div>
<span class="frmbar" style="margin:0 11px;"></span><span class="frmbar" style="margin:0 12px;"></span>
</div>
</asp:Content>


