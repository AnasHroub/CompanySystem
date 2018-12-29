<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
        <div>
        <div id="MainDiv" class="MainDiv">

            <div id="Header">
<%--                <h2 class="Header_title">
                    Register Now
                </h2>--%>
               <h2 id="Header_title" runat="server" class="Header_title"><asp:Literal ID="Li_hdr_title" runat="server" meta:resourcekey="Li_hdr_titleResource1"/></h2>

            </div>
            <div id="SubDiv" class="SubDiv">
                <div id="SignInLeft" runat="server" class="SignInLeft">
                    <div class="Reg-txt">
                        <asp:Label ID="lblName" runat="server" Text="Name" meta:resourcekey="lblNameResource1"></asp:Label>
                        <asp:RequiredFieldValidator runat="server" ID="rfvName" ErrorMessage="Name is required"
                        ControlToValidate="txtName" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvNameResource1">*
                        </asp:RequiredFieldValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="vceName" TargetControlID="rfvName" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>   
                         
                    </div>
                    <div class="Reg-In">
                        <asp:TextBox ID="txtName" runat="server" CssClass="form" Width="60%" placeholder="Name" meta:resourcekey="txtNameResource1"></asp:TextBox>
                               
                    </div>
                    <div class="Reg-txt">
                        <asp:Label ID="lblPassword" runat="server" Text="Create a Password" meta:resourcekey="lblPasswordResource1"></asp:Label>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ErrorMessage="Password is required"
                        ControlToValidate="txtPassword" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvPasswordResource1">*
                        </asp:RequiredFieldValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="vcePassword" TargetControlID="rfvPassword" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>
                    </div>
                    <div class="Reg-In">
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form" Width="60%" MaxLength="15" meta:resourcekey="txtPasswordResource1"></asp:TextBox>                      
                    </div>           
                    <div class="Reg-txt">
                        <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password" meta:resourcekey="lblConfirmPasswordResource1"></asp:Label>
                        <asp:RequiredFieldValidator runat="server" ID="rfvConfirmPassword" ErrorMessage="Confirm Password is required"
                        ControlToValidate="txtConfirmPassword" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvConfirmPasswordResource1">*
                        </asp:RequiredFieldValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="ValidatorCalloutExtender1" TargetControlID="rfvConfirmPassword" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>
                        <asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Password not match!"
                         ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="cvConfirmPasswordResource1"></asp:CompareValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="vceConfirmPassword" TargetControlID="cvConfirmPassword" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>
                    </div>       
                    <div class="Reg-In">
                        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form" Width="60%" MaxLength="15" meta:resourcekey="txtConfirmPasswordResource1"></asp:TextBox>                      
                    </div>   
                    <div class="Reg-txt">
                        <asp:Label ID="lblEmail" runat="server" Text="Email" meta:resourcekey="lblEmailResource1"></asp:Label>
                        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ErrorMessage="Email is required"
                        ControlToValidate="txtEmail" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvEmailResource1">*
                        </asp:RequiredFieldValidator>
                        <AJAX:ValidatorCalloutExtender runat="server" ID="vceEmail" TargetControlID="rfvEmail" Enabled="True">
                        </AJAX:ValidatorCalloutExtender>
                    </div>       
                    <div class="Reg-In">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form" Width="60%" TextMode="Email" placeholder="Example@domain.com"
                         MaxLength="50" meta:resourcekey="txtEmailResource1"></asp:TextBox>  
                    </div>    
                    <div class="Reg-In">
                    <asp:Button ID="btnRegistration" runat="server" Text="Register" ValidationGroup="Save" CssClass="btn btn-primary" meta:resourcekey="btnRegistrationResource1" />
                    </div>
                </div>
                <div id="SignInRight" runat="server" class="SignInRight">
                    <img alt="Registration Image" src="../../App_Themes/Images/Registration.png" style="margin-bottom: 30px;"/>
                   <div>
                        <h2><asp:Literal ID="Li_hdr_user" runat="server" meta:resourcekey="Li_hdr_userResource1"/></h2>
                    </div>
                    <h3>
                        <a href="SignIn.aspx"><strong><asp:Literal ID="Li_Join" runat="server" meta:resourcekey="Li_JoinResource1"/></strong></a>
                    </h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
