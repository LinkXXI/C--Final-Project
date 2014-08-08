<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.master" AutoEventWireup="true" CodeBehind="Forest.aspx.cs" Inherits="Final.Forest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="characterContent" runat="server">
 <div id ="container" class="container" runat="server">
        <p>Welcome to the Forest! Kill the monster!</p>

        <div runat="server" id="combat" class="container">

            <asp:SqlDataSource ID="monsterSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
                SelectCommand="SELECT * FROM [Monster] WHERE ([Level] = @level)">
                <SelectParameters>
                    
                    <asp:ControlParameter ControlID="lblMaxLevel" DefaultValue="1" Name="Level" 
                        PropertyName="Text" Type="Int32" />
                    
                </SelectParameters>
            </asp:SqlDataSource>
                    <asp:SqlDataSource ID="saveSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
            SelectCommand="SELECT * FROM [Character] WHERE ([CharacterName] = @CharacterName)">
            <SelectParameters>
                <asp:ControlParameter ControlID="lblName" Name="CharacterName" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblMaxLevel" runat="server" Text="" Visible="False"></asp:Label>
            <asp:Label ID="lblEnemyName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="imgEnemy" runat="server" />
            <br />
            <asp:Label ID="lblEnemyStats" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCharacterInfo" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="btnAttack" runat="server" Text="Attack!" 
                onclick="btnAttack_Click" />
            <asp:Button ID="btnRun"
                runat="server" Text="Run!" onclick="btnRun_Click" />

        </div>
     </div>
</asp:Content>

