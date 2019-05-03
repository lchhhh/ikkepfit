<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="tool1.aspx.cs" Inherits="about" %>


<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="main">
        <div class="wrap">
            <div class="card" style="width: 87%; margin: 30px 85px 10px 85px">
                <div class="card-status bg-blue"></div>
                <div class="card-header">
                    <h4 class="card-title" style="font-size: medium">一分钟了解自己</h4>
                </div>
                <div class="card-body">
                    <div class="alert alert-primary" role="alert" style="font-size: small; color: #494949">
                        <i class="fe fe-bell mr-2" aria-hidden="true"></i>1分钟彻底了解自己的标准体重、健康体重范围、BMI指数（即身体质量指数）、基础代谢率和燃脂运动中低强度运动心率，看看自己是否需要减肥了。身体质量指数(BMI)：评估体重与身高比例的常用工具，适用范围：18至65岁的人士。儿童、发育中的青少年、孕妇、乳母、老人及身型健硕的运动员除外。
                    </div>
                    <fieldset class="form-fieldset">
                        <div class="custom-controls-stacked" style="margin: 0px 10px 20px 10px">
                            <label><i class="fe fe-edit"></i>请输入您的性别、年龄、身高和体重：</label>
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
                                            <span class="input-group-text">年龄(岁)</span>
                                        </span>
                                        <input id="age" type="text" class="form-control" required="required"/>
                                        <span class="input-group-prepend"></span>
                                    </div>
                                    </div>
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
                                    <div class="input-group">
                                        <span class="input-group-prepend" id="basic-addon1">
                                            <span class="input-group-text">体重(kg)</span>
                                        </span>
                                        <input id="weight" type="text" class="form-control" required="required"/>
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
                                <p>您的身体指数（BMI）为</p>
                            </div>
                            <div class="form-group">
                                <input id="BMI" type="text" class="form-control" style="height:25px;width:65px;border:none;outline:none;color:#149aff;font-size:large" readonly="readonly"/>
                            </div>
                        </div>
                        <div class="form-group" style="margin: 0px 0px 0px 10px">
                            <p>成年人身体质量指数参考：</p>
                        </div>
                        <div class="card" style="width:500px">
                      <table class="table card-table table-vcenter text-nowrap">
                      <tbody>
                        <tr>
                          <td>轻体重BMI</td>
                          <td>健康体重BMI</td>
                          <td>超重BMI</td>
                          <td>肥胖BMI</td>
                        </tr>
                        <tr>
                          <td>BMI<18.5</td>
                          <td>18.5≤BMI<24</td>
                          <td>24≤BMI<28</td>
                          <td>28≤BMI</td>
                        </tr>
                      </tbody>
                    </table>
                        </div>
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
                        <div class="row" style="margin: 0px 0px 0px 10px">
                            <div class="form-group">
                                <p>您的基础代谢率为</p>
                            </div>
                            <div class="form-group">
                                <input id="bdx" type="text" class="form-control" style="height:25px;width:83px;border:none;outline:none;color:#149aff;font-size:large" readonly="readonly"/>
                            </div>
                            <div class="form-group">
                                <p>大卡</p>
                            </div>
                        </div>
                        <div class="card">
                            <div class="card-body">
                                <p>人体要燃烧脂肪，需要满足三个必要条件：</p>
                                <p>1.该运动要达到中低强度的运动心率；</p>
                                <p>2.这种中低强度运动心率的运动要持续20分钟以上；</p>
                                <p>3.这种运动必须是大肌肉群的运动，如慢跑、游泳、健身操等。</p>
                                <p>低于或高于这个范围，都不算中低强度运动心率，燃烧的也就不是脂肪了</p>
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

                                var age = document.getElementById("age").value;
                                var height = document.getElementById("height").value;
                                var weight = document.getElementById("weight").value;
                                document.getElementById("BMI").value = parseInt(weight)/((parseInt(height)) * (parseInt(height))/ 10000);
                                if (document.getElementById("checkbox1").checked == true) {
                                    document.getElementById("avg_weight").value = parseInt(height) - 105;
                                    document.getElementById("bdx").value = 66 + 13.7 * parseInt(weight) + 5 * (parseInt(height))-6.8*parseInt(age);
                                }
                                else {
                                    document.getElementById("avg_weight").value = parseInt(height) - 100;
                                    document.getElementById("bdx").value = 665 + 9.6 * parseInt(weight) + 1.7 * (parseInt(height)) - 4.7 * parseInt(age);
                                }
                            }
                        }
                    </script>
                </div>
            </div>
        </div>
        </div>
</asp:Content>
