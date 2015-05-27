<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="gameControl.ascx.cs" Inherits="COMP2007_Assignment1.gameControl" %>

<!-- Game Form Widget -->

    <div>
        <!-- Radio Button for Win and Lose -->
        <asp:Label ID="lblWinLose" runat="server" Text="Game Result:"></asp:Label>
        <asp:RadioButtonList ID="rblResults" runat="server">
            <asp:ListItem Value="Win" Text="Win"></asp:ListItem>
            <asp:ListItem Value="Lose" Text="Lose" Selected="True"></asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <div>
        <!-- Points Scored Label and Text Box -->
        <asp:Label ID="lblPointsScored" runat="server" Text="Points Scored:"></asp:Label>
        <asp:TextBox ID="txtPointsScored" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="txtPointsScored" Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Must be greater than zero and numeric" ControlToValidate="txtPointsScored" Type="Integer" Display="Dynamic" CssClass="label label-danger" MinimumValue="0" MaximumValue="999999"></asp:RangeValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Points Scored Must Be Less Than Points Allowed" CssClass="label label-danger" ControlToCompare="txtPointsScored" ControlToValidate="txtPointAllowed" Operator="GreaterThan" Display="Dynamic"></asp:CompareValidator>
    </div>

    <div>
        <!-- Points Allowed Label and Text Box -->
        <asp:Label ID="lblPointsAllowed" runat="server" Text="Points Allowed:"></asp:Label>
        <asp:TextBox ID="txtPointAllowed" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="txtPointAllowed" Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Must be greater than zero and numeric" ControlToValidate="txtPointAllowed" Type="Integer" Display="Dynamic" CssClass="label label-danger" MinimumValue="0" MaximumValue="999999"></asp:RangeValidator>
    </div>
    <div>
        <!-- Spectators Label and Text Box -->
        <asp:Label ID="lblSpectators" runat="server" Text="# of Spectators:"></asp:Label>
        <asp:TextBox ID="txtSpectators" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required Field" ControlToValidate="txtSpectators" Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Must be greater than zero and numeric" ControlToValidate="txtSpectators" Type="Integer" Display="Dynamic" CssClass="label label-danger" MinimumValue="0" MaximumValue="999999"></asp:RangeValidator>
    </div>



