<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main" class="page">
        <div id="wrap" class="page-main">
            <div class="row">
                <div class="col-md-6 col-xl-4">
                    <div class="card" style="width: 400px; margin: 0px 85px 0px 85px">
                        <div class="card">
                            <div class="card-status bg-blue"></div>
                            <div class="card-header">
                                <h3 class="card-title">健身资讯</h3>
                            </div>
                            <div class="card-body">
                                <asp:Repeater ID="Repeater2" runat="server">
                                    <ItemTemplate>
                                        <div class="list-group-item">
                                            <a href="newView.aspx?id=<%# Eval("nid") %>" class="text-left"><%# Eval("title") %></a>
                                            <a class="badge badge-warning text-right">资讯</a>
                                            </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-xl-4">
                    <div class="card" style="width: 400px; margin: 0px 85px 0px 85px">
                        <div class="card">
                            <div class="card-status bg-blue"></div>
                            <div class="card-header">
                                <h3 class="card-title">健身计划</h3>
                            </div>
                            <div class="card-body">
                                <asp:Repeater ID="Repeater3" runat="server">
                                    <ItemTemplate>
                                        <li class="card-body"><a href="planView.aspx?id=<%# Eval("pid") %>"><%# Eval("title") %></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <%--<div class="dbzz">

                <div class="gszc_title">
                    <p>健身方案</p>
                    <div class="more1"><a href="plan.aspx">more</a></div>
                </div>
                <div class="gszc_contect" style="height: 356px; font-size: small;">
                    <ul>

                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="planView.aspx?id=<%# Eval("pid") %>"><%# Eval("title") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>



                    </ul>
                </div>
            </div>--%>

            <div class="kjfw">

                <div class="gszc_title">
                    <p>装备选择</p>
                    <div class="more1"><a href="zb.aspx">more</a></div>
                </div>
                <div class="gszc_contect" style="height: 356px; font-size: small;">
                    <ul>



                        <asp:Repeater ID="Repeater4" runat="server">
                            <ItemTemplate>
                                <li><a href="zbView.aspx?id=<%# Eval("id") %>"><%# Eval("title") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>

                    </ul>
                </div>
            </div>

            <div class="box">

                <div class="bd">
                    <div class="tempWrap" style="overflow: hidden; position: relative; width: 966px">
                        <div class="tempWrap" style="overflow: hidden; position: relative; width: 966px">
                            <ul style="width: 3312px; position: relative; overflow: hidden; padding: 0px; margin: 0px; left: -1876px;">
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <li class="clone" style="float: left; width: 136px; text-align: center;"><a href="ydView.aspx?id=<%# Eval("id") %>">
                                            <img src="uploads/<%# Eval("pic") %>" width="136" height="136"></a><br>
                                            <a href="ydView.aspx?id=<%# Eval("id") %>"><%# StringOper.Substr( Eval("title").ToString(),6) %></a>
                                        </li>

                                    </ItemTemplate>
                                </asp:Repeater>





                            </ul>
                        </div>
                    </div>
                </div>

            </div>
            <script>
                jQuery(".box").slide({ mainCell: ".bd ul", autoPlay: true, effect: "leftMarquee", vis: 7, interTime: 50, trigger: "click" });
            </script>




            <div class="tu1">
                <img src="/templates/zhiyu/images/tu1.jpg" width="997" height="17">
            </div>
        </div>
    </div>
</asp:Content>
