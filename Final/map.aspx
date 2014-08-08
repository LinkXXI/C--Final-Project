<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.Master" AutoEventWireup="true"
    CodeBehind="map.aspx.cs" Inherits="Final.WebForm3" %>

<asp:Content ID="characterContent" ContentPlaceHolderID="characterContent" runat="server">
    <div class="container">
        <div id="message" hidden runat="server">
            <asp:Label ID="LabelMsg" runat="server" Font-Bold="true"></asp:Label>
        </div>
        <br />
        <div class="row">
            <div class="col-md-3">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/img/forest.png" style="width:100%; height:auto;"/>
                
            </div>
            <div class="col-md-3">
                <asp:Image ID="Image2" runat="server" style="width:100%; height:auto;" ImageUrl="~/img/home.png" />
                
            </div>
            <div class="col-md-3">
                <asp:Image ID="Image3" runat="server" style="width:100%; height:auto;" ImageUrl="~/img/mines.png" />
                
            </div>
            <div class="col-md-3">
               <asp:Image ID="Image4" runat="server" style="width:100%; height:auto;" 
                    ImageUrl="~/img/shop.png"/>
                
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <asp:Button ID="btnForest" runat="server" Text="Forest" class="btn btn-default" 
                    onclick="btnForest_Click" style="width:100%;"/>
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnHouse" runat="server" Text="House" class="btn btn-default"
                    onclick="btnHouse_Click" style="width:100%; bottom:0px;"/>
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnMine" runat="server" Text="Mine" class="btn btn-default" 
                    onclick="btnMine_Click" style="width:100%;"/>
            </div>
            <div class="col-md-3">
                 <asp:Button ID="btnShop" runat="server" Text="Shop" class="btn btn-default"
                    onclick="btnShop_Click" style="width:100%;"/>
            </div>
        </div>
    </div>
</asp:Content>
