<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.master" AutoEventWireup="true" CodeBehind="house.aspx.cs" Inherits="Final.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="characterContent" runat="server">
    <div class="container">
        <p>Welcome home 
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></p>
        <asp:Button ID="btnSleep" runat="server" Text="Sleep" class="btn btn-default" 
            onclick="btnSleep_Click" />
        <asp:Button ID="btnSave" runat="server" Text="Save Quest" 
            Class="btn btn-default" onclick="btnSave_Click" />
        <br />
        <div id="message" hidden runat="server">
            <asp:Label ID="lblMessage" runat="server" Text="" Font-Bold="True"></asp:Label>
        </div>
            <br />
        <asp:Button ID="btnMap" runat="server" Text="Return to map" 
            Class="btn btn-default" onclick="btnMap_Click"/>
        <asp:SqlDataSource ID="saveSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
            SelectCommand="SELECT * FROM [Character] WHERE ([CharacterName] = @CharacterName)">
            <SelectParameters>
                <asp:ControlParameter ControlID="lblName" Name="CharacterName" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    
</asp:Content>
