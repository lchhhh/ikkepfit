<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="bbsAdd.aspx.cs" ValidateRequest="false" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
<%@ Register Src="~/lx.ascx" TagPrefix="uc1" TagName="lx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script src="js/jquery.js" type="text/javascript"></script>
<script src="js/formValidator.js" type="text/javascript"></script>  
<script src="js/formValidatorRegex.js" type="text/javascript"></script>
<link href="css/validator.css" rel="stylesheet" type="text/css" />
    
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
                                <h4 style="margin: 0px 30px 0px 0px">发布小红书</h4>
                                <asp:Label ID="lblatime" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="card-body">
                                <form action="">
                                    <div class="form-group">
                                        <div class="row align-items-center">
                                            <label class="col-sm-2">主题：</label>
                                            <div class="col-sm-10">
                                                <asp:TextBox ID="txt_title" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="row align-items-center">
                                            <label class="col-sm-2">图片:</label>
                                            <div class="col-sm-10">
                                                <i class="fe fe-upload mr-2">
                                                <asp:FileUpload ID="fppic" runat="server" Width="250"/></i>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="row align-items-center">
                                            <label class="col-sm-2">内容：</label>
                                            <div class="col-sm-10">
                                                <textarea id="Textarea1" runat="server" cols="100" rows="8" style="width: 100%; height: 500px; visibility: hidden;"></textarea>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="btn-list mt-4 text-right">
                                        <a href="bbs.aspx" class="btn btn-secondary">取消</a>
                                        <asp:Button ID="btnPass" runat="server" Text="发布" OnClick="btnMess_Click" OnClientClick="return jQuery.formValidator.PageIsValid('1'); " class="btn btn-primary btn-space" />
                                    </div>
                                </form>
                            </div>
                            </div>
                        </div>
                    </div>

                    <script language="javascript" type="text/javascript">
                        $(document).ready(function () {
                            $.formValidator.initConfig({ onError: function (msg) { alert(msg) } });
                            $("#ctl00_ContentPlaceHolder1_txt_title").formValidator({ onshow: "请输入主题", onfocus: "主题不能为空", oncorrect: "合法" }).InputValidator({ min: 1, onerror: "主题不能为空,请确认" });
                        });
</script>
                </div>
            </div>

        </div>

</asp:Content>

