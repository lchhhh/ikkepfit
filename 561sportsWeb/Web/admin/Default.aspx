<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Page-Enter" content="blendTrans(Duration=0.5)" />
    <meta http-equiv="Page-Exit" content="blendTrans(Duration=0.5)" />
    <title>网站后台管理系统</title>
    <link href="../css/main.css" rel="stylesheet" type="text/css" media="all" />
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../js/jquery.index.js" type="text/javascript" ></script>
    <script type="text/javascript">
        $().ready(function () {
            var wWidth = $(window).width();
            var wHeight = $(window).height();
            /*兼容性*/
            if (navigator.appVersion.split("MSIE") && navigator.userAgent.indexOf('Opera') === -1 && parseFloat(navigator.appVersion.split("MSIE")[1]) < 7) wWidth = wWidth - 1; if (window.innerHeight) wHeight = window.innerHeight - 1;
            //$('#workspace').width(wWidth - $('#left').width() - parseInt($('#left').css('margin-right')));
            $('#workspace').height(wHeight - $('#head').height());
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
       <div class="back_nav">
        <div class="back_nav_list">
        </div>
        <div class="shadow">
        </div>
        <div class="close_float">
            <img src="../images/close2.gif" />
        </div>
    </div>
    <div class="model_nav">
        <div class="model_nav_list" id="model_nav_list">
            <ul style="margin-top:2px;"></ul>
        </div>
        <div class="model_float">
            <img src="../images/close2.gif" />
        </div>
    </div>
    <div id="head">
        <div id="logo">
            <span style="display:block; position:relative; width:120px; height:68px; background-image:url('../images/logo.gif');">
                <label style=" position:absolute; width:300px; top:20px; font-family:微软雅黑; font-weight:bold; font-size:30px; color:#1c7ec7; letter-spacing:3px; border:0px;">
                   网站后台管理系统
                </label>
            </span>
        </div>
        <div id="menu">     
             <a href="../default.aspx" id="A8" class="menu_btn1" target="_blank"> 网站预览</a>         
            <a href="logout.aspx" id="A8" class="menu_btn1"> 安全退出</a> 
            <div class="wel">
                <label><img src="../images/admin-ico.gif" /></label>
                <label><b>
                    <asp:Literal ID="lblusername" runat="server"></asp:Literal>
                    (<asp:Literal ID="lbluserrole" runat="server"></asp:Literal>)</b> 您好！</label>
            </div>  
        </div>
        <ul id="nav">
        </ul>
        <div id="headBg">
        </div>
    </div>
    
    <div id="content">
            <table cellspacing="0" cellpadding="0" border="0" width="100%">
            <tr>
                <td width="170" valign="top">
                    <div id="leftMenus">
                       
            

                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('members');">用户管理</a></dt>
                           <div id="members"> 
                               <dd style="display: block;"  ><a href="members/Add.aspx"  target="workspace"  class="">用户添加</a></dd>
                               <dd style="display: block;"><a href="members/List.aspx"  target="workspace" class="">用户管理</a></dd>
                           </div> 
                       </dl>




                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('news');">运动新闻管理</a></dt>
                           <div id="news"> 
                                      <dd style="display: block;"  ><a href="newsType/Add.aspx"  target="workspace"  class="">新闻类别添加</a></dd>
                               <dd style="display: block;"><a href="newsType/List.aspx"  target="workspace" class="">运动新闻管理</a></dd>
                               <dd style="display: block;"  ><a href="news/Add.aspx"  target="workspace"  class="">运动新闻添加</a></dd>
                               <dd style="display: block;"><a href="news/List.aspx"  target="workspace" class="">运动新闻管理</a></dd>
                           </div> 
                       </dl>


                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('plans');">健身方案管理</a></dt>
                           <div id="plans"> 
                               <dd style="display: block;"  ><a href="plansType/Add.aspx"  target="workspace"  class="">健身计划类别添加</a></dd>
                               <dd style="display: block;"><a href="plansType/List.aspx"  target="workspace" class="">健身计划类别管理</a></dd>
                               <dd style="display: block;"  ><a href="plans/Add.aspx"  target="workspace"  class="">健身计划添加</a></dd>
                               <dd style="display: block;"><a href="plans/List.aspx"  target="workspace" class="">健身计划管理</a></dd>
                           </div> 
                       </dl>



                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('selection');">装备选择管理</a></dt>
                           <div id="selection"> 
                               <dd style="display: block;"  ><a href="selection/Add.aspx"  target="workspace"  class="">装备选择添加</a></dd>
                               <dd style="display: block;"><a href="selection/List.aspx"  target="workspace" class="">装备选择管理</a></dd>
                           </div> 
                       </dl>


                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('equip');">运动装备管理</a></dt>
                           <div id="equip"> 
                               <dd style="display: block;"  ><a href="equip/Add.aspx"  target="workspace"  class="">运动装备添加</a></dd>
                               <dd style="display: block;"><a href="equip/List.aspx"  target="workspace" class="">运动装备管理</a></dd>
                           </div> 
                       </dl>

                        
                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('article');">帖子管理</a></dt>
                           <div id="article"> 
                               <dd style="display: block;"><a href="article/List.aspx"  target="workspace" class="">帖子管理</a></dd>
                           </div> 
                       </dl>


                        <dl >
                           <dt><a class="ico1"  href="javascript:;" onclick="show('system');">系统管理</a></dt>
                           <div id="system"> 
                               <dd style="display: block;"  ><a href="system/pass.aspx"  target="workspace"  class="">修改密码</a></dd>
                           </div> 
                       </dl>
 
                    </div>
                </td>
                <td width="1" valign="top">
                    &nbsp;
                </td>
                <td valign="top">
                    <iframe src="members/List.aspx" frameborder="0" width="100%" height="100%" name="workspace" id="workspace">
                    </iframe>
                </td>
            </tr>
        </table>
    </div>

    <SCRIPT language=javascript>
        function show(el) {
            childObj = document.getElementById( el);

            if (childObj.style.display == 'none') {
                childObj.style.display = 'block';
            }
            else {
                childObj.style.display = 'none';
            }
            return;
        }
        </SCRIPT>
    </form>
</body>
</html>

