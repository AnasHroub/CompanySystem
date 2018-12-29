<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="Items" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
          <style type="text/css">
          .ModalPopupBG
          {
              background-color: #666699;
              filter: alpha(opacity=50);
              opacity: 0.7;
          }
      
           .HellowWorldPopup
           {
               min-width:200px;
               min-height:150px;
               background:white;
           }
           .InputDiv
            {
                float: left;
                width: 70%;
                padding: 5px;
            }
       </style>

      <div>
         <div id="div_Search" runat="server">
             <asp:Label ID="lbl_Item" runat="server" Text="Item" CssClass="lblSearch" Width="4%" meta:resourcekey="lbl_ItemResource1"></asp:Label>
             <asp:TextBox ID="txtSearch" runat="server" Width="80.9%" meta:resourcekey="txtSearchResource1"></asp:TextBox>
             <asp:Button ID="btn_search" runat="server" Text="Search" CssClass="btn btn-primary" meta:resourcekey="btn_searchResource1" />
         </div>
       </div>
      
      
       <div>
          <br />
       </div>

      <div id="icn_btn" class="icn_btn" runat="server">
         <asp:ImageButton ID="imgAdd" runat="server" CausesValidation="False" CssClass="header_btn"
             ImageUrl="~/App_Themes/Images/btn_Add.png" ToolTip="Add" meta:Resourcekey="imgAddResource1"/>
      </div>
      
       <Ajax:ModalPopupExtender id="ModalPopupExtender1" runat="server" popupcontrolid="Panel1" TargetControlID="imgAdd" 
          popupdraghandlecontrolid="PopupHeader" drag="True" backgroundcssclass="ModalPopupBG" DynamicServicePath="" Enabled="True">
      </Ajax:ModalPopupExtender>

       <div>
          <br />
       </div>
                  
       <asp:GridView id="gvItem" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" 
                     GridHeight="196px" Width="97.7%" ShowHeaderWhenEmpty="True" meta:resourcekey="gvItemResource1">
           <Columns>

             <asp:BoundField HeaderText="ID" DataField="ID" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource1">
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Code" DataField="Code" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource2">
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Name" DataField="Name" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource3">
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Group Name" DataField="Group_Name" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource4">
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Largist Unit Type" DataField="Largist_Unit_Type" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource5">
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Smallest Unit Type" DataField="Smallest_Unit_Type" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource6">             
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Largist Unit Price" DataField="Largist_Unit_Price" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource7">
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:BoundField HeaderText="Smallest Unit Price" DataField="Smallest_Unit_Price" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource8">             
<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>
             <asp:TemplateField HeaderText="Edit" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource1">
                <ItemTemplate>
                  <asp:ImageButton ID="grv_img_edit" runat="server" ImageUrl="~/App_Themes/Images/edit.png" 
                      Width="15px" Height="15px"  PostBackUrl='<%# Eval("ID", "?ID={0}") %>' CommandName="img_edit" CommandArgument='<%# Eval("ID") %>' meta:resourcekey="grv_img_editResource1" />
                </ItemTemplate>

<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Delete" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource2">
                 <ItemTemplate>
                  <asp:ImageButton ID="grv_img_delete" runat="server" ImageUrl="~/App_Themes/Images/delete.png" 
                      Width="15px" Height="15px" CommandName="img_delete" CommandArgument='<%# Eval("ID") %>'
                      OnClientClick="return confirm('Do you want to delete this record ?!');" meta:resourcekey="grv_img_deleteResource1"/>
                 </ItemTemplate>

<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
             </asp:TemplateField>
          </Columns>
       </asp:GridView>
      
      <asp:panel id="Panel1" style="display: none" runat="server" meta:resourcekey="Panel1Resource1">
      
         <div id="Delegate" class="panel-primary">
               <div class="panel-heading">
                   <h3 class="panel-title">
                       <asp:Literal ID="Li_panel_title" runat="server" meta:resourcekey="Li_panel_titleResource1"/>
                   </h3>
               </div>
               <div class="panel-body">
                   <div class="Secondery-panel-content">

                       <div id="div_Code_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                              <asp:Label ID="lblCode" runat="server" Text="Code" meta:resourcekey="lblCodeResource1"></asp:Label>
                              <asp:RequiredFieldValidator runat="server" ID="rfvCode" ErrorMessage="Code is required"
                              ControlToValidate="txtCode" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvCodeResource1">*
                              </asp:RequiredFieldValidator>
                              <AJAX:ValidatorCalloutExtender runat="server" ID="vceCode" TargetControlID="rfvCode" Enabled="True">
                              </AJAX:ValidatorCalloutExtender>               
                           </div>
                           <div class="InputDiv">
                              <asp:TextBox ID="txtCode" runat="server" Width="80%" meta:resourcekey="txtCodeResource1"></asp:TextBox>                       
                           </div>
                       </div>
      
                       <div id="div_Name_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                               <asp:Label ID="lblName" runat="server" Text="Name :" meta:resourcekey="lblNameResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvName" ErrorMessage="Name is required"
                                   ControlToValidate="txtName" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvNameResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vcename" TargetControlID="rfvName" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>         
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtName" runat="server" Width="80%" meta:resourcekey="txtNameResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div id="div_Groups_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                               <asp:Label ID="lblGroups" Text="Groups :" runat="server" meta:resourcekey="lblGroupsResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvGroups" ErrorMessage="Groups is required"
                                   ControlToValidate="ddlGroups" ValidationGroup="Save" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvGroupsResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceGroups" TargetControlID="rfvGroups" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>  
                           </div>
                           <div class="InputDiv">
                               <asp:DropDownList ID="ddlGroups" Width="80%" runat="server" meta:resourcekey="ddlGroupsResource1">
                               </asp:DropDownList>                   
                           </div>
                       </div>

                       <div id="div_LargistUnitType_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                               <asp:Label ID="lblLargistUnitType" runat="server" Text="Largist Unit Type :" meta:resourcekey="lblLargistUnitTypeResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvLargistUnitType" ErrorMessage="Largist Unit Type is required"
                                   ControlToValidate="txtLargistUnitype" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvLargistUnitTypeResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceLargistUnitType" TargetControlID="rfvLargistUnitType" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>         
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtLargistUnitype" runat="server" Width="80%" meta:resourcekey="txtLargistUnitypeResource1"></asp:TextBox>
                           </div>
                       </div>

                        <div id="div_SmallestUnitType_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                               <asp:Label ID="lblSmallestUnitType" runat="server" Text="Smallest Unit Type :" meta:resourcekey="lblSmallestUnitTypeResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvSmallestUnitType" ErrorMessage="Smallest Unit Type is required"
                                   ControlToValidate="txtSmallestUnitype" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvSmallestUnitTypeResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceSmallestUnitType" TargetControlID="rfvSmallestUnitType" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>         
                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtSmallestUnitype" runat="server" Width="80%" meta:resourcekey="txtSmallestUnitypeResource1"></asp:TextBox>
                           </div>
                       </div>

                       <div id="div_LargestUnit_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                                <asp:Label ID="lblLargestUnit" runat="server" Text="Largist Unit Price :" meta:resourcekey="lblLargestUnitResource1"></asp:Label>
                                <asp:RequiredFieldValidator runat="server" ID="rfvLargestUnit" ErrorMessage="Largist Unit Price is required"
                                   ControlToValidate="txtLargestUnit" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvLargestUnitResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender runat="server" ID="vceLargestUnit" TargetControlID="rfvLargestUnit" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>  

                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtLargestUnit" runat="server" Width="80%" meta:resourcekey="txtLargestUnitResource1"></asp:TextBox>
                           </div>
                       </div>
      
                       <div id="div_SmallestUnit_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv">
                                <asp:Label ID="lblSmallestUnit" runat="server" Text="Smallest Unit Price :" meta:resourcekey="lblSmallestUnitResource1"></asp:Label>
                                <asp:RequiredFieldValidator runat="server" ID="rfvSmallestUnit" ErrorMessage="Smallest Unit Price is required"
                                   ControlToValidate="txtSmallestUnit" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvSmallestUnitResource1">*
                                </asp:RequiredFieldValidator>
                                <AJAX:ValidatorCalloutExtender runat="server" ID="vcereqSmallestUnit" TargetControlID="rfvLargestUnit" Enabled="True">
                               </AJAX:ValidatorCalloutExtender>  
                               <asp:RegularExpressionValidator ID="regSmallestUnit" runat="server" ErrorMessage="Smallest Unit Price is required must be numbers only and three points decimal"
                                  ControlToValidate="txtSmallestUnit" ValidationGroup="Save" SetFocusOnError="True" ValidationExpression="^[0-9]{1,10}(?:\.[0-9]{1,3})?$" meta:resourcekey="regSmallestUnitResource1" ></asp:RegularExpressionValidator>
                                <AJAX:ValidatorCalloutExtender runat="server" ID="vceregSmallestUnit" TargetControlID="regSmallestUnit" Enabled="True">
                               </AJAX:ValidatorCalloutExtender> 
                              <asp:RegularExpressionValidator ID="regLargestUnit" runat="server" ErrorMessage="Largest Unit Price is required must be numbers only and three points decimal"
                                  ControlToValidate="txtLargestUnit" ValidationGroup="Save" SetFocusOnError="True" ValidationExpression="^[0-9]{1,10}(?:\.[0-9]{1,3})?$" meta:resourcekey="regLargestUnitResource1" ></asp:RegularExpressionValidator>
                                <AJAX:ValidatorCalloutExtender runat="server" ID="vceregLargesttUnit" TargetControlID="regLargestUnit" Enabled="True">
                               </AJAX:ValidatorCalloutExtender> 

                           </div>
                           <div class="InputDiv">
                               <asp:TextBox ID="txtSmallestUnit" runat="server" Width="80%" meta:resourcekey="txtSmallestUnitResource1"></asp:TextBox>
                           </div>
                       </div>                                
      
                       <div class="form-group">
                           <br />
                       </div>
                      <div id="Controls" class="Controls" style="text-align: center" runat="server">
                          <asp:Button ID="btn_Save" runat="server" Text="Save" ValidationGroup="Save"  CssClass="btn btn-primary" meta:resourcekey="btn_SaveResource1" />
                          <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CssClass="btn btn-primary" meta:resourcekey="btn_CancelResource1" />
       	           </div> 
               </div>
           </div>
         </div>
      </asp:panel>
</asp:Content>
