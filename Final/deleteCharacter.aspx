<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="deleteCharacter.aspx.cs" Inherits="Final.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='container'>
        <div class="jumbotron">
        <div hidden id="error" runat="server">
            <asp:Label ID="lblMessage" runat="server" Font-Bold="True"></asp:Label>
        </div>
            <div class='row'>
                <div class="col-md-4">
                    Character Name
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCharName" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="txtCharValidate" runat="server" ErrorMessage="Cannot delete without a character name!" Display="Dynamic" ControlToValidate="txtCharName"></asp:RequiredFieldValidator>
                </div>
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="Delete Character" 
                onclick="btnSubmit_Click" />
        </div>    
    </div>
    <asp:SqlDataSource ID="deleteCharacterSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:InsertCharDS %>" 
        SelectCommand="SELECT [CharacterName] FROM [Character] WHERE ([CharacterName] = @CharacterName)"
        DeleteCommand="DELETE FROM [Character] WHERE ([CharacterName] = @CharacterName)">
        <DeleteParameters>
            <asp:ControlParameter ControlID="txtCharName" Name="CharacterName" PropertyName="Text" Type="String" />
        </DeleteParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="txtCharName" Name="CharacterName" 
                PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
