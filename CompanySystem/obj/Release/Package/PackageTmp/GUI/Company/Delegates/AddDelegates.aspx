<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="AddDelegates.aspx.cs" Inherits="AddDelegates" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
          
      <asp:panel id="Panel1" runat="server" meta:resourcekey="Panel1Resource1">
      
         <div id="Delegate" class="panel-primary">
               <div class="panel-heading">
                   <h3 class="panel-title">
                       <asp:Literal ID="Li_panel_title" runat="server" meta:resourcekey="Li_panel_titleResource1"/>
                   </h3>
               </div>
               <div class="panel-body">
                   <div class="Secondery-panel-content">
      
                       <div id="div_Name_secondary" class="secondary-form-group" runat="server">
                           <div id="div_Name" class="TextDiv" runat="server">
                               <asp:Label ID="lblName" class="TextDiv" runat="server" Text="Name :" meta:resourcekey="lblNameResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtName" class="InputDiv" runat="server" meta:resourcekey="txtNameResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div id="div_BirthDate_secondary" class="secondary-form-group" runat="server">
                           <div id="div_BirthDate" class="TextDiv" runat="server">
                                <asp:Label ID="lblBirthDate" class="TextDiv" runat="server" Text="Birth Date :" meta:resourcekey="lblBirthDateResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtBirthDate" runat="server" class="InputDiv" TextMode="Date" meta:resourcekey="txtBirthDateResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div  id="div_Gender_secondary" class="secondary-form-group" runat="server">
                           <div id="div_Gender" class="TextDiv" runat="server">
                               <asp:Label ID="lblGender" runat="server" class="TextDiv" Text="Gender" meta:resourcekey="lblGenderResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:DropDownList runat="server" ID="ddlgender" class="InputDiv" ValidationGroup="Save" meta:resourcekey="ddlgenderResource1">
                               </asp:DropDownList>        
                               <asp:RequiredFieldValidator runat="server" ID="rfvGender" ErrorMessage="Gender is required" InitialValue="0"
                                 ControlToValidate="ddlgender" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvGenderResource1" Text="*
                              "></asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceGender" TargetControlID="rfvGender" Enabled="True">
                              </AJAX:ValidatorCalloutExtender>  
                           </div>
                       </div>
                  
                       <div id="div_MaritalStatus_secondary" class="secondary-form-group" runat="server">
                           <div id="div_MaritalStatus" class="TextDiv" runat="server">
                               <asp:Label ID="lblMaritalStatus" Text="Marital Status :" class="TextDiv" runat="server" meta:resourcekey="lblMaritalStatusResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:DropDownList ID="ddlMaritalStatus" class="InputDiv" runat="server" ValidationGroup="Save" meta:resourcekey="ddlMaritalStatusResource1">
                               </asp:DropDownList>
                               <asp:RequiredFieldValidator runat="server" ID="rfvMaritalStatus" ErrorMessage="Marital Status is required"  InitialValue="0"
                                 ControlToValidate="ddlMaritalStatus" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvMaritalStatusResource1" Text="*
                              "></asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceMaritalStatus" TargetControlID="rfvMaritalStatus" Enabled="True">
                              </AJAX:ValidatorCalloutExtender> 
                           </div>
                       </div>
                       
                       <div id="div_Phone_secondary" class="secondary-form-group" runat="server">
                           <div id="div_Phone" class="TextDiv" runat="server">
                               <asp:Label ID="lblPhone" class="TextDiv" Text="Phone No :" runat="server" meta:resourcekey="lblPhoneResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtPhone" class="InputDiv" runat="server" meta:resourcekey="txtPhoneResource1"></asp:TextBox>                 
                           </div>
                       </div>
      
                        <div id="div_Address_secondary" class="secondary-form-group" runat="server">
                           <div id="div_Address" class="TextDiv" runat="server">
                              <asp:Label ID="lblAddress" class="TextDiv" Text="Address :" runat="server" meta:resourcekey="lblAddressResource1"></asp:Label>
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtAddress" TextMode="MultiLine" Height="30px" class="InputDiv" runat="server" meta:resourcekey="txtAddressResource1"></asp:TextBox>
                           </div>
                       </div>
      
                        <div id="div_Email_secondary" class="secondary-form-group" runat="server">
                           <div id="div_Email" class="TextDiv" runat="server">
                              <asp:Label ID="lblEmail" runat="server" class="TextDiv" Text="Email" meta:resourcekey="lblEmailResource1"></asp:Label>
                              <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ErrorMessage="Email is required"
                              ControlToValidate="txtEmail" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvEmailResource1" Text="*
                              "></asp:RequiredFieldValidator>
                              <AJAX:ValidatorCalloutExtender runat="server" ID="vceEmail" TargetControlID="rfvEmail" Enabled="True">
                              </AJAX:ValidatorCalloutExtender>               
                           </div>
                           <div class="InputDiv">
                              <asp:TextBox ID="txtEmail" runat="server" class="InputDiv" TextMode="Email" MaxLength="50" meta:resourcekey="txtEmailResource1"></asp:TextBox>                       
                           </div>
                       </div>
                       
                        <div id="div_Password_secondary" class="secondary-form-group" runat="server">
                           <div id="div_Password" class="TextDiv" runat="server">
                              <asp:Label ID="lblPassword" class="TextDiv" runat="server" Text="Password" meta:resourcekey="lblPasswordResource1"></asp:Label>
                              <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ErrorMessage="Password is required"
                              ControlToValidate="txtPassword" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvPasswordResource1" Text="*
                              "></asp:RequiredFieldValidator>
                              <AJAX:ValidatorCalloutExtender runat="server" ID="vcePassword" TargetControlID="rfvPassword" Enabled="True">
                              </AJAX:ValidatorCalloutExtender>      
                               
                           </div>
                           <div class="InputDiv">
                              <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="InputDiv" MaxLength="15" meta:resourcekey="txtPasswordResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div class="form-group">
                           <br />
                       </div>
                      <div id="Controls" class="Controls" runat="server" style="text-align: center">
                          <asp:Button ID="btn_Save" runat="server" Text="Save" ValidationGroup="Save"  CssClass="btn btn-primary" meta:resourcekey="btn_SaveResource1" />
                          <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CssClass="btn btn-primary" meta:resourcekey="btn_CancelResource1" />
       	           </div> 
               </div>
           </div>
         </div>
      </asp:panel>
</asp:Content>
