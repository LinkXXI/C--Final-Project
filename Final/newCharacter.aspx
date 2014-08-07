<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="newCharacter.aspx.cs" Inherits="Final.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .control
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div id="error" runat="server" hidden>
                <asp:Label ID="LabelMsg" runat="server" Font-Bold="true"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <p>
                    Character Name:</p>
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtCharName" runat="server" class='control' MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:RequiredFieldValidator ID="txtCharEmptyValidate" runat="server" ErrorMessage="Character Name is required. "
                    ControlToValidate="txtCharName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                Class:
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="lstClassSelect" runat="server" class='control'>
                    <asp:ListItem Text="Warrior" Value="Warrior" />
                    <asp:ListItem Text="Wizard" Value="Wizard" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
            </div>
            <div class="col-md-4">
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" class='btn btn-default' OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="characterSource" runat="server" ConnectionString="<%$ ConnectionStrings:InsertCharDS
    %>" SelectCommand="SELECT * FROM [Character]" InsertCommand="INSERT INTO [Character]
    VALUES"> </asp:SqlDataSource>
</asp:Content>
