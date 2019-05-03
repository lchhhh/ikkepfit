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
                    <div class="list-group">
                        <a href="#" class="list-group-item active">一分钟了解自己</a>
                        <a href="#" class="list-group-item">身体质量指数（BMI）</a>
                        <a href="#" class="list-group-item">标准体重计算</a>
                        <a href="#" class="list-group-item">基础代谢计算</a>
                        <a href="#" class="list-group-item">燃脂运动计算</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
