<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.master" AutoEventWireup="true" CodeBehind="Forest.aspx.cs" Inherits="Final.Forest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="characterContent" runat="server">
 <div id ="container" class="container" runat="server">
        <p>Welcome to the Forest! Kill the monster!</p>

        <div runat="server" id="combat" class="container">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
                SelectCommand="SELECT * FROM [Monster] WHERE ([Level] = @Level)">
                <SelectParameters>
                    <asp:SessionParameter DefaultValue="1" Name="Level" SessionField="EnemyLevel" 
                        Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
            </asp:GridView>
            <div id="monster"> </div>
            <div id="player" runat="server"> </div><br />
            <div id="monster" runat="server"> </div><br />

            <asp:Button ID="Attack" runat="server" Text="Attack" onclick="Attack_Click" class="btn btn-default" />
            <asp:Button ID="Run"
                runat="server" Text="Run" onclick="Run_Click" class="btn btn-default" />

        </div>
        <div id="monsterDiv" runat="server" style="display: none;">
        <div id="Div1" runat="server" style="display: none;"></div>
        <div id="Div2" runat="server" style="display: none;"></div>
        <div id="Div3" runat="server" style="display: none;"></div>
        <div id="Div4" runat="server" style="display: none;"></div>
        <div id="Div5" runat="server" style="display: none;"></div>
        </div>
        </div>
</asp:Content>
