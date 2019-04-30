<%@ Page Language="C#" MasterPageFile="~/admin/site.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="newsType_Manage" Title="" %>


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
                        <td><label><span id="navTitle">健身资讯管理---资讯类别列表</span></label></td>
                    </tr>
                </table>
            </td>
            <td align="right">
                <table>
                    <tr>
                        <td><img src="../../images/add.png" width="16" height="16" /></td>
                        <td><label><a href="Add.aspx" class="sub_menu">添加</a></label></td>
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
            <td align="center">
                      
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" GridLines="None" AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging">
        <RowStyle Height="25px" HorizontalAlign="Center" />
        <Columns>       
            <asp:BoundField HeaderText="类别名称" DataField="tname" />
            <asp:HyperLinkField DataNavigateUrlFormatString="Edit.aspx?id={0}"  DataNavigateUrlFields="tid" HeaderText="编辑" Text="编辑"  >                
                <ItemStyle Width="50px" />
            </asp:HyperLinkField>   
            <asp:TemplateField HeaderText="删除" >
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False"   CommandName='<%#Eval("tid") %>' OnClick="lnk_Click" Text="删除" OnClientClick='return confirm("您确定要删除此信息么？");'></asp:LinkButton>
                </ItemTemplate>
                <ItemStyle Width="50px" />
            </asp:TemplateField>   
        </Columns>
        <PagerStyle HorizontalAlign="Center" />
    </asp:GridView>

            <table cellSpacing="0" cellPadding="0" width="100%" border="0">
            
            
            </table>
            </td>
            </tr>               
          </table>          

</div>
<span class="frmbar" style="margin:0 11px;"></span><span class="frmbar" style="margin:0 12px;"></span>
</div>
</asp:Content>


