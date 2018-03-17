<%@ Page Title="Sign In" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ModernizeWebFormsSample.Auth.Old.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
    
            <div class="alert alert-danger" ID="Alert" runat="server" Visible="false">
                Invalid e-mail address or password!
            </div>

            <div class="form">
                <div class="form-group">
                    <label class="control-label">E-mail Address</label>
                    <div>
                        <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label">Password</label>
                    <div>
                        <asp:TextBox ID="PasswordTextBox" runat="server" CssClass="form-control" TextMode="Password" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label"></label>
                    <div class="checkbox-inline">
                        <asp:CheckBox ID="RememberMeCheckBox" runat="server" Text="Remember Me" />
                    </div>
                </div>
            </div>
            
            <div class="text-right">
                <asp:Button ID="LoginButton" runat="server" UseSubmitBehavior="true" Text="Sign In" OnClick="LoginButton_OnClick" CssClass="btn btn-primary" />
            </div>

        </div>
    </div>

</asp:Content>

