<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.master" AutoEventWireup="true" CodeBehind="shop.aspx.cs" Inherits="Final.shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="characterContent" runat="server">
    <div class="container">
        <p>Welcome to the Shop! Buy items here to gain bonus stats!</p>

        <div id="shopList" class="container">
        Items Here
        </div>


        <asp:Button ID="btnBuy" runat="server" Text="Buy" class="btn btn-default" 
            onclick="btnBuy_Click"/>
        <br/>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnMap" runat="server" Text="Return to Map" 
            onclick="btnMap_Click" />
    </div>
</asp:Content>
