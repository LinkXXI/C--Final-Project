<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="map.aspx.cs" Inherits="Final.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="LabelMsg" runat="server" ForeColor="green" Font-Bold="true"></asp:Label>
        <br />
        <asp:Button ID="btnForest" runat="server" Text="Forest" />
        <asp:Button ID="btnHouse" runat="server" Text="House" />
        <asp:Button ID="btnMine" runat="server" Text="Mine" />
        <asp:Button ID="btnShop" runat="server" Text="Shop" />
    </div>
</asp:Content>
