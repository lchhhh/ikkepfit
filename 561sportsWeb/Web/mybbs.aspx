<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="mybbs.aspx.cs" ValidateRequest="false" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
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
                <div class="row">
                <uc1:lx runat="server" ID="lx" />

                            <div class="col-md-6 col-xl-4">
                <div class="card" style="width: 925px; margin: 30px 3px 10px 0px">
                    <div class="card-header">
                        <div class="row">
                            <p style="margin: 0px 20px 0px 0px">
                                您当前的位置：<span><a href="bbsAdd.aspx">首页</a> &gt;健身小红书</span>
                            </p>
                        </div>
                    </div>
                    <div class="card-body">
                        <a href="bbsAdd.aspx" class="btn btn-pill btn-primary" style="margin: 0px 0px 25px 0px">+发布小红书</a>
                        <div class="row">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="card card-aside">
                                        <img class="card-aside-column" src="../../uploads/<%#Eval("pic")%>" width="100" height="180" />
                                        <div class="card-body d-flex flex-column">
                                            <h4><a href="bbsView.aspx?id=<%# Eval("aid") %>"><%# Eval("title") %></a></h4>
                                            <div class="text-muted"><%# StringOper.Substr( Eval("memo").ToString(),180) %></div>
                                            <div class="d-flex align-items-center pt-5 mt-auto">
                                                <div>
                                                    <small class="d-block text-muted"><i class="fe fe-user"></i><%#Eval("lname") %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="fe fe-clock"></i><%#Eval("atime") %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="fe fe-eye"></i><%#Eval("total1") %></small>
                                                </div>
                                            </div>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName='<%#Eval("aid") %>' OnClick="lnk_Click" Text="删除" OnClientClick='return confirm("您确定要删除此信息么？");' Style="float: right;"></asp:LinkButton>
                                        </div>
                                    </div>

                                </ItemTemplate>
                            </asp:Repeater>
                        </div>

                        <div class="showpages">
                            <div class="scott" style="padding-top: 10px;">
                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged" PageIndexBoxType="DropDownList" PageSize="10" PrevPageText="上一页" ShowPageIndexBox="Always" Width="90%"></webdiyer:AspNetPager>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
            </div>
          </div>
        </div>
    </div>

</asp:Content>

