<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="tools.aspx.cs" Inherits="about" %>


<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main">
        <div class="wrap">
            <div class="card" style="width:87%; margin: 30px 85px 10px 85px">
                <div class="card-status bg-blue"></div>
                <div class="card-body">
                    <div class="jumbotron" style="background-image: url(images/tools/banner1.png);height:600px">
                        </div>
                    <div class="row" style="margin:10px 0px 0px 0px">
                        <div class="list-group" style="width:100%;">
                            <a href="tool1.aspx" class="list-group-item " style="text-align:center;margin:10px 0px 0px 0px">一分钟认识自己&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="tag tag-rounded">健身计算器</span></a>
                        </div>
                        <div class="list-group" style="width:100%;">
                            <a href="tool2.aspx" class="list-group-item " style="text-align:center;margin:10px 0px 0px 0px">身体质量指数（BMI）&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="tag tag-rounded">健身计算器</span></a>
                        </div>
                        <div class="list-group" style="width:100%;">
                            <a href="tool3.aspx" class="list-group-item " style="text-align:center;margin:10px 0px 0px 0px">标准体重计算&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="tag tag-rounded">健身计算器</span></a>
                        </div>
                        <div class="list-group" style="width:100%;">
                            <a href="tool4.aspx" class="list-group-item " style="text-align:center;margin:10px 0px 0px 0px">热量计算器&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="tag tag-rounded">健身计算器</span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
