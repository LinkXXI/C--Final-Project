<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.Master" AutoEventWireup="true"
    CodeBehind="map.aspx.cs" Inherits="Final.WebForm3" %>

<asp:Content ID="characterContent" ContentPlaceHolderID="characterContent" runat="server">
    <div class="container">
        <div id="message" hidden runat="server">
            <asp:Label ID="LabelMsg" runat="server" Font-Bold="true"></asp:Label>
        </div>
        <br />
        <asp:Button ID="btnForest" runat="server" Text="Forest" class="btn btn-default"/>
        <asp:Button ID="btnHouse" runat="server" Text="House" class="btn btn-default"
            onclick="btnHouse_Click" />
        <asp:Button ID="btnMine" runat="server" Text="Mine" class="btn btn-default" 
            onclick="btnMine_Click"/>
        <asp:Button ID="btnShop" runat="server" Text="Shop" class="btn btn-default"
            onclick="btnShop_Click"/>
    </div>
</asp:Content>
