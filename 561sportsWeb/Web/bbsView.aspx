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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="main">
        <div id="wrap">
            <div class="main">
                <div class="row">
                    <uc1:lx runat="server" ID="lx" />
                    <div class="col-lg">
                        <div class="card" style="width: 925px; margin: 30px 3px 10px 0px">
                            <div class="card-status bg-blue"></div>
                            <div class="card-header">
                                <h4 style="margin: 0px 30px 0px 0px"><asp:Literal ID="Literal1" runat="server"></asp:Literal></h4>
                                <h6 style="margin: 0px 30px 0px 0px;color:#49a6ff"><i class="fe fe-edit"></i>评论 <asp:Literal ID="Literal2" runat="server"></asp:Literal></h6>
                                <h6 style="margin: 0px 30px 0px 0px;color:#49a6ff"><i class="fe fe-eye"></i>浏览 <asp:Literal ID="Literal3" runat="server"></asp:Literal></h6>
                            </div>
                            <div class="card-body">
                                <p><asp:Literal ID="Literal4" runat="server"></asp:Literal></p>
                            </div>
                        </div>

                        <div class="card" style="width: 925px; margin: 10px 3px 10px 0px">
                            <div class="card-status bg-blue"></div>
                            <div class="card-header">
                                <h6 style="margin: 0px 30px 0px 0px;color:#49a6ff"><i class="fe fe-edit"></i>评论区</h6>
                                </div>
                            <div class="card-body">
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <table class="row table card-table">
                                            <tr>
                                            <td class="text-center" style="margin:0px 20px 0px 0px">
                                                <div class="avatar d-block avatar-md" style="background-image: url(uploads/<%#Eval("mpic")%>)">
                                                    <span class="avatar-status bg-green"></span>
                                                </div>
                                            </td>
                                            <td>
                                                <div><%#Eval("rmemo") %></div>
                                                <div class="small text-muted">
                                                    <%#Eval("mname") %> ——<%#Eval("regtime") %>
                                                </div>
                                                </td>
                                                </tr>
                                            </table>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <form action="" style="margin:50px 0px 0px 0px">
                                    <div class="form-group">
                                        <div class="row align-items-center">
                                            <div class="col-sm-10">
                                                <textarea id="Textarea1" runat="server" cols="100" rows="8" style="width: 100%; height: 200px; visibility: hidden;"></textarea>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="btn-list mt-4 text-left">
                                        <asp:Button ID="Button1" runat="server" Text="发布评论" OnClick="btnSave_Click" class="btn btn-primary btn-space" />
                                    </div>
                                </form>
                            </div>
                        </div>
                                <tr>
                                    <td colspan="2">
                                        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged" PageIndexBoxType="DropDownList" PageSize="10" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%"></webdiyer:AspNetPager>
                                    </td>
                                </tr>


                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

