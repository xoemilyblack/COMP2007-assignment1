<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="gameControl.ascx.cs" Inherits="COMP2007_Assignment1.gameControl" %>

<!-- Game Form Widget -->
    <asp:Label ID="lblWinLose" runat="server" Text="Game Result:"></asp:Label>
    <asp:RadioButtonList ID="rblResults" runat="server">
        <asp:ListItem Value="Win" Text="Win"></asp:ListItem>
        <asp:ListItem Value="Lose" Text="Lose" Selected="True"></asp:ListItem>
    </asp:RadioButtonList>

    <div>
        <asp:Label ID="lblPointsScored" runat="server" Text="Points Scored:"></asp:Label>
        <asp:TextBox ID="txtPointsScored" runat="server" TextMode="Number"></asp:TextBox>
    </div>
     
    <div>
        <asp:Label ID="lblPointsAllowed" runat="server" Text="Points Allowed:"></asp:Label>
        <asp:TextBox ID="txtPointAllowed" runat="server" TextMode="Number"></asp:TextBox>
    </div>

     <div>
        <asp:Label ID="lblSpectators" runat="server" Text="# of Spectators:"></asp:Label>
        <asp:TextBox ID="txtSpectators" runat="server" TextMode="Number"></asp:TextBox>
    </div>

