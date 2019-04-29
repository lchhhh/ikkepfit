<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="login.aspx.cs" Inherits="_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Page-Enter" content="blendTrans(Duration=0.5)" />
    <meta http-equiv="Page-Exit" content="blendTrans(Duration=0.5)" />
    <title>管理员登陆</title>
    <link rel="stylesheet" href="scripts/auth.css"/>
    <script type="text/javascript" src="../js/jquery-1.3.2.min.js"></script>
    <script src="../js/keyboard.js" type="text/javascript"></script>
    <script src="scripts/auth.js" type="text/javascript"></script>
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
    <div>
        <asp:Literal ID="litIP" runat="server"></asp:Literal>
    </div>
    <div class="lowin lowin-blue" >
		<div class="lowin-brand">
			<img src="scripts/kodinger.jpg" alt="logo"/>
		</div>
        <div class="lowin-wrapper">
            <div class="lowin-box lowin-login">
                <div class="lowin-box-inner">
                    <p>ikeepfit管理员登陆</p>
                    <div class="lowin-group">
                        <label>登录名</label>
                        <input id="username" name="username" runat="server" class="lowin-input" />
                    </div>
                    <div class="lowin-group password-group">
                        <label>密码</label>
                        <input id="password" name="password" runat="server" type="password" class="lowin-input" />
                    </div>
                    <%--<button id="btnSubmit" runat="server" class="lowin-btn login-btn" onclientclick="return CheckForm();" onclick="btnSubmit_Click">
                        登陆
                    </button>--%>
                    <asp:Button ID="btnSubmit" runat="server" CssClass="lowin-btn login-btn" Text=" 登 录 " OnClientClick="return CheckForm();" onclick="btnSubmit_Click" />
                </div>
            </div>
        </div>
    </div>

    </form>
   </div>
</div>
   
</body>
</html>

