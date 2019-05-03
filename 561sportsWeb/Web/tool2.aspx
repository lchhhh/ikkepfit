<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="tool2.aspx.cs" Inherits="about" %>


<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="main">
        <div class="wrap">
            <div class="card" style="width: 87%; margin: 30px 85px 10px 85px">
                <div class="card-status bg-blue"></div>
                <div class="card-header">
                    <h4 class="card-title" style="font-size: medium">身体质量指数(BMI)</h4>
                </div>
                <div class="card-body">
                    <div class="alert alert-primary" role="alert" style="font-size: small; color: #494949">
                        <i class="fe fe-bell mr-2" aria-hidden="true"></i>BMI(Body Mass Index)即BMI指数，也叫身体质量指数，是衡量是否肥胖和标准体重的重要指标。适用范围：18至65岁的人士。儿童、发育中的青少年、孕妇、乳母、老人及身型健硕的运动员除外。世界卫生组织认为BMI指数保持在22左右是比较理想的。
                    </div>
                    <fieldset class="form-fieldset">
                        <div class="custom-controls-stacked" style="margin: 0px 10px 20px 10px">
                            <label><i class="fe fe-edit"></i>请输入您的身高和体重：</label>

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
                                var weight = document.getElementById("weight").value;
                                document.getElementById("BMI").value = parseInt(weight)/((parseInt(height)) * (parseInt(height))/ 10000);
                            }
                        }
                    </script>
                </div>
            </div>
        </div>
        </div>
</asp:Content>
