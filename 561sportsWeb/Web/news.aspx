<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="about" %>



<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>
<%@ Register Src="~/nav.ascx" TagPrefix="uc1" TagName="nav" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
        <div id="wrap">
            <div class="row">
                <uc1:nav runat="server" ID="nav" />

                <div class="col-md-6 col-xl-4">
                    <div class="card" style="width: 925px; margin: 30px 3px 10px 0px">
                        <div class="card-header">
                            <div class="row">
                                <p style="margin: 0px 20px 0px 0px">
                                    您当前的位置：<span><a href="default.aspx">首页</a> &gt;
                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal></span>
                                </p>
                            </div>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="card card-aside">
                                        <img class="card-aside-column" src="../../uploads/<%#Eval("bgpic")%>" width="100" height="180" />
                                        <div class="card-body d-flex flex-column">
                                            <h4><a href="newView.aspx?id=<%# Eval("nid") %>"><%# Eval("title") %></a></h4>
                                            <div class="text-muted"><%# StringOper.Substr( Eval("memo").ToString(),30) %></div>
                                            <div class="d-flex align-items-center pt-5 mt-auto">
                                                <div>
                                                    <small class="d-block text-muted"><i class="fe fe-clock"></i><%#Eval("atime") %></small>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </ItemTemplate>
                            </asp:Repeater>
                        </div>

                        <%--                            <div class="list-group">
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <a href="newView.aspx?id=<%# Eval("nid") %>" class="list-group-item">
                                            <h4 class="list-group-item-heading"><%# Eval("title") %></h4>
                                            <p class="list-group-item-text">——<%#Eval("atime") %></p>
                                        </a>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>--%>

                        <%--<asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <div class="col-lg">
                                            <div class="card ">
                                                <div class="card-status card-status-left bg-blue"></div>
                                                <div class="card-body">
                                                    <div class="row">
                                                    <h5 class="card-title"><%# Eval("title") %></h5>
                                                    <p class="card-text text-right" style="font-size: small; color: #808080">——<%#Eval("atime") %></p>
                                                    <a href="newView.aspx?id=<%# Eval("nid") %>" class="btn btn-primary">阅读</a>
                                                        </div>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>--%>


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

 </asp:Content>

