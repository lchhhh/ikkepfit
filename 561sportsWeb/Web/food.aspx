<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="food.aspx.cs" Inherits="about" %>
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
                                    您当前的位置：<span><a href="default.aspx">首页</a> &gt;饮食查询
                                    </span>
                                </p>
                            </div>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="card card-aside">
                                        <img class="card-aside-column" src="../../uploads/<%#Eval("pic")%>" width="100" height="160" />
                                        <div class="card-body d-flex flex-column">
                                            <h4><a href="foodView.aspx?id=<%# Eval("id") %>"><%# Eval("title") %></a></h4>
                                            <div class="text-muted"><%#Eval("fcal") %>卡路里/100g</div>
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


