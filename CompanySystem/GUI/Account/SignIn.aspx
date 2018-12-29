<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="SignIn"  meta:resourcekey="PageResource1"  %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content22323dsadasdas131" ContentPlaceHolderID="Body" runat="server">
    <div>
        <div id="MainDiv" class="MainDiv">
            <div id="Header">
                <h2 id="Header_title" runat="server" class="Header_title"><asp:Literal ID="Li_hdr_title" runat="server" meta:resourcekey="Li_hdr_titleResource1"/></h2>
            </div>
            <div id="SubDiv" class="SubDiv">
                <div id="SignInLeft" runat="server" class="SignInLeft">
                    <div>
                        
                        <asp:Label ID="lblEmail" runat="server" Text="Email" meta:resourcekey="lblEmailResource1"></asp:Label>
                        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ErrorMessage="Email is required"
                        ControlToValidate="txtEmail" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvEmailResource1">*
                        </asp:RequiredFieldValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="vceEmail" TargetControlID="rfvEmail" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>
                    </div>
                    <div>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form" Width="60%" TextMode="Email" MaxLength="50" meta:resourcekey="txtEmailResource1"></asp:TextBox>                       
                    </div>
                    <br />
                    <div>
                        <asp:Label ID="lblPassword" runat="server" Text="Password" meta:resourcekey="lblPasswordResource1"></asp:Label>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ErrorMessage="Password is required"
                        ControlToValidate="txtPassword" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvPasswordResource1">*
                        </asp:RequiredFieldValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="vcePassword" TargetControlID="rfvPassword" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>
                    </div>
                    <div>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form" Width="60%" TextMode="Password" MaxLength="15" meta:resourcekey="txtPasswordResource1"></asp:TextBox>
                    </div>
                    <br />
                    <div>
                        <asp:Button runat="server" ID="btnSignIn" Text="Sign In" ValidationGroup="Save" CssClass="btn btn-primary" meta:resourcekey="btnSignInResource1"/>
                        &nbsp&nbsp
                        <asp:Label ID="lbl_err" runat="server" ForeColor="Red" meta:resourcekey="lbl_errResource1"></asp:Label>
                        <asp:HyperLink ID="hr_Forget" runat="server" ForeColor="Blue"  NavigateUrl="~/GUI/Account/ForgetPassword.aspx"  meta:resourcekey="hr_ForgetResource1"></asp:HyperLink>
                    </div>
                </div>
                <div id="SignInRight" runat="server" class="SignInRight">
                    <div>
                        <h2><asp:Literal ID="Li_hdr_user" runat="server" meta:resourcekey="Li_hdr_userResource1"/></h2>
                    </div>
                    <h3>
                        <a href="Registration.aspx"><strong><asp:Literal ID="Li_Join" runat="server" meta:resourcekey="Li_JoinResource1"/></strong></a>
                    </h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
