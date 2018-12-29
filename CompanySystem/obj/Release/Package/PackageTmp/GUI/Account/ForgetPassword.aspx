<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="CompanySystem.GUI.Account.ForgetPassword" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
        <div>
          <div id="MainDiv" class="MainDiv">
            <div id="Header">
                <h2 id="Header_title" runat="server" class="Header_title"><asp:Literal ID="Li_hdr_title" runat="server" meta:resourcekey="Li_hdr_titleResource1"/>
                    </h2>
            </div>
          </div>
        </div>

        <div style="margin-bottom:10%">
        </div>

       <div id="divhelp" style="text-align: center; margin-bottom:1%" runat="server">
          <asp:Label ID="lblhelp" runat="server" meta:resourcekey="lblhelpResource1" />
        </div>

       <div id="SubDiv" class="SubDiv">
          <div id="Email_Secondary" runat="server" style="margin-left:25%">
             <div id="Email_div" class="TextDiv" runat="server" style="width:10%">
                <asp:Label ID="lblEmail" runat="server" Text="Email" meta:resourcekey="lblEmailResource1"></asp:Label>              
             </div>
             <div class="InputDiv">
                <asp:TextBox ID="txtEmail" runat="server" Width="40%" TextMode="Email" MaxLength="50" meta:resourcekey="txtEmailResource1"></asp:TextBox>                       
             </div>
          </div>
       </div>

         <div style="margin-bottom:2%">
        </div>

          <div id="Controls" class="Controls" style="text-align: center" runat="server">
             <asp:Button ID="btn_Submit" runat="server" Text="Submit" Width="20%" ValidationGroup="Submit"  CssClass="btn btn-primary" meta:resourcekey="btn_SubmitResource1"/>
       	 </div> 

        <div style="margin-bottom:1%">
        </div>

          <div id="div_login" style="text-align: center" runat="server">
              <asp:HyperLink ID="hr_login" NavigateUrl="~/GUI/Account/SignIn.aspx" Text="Sign in !" runat="server" meta:resourcekey="hr_loginResource1"></asp:HyperLink>
          </div>

         <div style="margin-bottom:1%">
        </div>

        <div style="text-align: center">
          <asp:Label ID="lblMessage" runat="server" meta:resourcekey="lblMessageResource1" />
        </div>
</asp:Content>
