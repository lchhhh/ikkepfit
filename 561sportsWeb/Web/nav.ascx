<%@ Control Language="C#" AutoEventWireup="true" CodeFile="nav.ascx.cs" Inherits="nav" %>
<div class="main_left">

                	<div class="qyzz">
        			<div class="qyzz_title"><p>新闻类别</p></div>
            		<div class="qyzz_contect">
            			<ul>
                             
                            
                       
                        
                            <asp:Repeater ID="Repeater3" runat="server">
                                <ItemTemplate>
                                    	<li><a href="news.aspx?tid=<%# Eval("tid") %>"><%# Eval("tname") %></a></li>
                                </ItemTemplate>
                            </asp:Repeater>
                    		
                		</ul>
            		</div>
        		</div>

            	<div class="qyzz" style="margin-top:10px;">
        			<div class="qyzz_title"><p>健身方案</p></div>
            		<div class="qyzz_contect">
            			<ul>
                             
                            
                       
                        
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    	<li><a href="planView.aspx?id=<%# Eval("pid") %>"><%# StringOper.Substr( Eval("title").ToString(),15) %></a></li>
                                </ItemTemplate>
                            </asp:Repeater>
                    		
                		</ul>
            		</div>
        		</div>

                <div class="lxwm1" style="margin-top:10px;">
                    <div class="lxwm1_title"><p>运动新闻</p></div>
                    <div class="qyzz_contect">
            			<ul>
                             
                      <asp:Repeater ID="Repeater2" runat="server">
                           <ItemTemplate>
                               
                            	<li><a href="newView.aspx?id=<%# Eval("nid") %>"><%# StringOper.Substr( Eval("title").ToString(),15) %></a></li>
                           </ItemTemplate>
                        </asp:Repeater>
                        
                		
                    		
                		</ul>
            		</div>
                </div>
            </div>