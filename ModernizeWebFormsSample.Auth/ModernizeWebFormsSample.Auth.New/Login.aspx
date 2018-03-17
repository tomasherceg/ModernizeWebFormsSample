<%@ Page Title="Sign In" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ModernizeWebFormsSample.Auth.New.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-md-4 col-md-offset-4">

            <div class="form">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="UserName" ID="UserNameLabel" CssClass="control-label">User Name</asp:Label>
                    <div>
                        <asp:TextBox runat="server" ID="UserName" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                                    ValidationGroup="Login1" ToolTip="User Name is required." ID="UserNameRequired">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Password" ID="PasswordLabel">Password</asp:Label>
                    <div>
                        <asp:TextBox runat="server" TextMode="Password" ID="Password" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" ErrorMessage="Password is required." 
                                                    ValidationGroup="Login1" ToolTip="Password is required." ID="PasswordRequired">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label"></label>
                    <div class="checkbox-inline">
                        <asp:CheckBox runat="server" Text="Remember me next time." ID="RememberMe"></asp:CheckBox>
                    </div>
                </div>
                <div class="form-group text-danger">
                    <asp:Literal runat="server" ID="FailureText" EnableViewState="False"></asp:Literal>
                </div>
            </div>
            
            <div class="text-right">
                <asp:Button runat="server" Text="Sign In" ValidationGroup="Login1" 
                            ID="LoginButton" Class="btn btn-primary" UseSubmitBehavior="true"
                            OnClick="LoginButton_OnClick"></asp:Button>
            </div>
        </div>
    </div>

</asp:Content>

