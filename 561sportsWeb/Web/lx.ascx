<%@ Control Language="C#" AutoEventWireup="true" CodeFile="lx.ascx.cs" Inherits="lx" %>

<div class="row">
    <div class="col-md-6 col-xl-4  float-left">

        <div class="card" style="width: 250px; margin: 30px 85px 0px 75px">
                    <div class="card-status bg-blue"></div>
                    <div class="card-header">
                            <p class="card-title" style="font-size:medium"><strong>健身计划</strong></p>
                    </div>
                    <div class="card-body">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class="list-group-item">
                                    <a href="planView.aspx?id=<%# Eval("pid") %>" class="text-left"><i class="fe fe-thumbs-up"></i> <%# StringOper.Substr( Eval("title").ToString(),15) %>...</a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>

                <div class="card" style="width: 250px; margin: 10px 85px 0px 75px">
                    <div class="card-status bg-blue"></div>
                    <div class="card-header">
                            <p class="card-title" style="font-size:medium"><strong>健身资讯</strong></p>
                    </div>
                    <div class="card-body">
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <div class="list-group-item">
                                    <a href="newView.aspx?id=<%# Eval("nid") %>" class="text-left"><i class="fe fe-star"></i> <%# StringOper.Substr( Eval("title").ToString(),15) %>...</a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>

        </div>

        </div>