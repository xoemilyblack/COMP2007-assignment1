<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/assignment1.Master" CodeBehind="default.aspx.cs" Inherits="COMP2007_Assignment1._default" %>
<%@ Register Src="~/gameControl.ascx" TagPrefix="uc1" TagName="gameControl" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="content1">
  
    <asp:Panel ID="pnlErrors" runat="server" Visible="false" CssClass="alert alert-warning">
    <asp:Label  ID="lblErrors" runat="server" Font-Bold="True"></asp:Label>
    </asp:Panel>

    <!-- Game 1 Panel -->
    <div class="panel panel-primary">
        <div class="panel-heading"><asp:Label ID="lblGame1" runat="server" Text="Game 1 Information"></asp:Label></div>
        <div class="panel-body"><uc1:gameControl runat="server" id="gameControl1" /></div>
    </div>
     <!-- Game 2 Panel -->
    <div class="panel panel-primary">
        <div class="panel-heading"><asp:Label ID="lblGame2" runat="server" Text="Game 2 Information"></asp:Label></div>
        <div class="panel-body"><uc1:gameControl runat="server" ID="gameControl2" /></div>
    </div>
     <!-- Game 3 Panel -->
    <div class="panel panel-primary">
        <div class="panel-heading"><asp:Label ID="lblGame3" runat="server" Text="Game 3 Information"></asp:Label></div>
        <div class="panel-body"><uc1:gameControl runat="server" ID="gameControl3" /></div>
    </div>
     <!-- Game 4 Panel -->
    <div class="panel panel-primary">
        <div class="panel-heading"><asp:Label ID="lblGame4" runat="server" Text="Game 4 Information"></asp:Label></div>
        <div class="panel-body"><uc1:gameControl runat="server" ID="gameControl4" /></div>
    </div>
    <!-- Submit Button -->
    <div class="btn-block">
        <asp:LinkButton ID="btnSubmit" runat="server" CssClass="btn btn-default" OnClick="btnSubmit_Click">
        <i aria-hidden="true" class="glyphicon glyphicon-ok"></i>Submit
        </asp:LinkButton>
    </div>

    <asp:Panel ID="pnlInfo" CssClass="panel panel-success text-center" Visible="false" runat="server">
    <asp:Label ID="lblSummary" runat="server" Font-Bold="True"></asp:Label><br />
    <asp:Label ID="lblGamesWon" runat="server"></asp:Label><br />
    <asp:Label ID="lblGamesLost" runat="server"></asp:Label><br />
    <asp:Label ID="lblWinningPerc" runat="server"></asp:Label><br />
    <asp:Label ID="lblTotalPoints" runat="server"></asp:Label><br />
    <asp:Label ID="lblAllowedPoints" runat="server"></asp:Label><br />
    <asp:Label ID="lblDifference" runat="server"></asp:Label><br />
    <asp:Label ID="lblSpectators" runat="server"></asp:Label><br />
    <asp:Label ID="lblAverageSpec" runat="server"></asp:Label><br />
</asp:Panel>
</asp:Content>
