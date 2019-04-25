<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="login.aspx.cs" Inherits="_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Page-Enter" content="blendTrans(Duration=0.5)" />
    <meta http-equiv="Page-Exit" content="blendTrans(Duration=0.5)" />
    <title>管理登录</title>
    <link href="../css/login.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2.min.js"></script>
    <script src="../js/keyboard.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
        function CheckForm() {
            if ($('#username').val() == '') {
                alert('请填写会员名');
                $('#username').focus();
                return false;
            }
            if ($('#password').val() == '') {
                alert('请填写密码');
                $('#password').focus();
                return false;
            }
          
            return true;
        }
</script>
</head>
<body>
    <div class="FirstDIV"></div>
<div class="SecondDIV">
    <div align="left">
    
   <form id="form2" runat="server">
  
    <!-- start main -->
    <table align="center" cellpadding="0" cellspacing="0" width="400">
        <tr>
            <td>
                <div class="msg">
                    <div class="head">
                        <div class="mr">
                            &nbsp;</div>
                        <div class="ml">
                            管理员登录 <asp:Literal ID="litIP" runat="server"></asp:Literal></div>
                    </div>
                    <div class="content" >
                        <table cellpadding="2" cellspacing="1" width="100%">
                            <tr>
                                <td colspan="2" height="50">
                                        <img style="border:0px;" height="30" src="../images/login/spacer.gif" width="290" />
                                </td>
                            </tr>
                            <tr>
                                <td class="tip" colspan="2" height="20">
                                    <img src="../images/login/lock.gif" />
                                    您尚未登录或登录超时，请登录后继续操作...
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;账&nbsp;&nbsp;&nbsp;号
                                </td>
                                <td>
                                    <input id="username" class="inp" name="username" runat="server" style="width: 140px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;密&nbsp;&nbsp;&nbsp;码
                                </td>
                                <td>
                                    <input id="password" class="inp" name="password"  runat="server" style="width: 140px" type="password" value="" />&nbsp;
                                    <img class="style1" onclick="SoftKeyboard('password');" src="../images/login/keyboard.gif"
                                        title="密码键盘" />
                                    <div id="kb" style="display: none">
                                    </div>
                                </td>
                            </tr>
                            
                            
                            <tr>
                                <td>
                                </td>
                                <td>
                                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn" Text=" 登 录 " OnClientClick="return CheckForm();" onclick="btnSubmit_Click" />
                                    &nbsp;&nbsp;<input class="btn" name="reset" type="reset" value=" 重 置 " />
                                </td>
                            </tr>

                            <script type="text/javascript">
                                if (screen.width < 1000) document.write('<tr><td colspan="2"><span style="color:red">系统提示:</span><br/>后台最佳显示宽度为等于或大于1024px<br/>您的当前显示器屏幕宽度为' + screen.width + 'px<br/>建议您在后台管理时关闭左侧栏或更换显示器</td></tr>');
                            </script>

                        </table>
                    </div>
                </div>
            </td>
        </tr>
    </table>
    <!-- end main -->
     </form>
   </div>
</div>
   
</body>
</html>

