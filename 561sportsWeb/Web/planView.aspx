<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="planView.aspx.cs" Inherits="about" %>

<%@ Register Src="~/lx.ascx" TagPrefix="uc1" TagName="lx" %>






<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main">
        <div id="wrap">
            <div class="row">
                <uc1:lx runat="server" ID="lx" />

                <div class="col-lg">
                    <div class="card" style="width: 925px; margin: 30px 3px 10px 0px">
                        <div class="card-status bg-blue"></div>
                        <div class="card-header">
                            <h4 style="margin: 0px 30px 0px 0px">
                                <asp:Label ID="lbltitle" runat="server" Text=""></asp:Label></h4>
                            <i class="fe fe-clock">&nbsp;</i>
                            <asp:Label ID="lblatime" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="card-body">
                            <p class="MsoNormal" style="margin-left: 6.0000pt; text-align: left; background: #FFFFFF;">
                                <asp:Literal ID="lblmemo" runat="server"></asp:Literal>
                            </p>
                        </div>
                    </div>
                </div>
            </div>



        </div>
    </div>

</asp:Content>

