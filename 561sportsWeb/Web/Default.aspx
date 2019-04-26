<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
	<div id="wrap">

        
        
        <div class="gszc">
            
        	<div class="gszc_title"><p>运动新闻</p><div class="more1"><a href="news.aspx">more</a></div></div>
            <div class="gszc_contect" style="height:356px;font-size:small;">
            	<ul>
                    
                           
                    <asp:Repeater ID="Repeater2" runat="server" >
                        <ItemTemplate>
                             	<li><a href="newView.aspx?id=<%# Eval("nid") %>"><%# Eval("title") %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
           
                        
                   
                </ul>
            </div>
        </div>

        <div class="dbzz">
            
        	<div class="gszc_title"><p>健身方案</p><div class="more1"><a href="plan.aspx">more</a></div></div>
            <div class="gszc_contect"  style="height:356px;font-size:small;">
            	<ul>
                    
                         <asp:Repeater ID="Repeater3" runat="server">
                        <ItemTemplate>
                             	<li><a href="planView.aspx?id=<%# Eval("pid") %>"><%# Eval("title") %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
              
                        
                   
                </ul>
            </div>
        </div>

        <div class="kjfw">
            
        	<div class="gszc_title"><p>装备选择</p><div class="more1"><a href="zb.aspx">more</a></div></div>
            <div class="gszc_contect"  style="height:356px;font-size:small;">
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
            <div class="tempWrap" style="overflow:hidden; position:relative; width:966px">
                <div class="tempWrap" style="overflow:hidden; position:relative; width:966px"><ul style="width: 3312px; position: relative; overflow: hidden; padding: 0px; margin: 0px; left: -1876px;">
                    <asp:Repeater ID="Repeater1" runat="server">
  <ItemTemplate>
                    <li class="clone" style="float: left; width: 136px; text-align:center;"><a href="ydView.aspx?id=<%# Eval("id") %>"><img src="uploads/<%# Eval("pic") %>" width="136" height="136"></a><br>
<a href="ydView.aspx?id=<%# Eval("id") %>"><%# StringOper.Substr( Eval("title").ToString(),6) %></a>
</li>
                    
        </ItemTemplate>
</asp:Repeater>
                        
                
            


                                                                                              </ul></div></div>
            </div>
           
        </div>
        <script>
            jQuery(".box").slide({ mainCell: ".bd ul", autoPlay: true, effect: "leftMarquee", vis: 7, interTime: 50, trigger: "click" });
        </script>
        
        

        
        <div class="tu1"><img src="/templates/zhiyu/images/tu1.jpg" width="997" height="17"></div>
    </div>
</div>
</asp:Content>
