<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="tool4.aspx.cs" Inherits="about" %>


<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="main">
        <div class="wrap">
            <div class="card" style="width: 87%; margin: 30px 85px 10px 85px">
                <div class="card-status bg-blue"></div>
                <div class="card-header">
                    <h4 class="card-title" style="font-size: medium">热量计算器</h4>
                </div>
                <div class="card-body">
                    <div class="alert alert-primary" role="alert" style="font-size: small; color: #494949">
                        <i class="fe fe-bell mr-2" aria-hidden="true"></i>热量计算，卡路里计算器、热量消耗计算
                    </div>
                    <fieldset class="form-fieldset">
                        <div class="custom-controls-stacked" style="margin: 0px 10px 20px 10px">
                            <label><i class="fe fe-edit"></i>请输入您的体重、运动时间和运动类型：</label>
                            <div class="row">
                                <div class="form-group" style="margin: 0px 10px 0px 10px">
                                    <div class="input-group">
                                        <span class="input-group-prepend">
                                            <span class="input-group-text">体重(kg)</span>
                                        </span>
                                        <input id="weight" type="text" class="form-control" required="required"/>
                                        <span class="input-group-prepend"></span>
                                    </div>
                                </div>
                                <div class="form-group" style="margin: 0px 10px 0px 10px">
                                    <div class="input-group">
                                        <span class="input-group-prepend">
                                            <span class="input-group-text">运动时间(分钟)</span>
                                        </span>
                                        <input id="sptime" type="text" class="form-control" required="required"/>
                                        <span class="input-group-prepend"></span>
                                    </div>
                                </div>
                                <div class="form-group" style="margin: 0px 10px 0px 10px">
                                    <div class="input-group">
                                        <span class="input-group-prepend">
                                            <span class="input-group-text">运动方式</span>
                                        </span>
                                        <select id="spmethod" style="width:150px">
                                            <option value="sleep">睡觉</option>
                                            <option value="run">跑步</option>
                                            <option value="sing">唱歌</option>
                                            <option value="swim">游泳</option>
                                            </select>
                                    </div>
                                </div>
                                <div class="form-group" style="margin: 0px 10px 0px 10px">
                                    <button id="bt" type="button" class="btn btn-info" style="width:80px">计算</button>
                                </div>
                          </div>
                        </div>
                    </fieldset>

                    <fieldset class="form-fieldset" id="thediv" style="display: none">
                        <div class="row" style="margin: 0px 0px 0px 10px">
                            <div class="form-group">
                                <p>您消耗的热量为：</p>
                            </div>
                            <div class="form-group">
                                <input id="kj" type="text" class="form-control" style="height:25px;width:50px;border:none;outline:none;color:#149aff;font-size:large" readonly="readonly"/> 
                            </div>
                            <div class="form-group">
                                <p>大卡</p>
                            </div>
                        </div>
                    </fieldset>

                    <script>
                        window.onload = function () {
                            var obt = document.getElementById("bt");
                            var odiv = document.getElementById("thediv");
                            obt.onclick = function () {
                                if (odiv.style.display == "none") {
                                    odiv.style.display = "block";
                                }
                                else {
                                    //odiv.style.display = "none";
                                    odiv.style.display = "block";
                                }

                                var time = document.getElementById("sptime").value;
                                var c = document.getElementById("spmethod").value;
                                switch (c)
                                {
                                    case "sleep":
                                        document.getElementById("kj").value = parseInt(time) * 2.7;
                                        break;
                                    case "run":
                                        document.getElementById("kj").value = parseInt(time) * 23.6;
                                        break;
                                    case "sing":
                                        document.getElementById("kj").value = parseInt(time) * 9.3;
                                        break;
                                    case "swim":
                                        document.getElementById("kj").value = parseInt(time) * 17.2;
                                        break;
                                }



                            }
                        }
                    </script>
                </div>
            </div>
        </div>
        </div>
</asp:Content>
