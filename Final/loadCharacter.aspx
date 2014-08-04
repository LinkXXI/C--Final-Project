<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="loadCharacter.aspx.cs" Inherits="Final.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='container'>
        <div class="jumbotron">
            <div class='row'>
                <div class="col-md-4">
                    Character Name
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCharName" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="txtCharValidate" runat="server" ErrorMessage="RequiredFieldValidator" Display="Dynamic" ControlToValidate="txtCharName"></asp:RequiredFieldValidator>
                </div>
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="Button" 
                onclick="btnSubmit_Click" />
        </div>    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
        SelectCommand="SELECT * FROM [Character] WHERE ([CharacterName] = @CharacterName)">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtCharName" Name="CharacterName" 
                PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
