<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="tool1.aspx.cs" Inherits="about" %>


<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main">
        <div class="wrap">
            <div class="card" style="width:87%; margin: 30px 85px 10px 85px">
                <div class="card-status bg-blue"></div>
                <div class="card-header">
                    <h4 class="card-title" style="font-size:medium">一分钟了解自己</h4>
                </div>
                <div class="card-body">

                    <fieldset class="form-fieldset">
                        <div class="custom-controls-stacked"  style="margin: 0px 10px 20px 10px">
                            <div class="row">
                          <label class="custom-control custom-radio">
                            <input ID="checkbox1" runat="server" type="radio" class="custom-control-input" name="example-radios" value="option1" checked/>
                            <div class="custom-control-label">男</div>
                          </label>
                          <label class="custom-control custom-radio">
                            <input ID="checkbox2" runat="server" type="radio" class="custom-control-input" name="example-radios" value="option2"/>
                            <div class="custom-control-label">女</div>
                          </label>
                            </div>
                            </div>

                        <div class="row">
                            <div class="form-group" style="margin: 0px 10px 0px 10px">
                                <div class="input-group">
                                    <span class="input-group-prepend">
                                        <span class="input-group-text">年龄(岁)</span>
                                    </span>
                                    <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
                                    <span class="input-group-prepend">
                                    </span>
                                </div>
                            </div>
                            <div class="form-group" style="margin: 0px 10px 0px 10px">
                                <div class="input-group">
                                    <span class="input-group-prepend">
                                        <span class="input-group-text">身高(cm)</span>
                                    </span>
                                    <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                                    <span class="input-group-prepend">
                                    </span>
                                </div>
                            </div>
                            <div class="form-group" style="margin: 0px 10px 0px 10px">
                                <div class="input-group">
                                    <span class="input-group-prepend" id="basic-addon1">
                                        <span class="input-group-text">体重(kg)</span>
                                    </span>
                                    <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
                                    <span class="input-group-prepend">
                                    </span>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
