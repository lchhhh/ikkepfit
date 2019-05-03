<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main" class="page">
    <div id="wrap" class="page-main">

        <div class="my-3 my-md-5">
            <div class="container">
                <div class="jumbotron" style="background-image: url(scripts/66.svg)">
                    <div class="container">
                        <h1 style="font-size: 40px">ikeepfit</h1>
                        <p>——"运  动  让  生  活  更  美  好"</p>
                        <h1></h1>
                        <p><a class="btn btn-primary btn-lg" href="#" role="button">开启你的健身计划</a></p>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6 col-xl-4">
                <div class="card" style="width: 400px; margin: 0px 85px 0px 85px">
                    <div class="card-status bg-blue"></div>
                    <div class="card-header">
                        <div class="row">
                            <h3 class="card-title">健身资讯</h3>
                            <a href="news.aspx" style="font-size: small; margin: 0px 15px 0px 250px">更多+</a>
                        </div>
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

                <div class="card" style="width: 400px; margin: 5px 85px 0px 85px">
                    <div class="card-status bg-blue"></div>
                    <div class="card-header">
                        <div class="row">
                            <h3 class="card-title">健身器械</h3>
                            <a href="zb.aspx" style="font-size: small; margin: 0px 15px 0px 250px">更多+</a>
                        </div>
                    </div>
                    <div class="card-body">
                        <asp:Repeater ID="Repeater4" runat="server">
                            <ItemTemplate>
                                <div class="list-group-item">
                                    <a href="zbView.aspx?id=<%# Eval("id") %>"><%# Eval("title") %></a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>

            </div>

            <div class="col-md-6 col-xl-4">
                <div class="card" style="width: 775px; margin: 0px 85px 0px 30px">
                    <div class="card-status bg-blue"></div>
                    <div class="card-header">
                        <div class="row">
                            <h3 class="card-title" style="margin: 0px 20px 0px 0px">健身计划</h3>
                            <asp:Repeater ID="Repeater5" runat="server">
                                <ItemTemplate>
                                    <a href="planView.aspx?tid=<%# Eval("tid") %>" class="btn btn-sm btn-pill btn-info" style="margin: 0px 5px 0px 10px"><%#Eval("tname") %></a>
                                </ItemTemplate>
                            </asp:Repeater>
                            <a href="plan.aspx" style="font-size: small; margin: 0px 15px 0px 250px">更多+</a>
                        </div>
                    </div>
                    <div class="card-body">

                        <div class="row">
                            <asp:Repeater ID="Repeater3" runat="server">
                                <ItemTemplate>
                                    <div class="col-sm-6">
                                        <div class="card" style="width: 350px;">
                                            <div class="card-body">
                                                <h5 class="card-title"><%# Eval("title") %></h5>
                                                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                                                <p class="card-text text-right" style="font-size: small; color: #808080">——<%#Eval("atime") %></p>
                                                <a href="planView.aspx?id=<%# Eval("pid") %>" class="btn btn-primary">加入计划</a>

                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                    </div>
                </div>
            </div>
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
</asp:Content>
