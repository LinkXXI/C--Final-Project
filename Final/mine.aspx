<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.master" AutoEventWireup="true" CodeBehind="mine.aspx.cs" Inherits="Final.mine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="characterContent" runat="server">
    <div class="container">
        <p>Welcome to the mine! You can mine here to make money.</p>
        <asp:Button ID="btnMine" runat="server" Text="Mine!" class="btn btn-default" 
            onclick="btnMine_Click"/>
        <br />
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Green"></asp:Label>
        <br />
        <asp:Button ID="btnMap" runat="server" Text="Return to Map" 
            onclick="btnMap_Click" class="btn btn-default"/>
    </div>
</asp:Content>
