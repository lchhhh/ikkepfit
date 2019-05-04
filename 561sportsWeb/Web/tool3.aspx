<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="tool3.aspx.cs" Inherits="about" %>


<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="main">
        <div class="wrap">
            <div class="card" style="width: 87%; margin: 30px 85px 10px 85px">
                <div class="card-status bg-blue"></div>
                <div class="card-header">
                    <h4 class="card-title" style="font-size: medium">标准体重计算</h4>
                </div>
                <div class="card-body">
                    <div class="alert alert-primary" role="alert" style="font-size: small; color: #494949">
                        <i class="fe fe-bell mr-2" aria-hidden="true"></i>您的体重符合标准吗？使用标准体重计算器，请在下面选择您的性别，输入身高，最后计算得出标准体重。计算适用范围：女性：19岁到69岁，身高在152cm到176cm。男性：19岁到69岁，身高在152cm到188cm。
                    </div>
                    <fieldset class="form-fieldset">
                        <div class="custom-controls-stacked" style="margin: 0px 10px 20px 10px">
                            <label><i class="fe fe-edit"></i>请输入您的性别、身高：</label>
                            <div class="row" style="margin: 20px 0px 20px 0px">
                                性别：
                          <label class="custom-control custom-radio">
                              <input id="checkbox1" type="radio" class="custom-control-input" name="example-radios" value="option1" checked />
                              <div class="custom-control-label">男</div>
                          </label>
                                &nbsp;&nbsp;&nbsp;
                          <label class="custom-control custom-radio">
                              <input id="checkbox2" type="radio" class="custom-control-input" name="example-radios" value="option2" />
                              <div class="custom-control-label">女</div>
                          </label>
                            </div>

                            <div class="row">
                                <div class="form-group" style="margin: 0px 10px 0px 10px">
                                    <div class="input-group">
                                        <span class="input-group-prepend">
                                            <span class="input-group-text">身高(cm)</span>
                                        </span>
                                        <input id="height" type="text" class="form-control" required="required"/>
                                        <span class="input-group-prepend"></span>
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
                                <p>您的年龄身高对应标准体重为</p>
                            </div>
                            <div class="form-group">
                                <input id="avg_weight" type="text" class="form-control" style="height:25px;width:50px;border:none;outline:none;color:#149aff;font-size:large" readonly="readonly"/> 
                            </div>
                            <div class="form-group">
                                <p>kg</p>
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

                                var height = document.getElementById("height").value;

                                if (document.getElementById("checkbox1").checked == true) {
                                    document.getElementById("avg_weight").value = parseInt(height) - 105;
                                }
                                else {
                                    document.getElementById("avg_weight").value = parseInt(height) - 100;
                                }
                            }
                        }
                    </script>
                </div>
            </div>
        </div>
        </div>
</asp:Content>
