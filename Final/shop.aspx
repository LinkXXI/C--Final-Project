<%@ Page Title="" Language="C#" MasterPageFile="~/characterPages.master" AutoEventWireup="true" CodeBehind="shop.aspx.cs" Inherits="Final.shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="characterContent" runat="server">
    <div class="container">
        <p>Welcome to the Shop! Buy items here to gain bonus stats!</p>

        <div runat="server" id="shopList" class="container">
        Items Here
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
                SelectCommand="SELECT ItemName, Attack, Health, Class, Cost FROM Item ORDER BY Cost">
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="ItemName" DataSourceID="SqlDataSource1" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" CssClass="table">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" ReadOnly="True" 
                        SortExpression="ItemName" />
                    <asp:BoundField DataField="Attack" HeaderText="Attack" 
                        SortExpression="Attack" />
                    <asp:BoundField DataField="Health" HeaderText="Health" 
                        SortExpression="Health" />
                    <asp:BoundField DataField="Class" HeaderText="Class" SortExpression="Class" />
                    <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                </Columns>
            </asp:GridView>
        </div>
        <div id="itemDiv" runat="server" style="display: none;">
        <div id="Div1" runat="server" style="display: none;"></div>
        <div id="Div2" runat="server" style="display: none;"></div>
        <div id="Div3" runat="server" style="display: none;"></div>
        <div id="Div4" runat="server" style="display: none;"></div>
        <div id="Div5" runat="server" style="display: none;"></div>
        </div>
        <asp:Button ID="btnBuy" runat="server" Text="Buy" class="btn btn-default" 
            onclick="btnBuy_Click"/>
        <br/>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnMap" runat="server" Text="Return to Map" 
            onclick="btnMap_Click" class="btn btn-default"/>
        <div id="messageDiv" hidden runat="server" style="margin-top:10px;"> 
            <div runat="server" id="message" class="container">
        </div>
    </div>
    
    </div>
</asp:Content>
