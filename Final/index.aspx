<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Final.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .button
        {
            width:30%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='container'>        
        <div class="jumbotron">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/img/theDogeKnight.png"/>            
            <h1>Welcome to DogeQuest!</h1>
            <div id="error" runat="server" hidden="true">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True"></asp:Label>
            </div>            
            <p>
                Fight Monsters, grow more powerfull, make money, such adventure!
            </p>
            <div class="btn-group">
                <asp:Button ID="btnNew" runat="server" Text="New Quest" 
                    class='btn btn-default btn-primary' onclick="btnNew_Click"/>
                <asp:Button ID="btnContinue" runat="server" Text="Continue Quest" 
                    class='btn btn-default' onclick="btnContinue_Click"/>
                <asp:Button ID="btnDelete" runat="server" Text="Delete Quest" class='btn btn-default' 
                    onclick="btnDelete_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
