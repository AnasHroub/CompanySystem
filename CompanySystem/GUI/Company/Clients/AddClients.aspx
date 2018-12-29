<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="AddClients.aspx.cs" Inherits="AddClients" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

  <asp:panel id="Panel1" runat="server" meta:resourcekey="Panel1Resource1">
     
         <div id="Clients" class="panel-primary">
               <div class="panel-heading">
                   <h3 class="panel-title">
                       <asp:Literal ID="Li_panel_title" runat="server" meta:resourcekey="Li_panel_titleResource1"/>
                   </h3>
               </div>
               <div class="panel-body">
                   <div class="Secondery-panel-content">
      
                       <div id="Name_Secondary"  class="secondary-form-group" runat="server">
                           <div id="Name_div" class="TextDiv" runat="server">
                               <asp:Label ID="lblName" runat="server" Text="Name :" meta:resourcekey="lblNameResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvName" ErrorMessage="Name is required"
                                   ControlToValidate="txtName" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvNameResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vcename" TargetControlID="rfvName" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtName" class="InputDiv" runat="server" Width="80%" meta:resourcekey="txtNameResource1"></asp:TextBox>
                           </div>
                       </div>

                        <div id="Email_Secondary" class="secondary-form-group" runat="server">
                           <div id="Email_div" class="TextDiv" runat="server">
                              <asp:Label ID="lblEmail" runat="server" Text="Email" meta:resourcekey="lblEmailResource1"></asp:Label>              
                           </div>
                           <div class="InputDiv">
                              <asp:TextBox ID="txtEmail" class="InputDiv" runat="server" Width="80%" TextMode="Email" MaxLength="50" meta:resourcekey="txtEmailResource1"></asp:TextBox>                       
                           </div>
                       </div>

                       <div id="Phone1_Secondary" class="secondary-form-group" runat="server">
                           <div id="Phone1_div" class="TextDiv" runat="server">
                               <asp:Label ID="lblPhone1" Text="Phone 1 :" runat="server" meta:resourcekey="lblPhone1Resource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtPhone1" class="InputDiv" Width="80%" runat="server" meta:resourcekey="txtPhone1Resource1"></asp:TextBox>                 
                           </div>
                       </div>

                       <div id="Phone2_Secondary" class="secondary-form-group" runat="server">
                           <div id="Phone2_div" class="TextDiv" runat="server">
                               <asp:Label ID="lblPhone2" Text="Phone 2 :" runat="server" meta:resourcekey="lblPhone2Resource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtPhone2" class="InputDiv" Width="80%" runat="server" meta:resourcekey="txtPhone2Resource1"></asp:TextBox>                 
                           </div>
                       </div>

                        <div id="Address_Secondary" class="secondary-form-group" runat="server">
                           <div id="Address_div" class="TextDiv" runat="server">
                              <asp:Label ID="lblAddress" Text="Address :" runat="server" meta:resourcekey="lblAddressResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtAddress" class="InputDiv" TextMode="MultiLine" Height="30px" Width="80%" runat="server" meta:resourcekey="txtAddressResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div id="Delegates_Secondary" class="secondary-form-group" runat="server">
                           <div id="Delegates_div" class="TextDiv" runat="server">
                               <asp:Label ID="lblDelegates" Text="Delegates :" runat="server" meta:resourcekey="lblDelegatesResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvDelegates" ErrorMessage="Delegates is required"
                                   ControlToValidate="ddlDelegates" ValidationGroup="Save" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvDelegatesResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceDelegates" TargetControlID="rfvDelegates" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>  
                           </div>
                           <div class="InputDiv">
                               <asp:DropDownList ID="ddlDelegates" class="InputDiv" Width="80%" runat="server" meta:resourcekey="ddlDelegatesResource1">
                               </asp:DropDownList>                   
                           </div>
                       </div>
                            
                        <div id="ResponsiblePerson_secondary" class="secondary-form-group" runat="server">
                           <div id="ResponsiblePerson_div" class="TextDiv" runat="server">
                              <asp:Label ID="lblResponsiblePerson" runat="server" Text="Responsible Person" meta:resourcekey="lblResponsiblePersonResource1"></asp:Label>
                              <asp:RequiredFieldValidator runat="server" ID="rfvResponsiblePerson" ErrorMessage="Responsible Person is required"
                              ControlToValidate="txtResponsiblePerson" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvResponsiblePersonResource1">*
                              </asp:RequiredFieldValidator>
                              <AJAX:ValidatorCalloutExtender runat="server" ID="vceResponsiblePerson" TargetControlID="rfvResponsiblePerson" Enabled="True">
                              </AJAX:ValidatorCalloutExtender>      
                               
                           </div>
                           <div class="InputDiv">
                              <asp:TextBox ID="txtResponsiblePerson" class="InputDiv" runat="server" Width="80%" meta:resourcekey="txtResponsiblePersonResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div class="form-group">
                           <br />
                       </div>
                      <div id="Controls" class="Controls" style="text-align: center; margin-left:15%" runat="server">
                          <asp:Button ID="btn_Save" runat="server" Text="Save" ValidationGroup="Save"  CssClass="btn btn-primary" meta:resourcekey="btn_SaveResource1"/>
                          <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CssClass="btn btn-primary" meta:resourcekey="btn_CancelResource1" />
       	           </div> 
               </div>
           </div>
         </div>
      </asp:panel>
</asp:Content>
