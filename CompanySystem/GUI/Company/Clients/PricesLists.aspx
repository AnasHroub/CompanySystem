<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="PricesLists.aspx.cs" Inherits="PricesLists" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

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
            }
            .CF
            {
             padding-left: 5%;
             padding-right: 5%;

            }
       </style>

       <div>
          <br />
       </div>

      <div id="icn_btn" class="icn_btn" runat="server">
         <asp:ImageButton ID="imgAdd" runat="server" CausesValidation="False" CssClass="header_btn"
             ImageUrl="~/App_Themes/Images/btn_Add.png" ToolTip="Add" meta:Resourcekey="imgAddResource1"/>
      </div>
      
       <Ajax:ModalPopupExtender id="ModalPopupExtender1" runat="server" popupcontrolid="Panel1" TargetControlID="imgAdd" 
          popupdraghandlecontrolid="PopupHeader" drag="True" backgroundcssclass="ModalPopupBG" Enabled="True">
      </Ajax:ModalPopupExtender>

       <div>
          <br />
       </div>

       <asp:GridView id="gvTableOfPriceLists" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" GridHeight="196px"
           Width="97.7%" ShowHeaderWhenEmpty="True" HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#068EC7" HeaderStyle-ForeColor="White" meta:resourcekey="gvTableOfPriceListsResource1">

           <Columns>

                <asp:TemplateField HeaderText="ID" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="20%" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource1">
                   <ItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource2"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource1"></asp:Label>
                   </EditItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Name" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="50%" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource2">
                   <ItemTemplate>
                      <asp:Label ID="lblgvName" runat="server" Text='<%# Eval("Name") %>' meta:resourcekey="lblgvNameResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvName" runat="server"  Width="80%" Text='<%# Eval("Name") %>' meta:resourcekey="txtgvNameResource1"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvName" ErrorMessage="Name is required"
                           ControlToValidate="txtgvName" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvNameResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvName" TargetControlID="rfvgvName" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                  </EditItemTemplate> 
               </asp:TemplateField>

                <asp:CommandField HeaderText="Action" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" ValidationGroup="EditSave" ButtonType="Image" 
                    ShowDeleteButton="true" DeleteText="Delete" DeleteImageUrl="~/App_Themes/Images/delete.png"  ShowEditButton="true" EditText="Edit" 
                    EditImageUrl="~/App_Themes/Images/edit.png" ShowCancelButton="true" CancelImageUrl="~/App_Themes/Images/cancel.png" 
                    UpdateImageUrl="~/App_Themes/Images/Update.png" meta:resourcekey="CFgv_ActionResource1" ControlStyle-CssClass="CF" >
                </asp:CommandField>
         </Columns>
       </asp:GridView>
      
      <asp:panel id="Panel1" style="display: none" runat="server" meta:resourcekey="Panel1Resource1">
      
         <div id="Group" class="panel-primary">
               <div class="panel-heading">
                   <h3 class="panel-title">
                      <asp:Literal ID="Li_panel_title" runat="server" meta:resourcekey="Li_panel_titleResource1"/>
                   </h3>
               </div>
               <div class="panel-body">
                   <div class="Secondery-panel-content">
      
                       <div id="div_Name_secondary" class="secondary-form-group" runat="server">
                           <div class="TextDiv" >
                               <asp:Label ID="lblName" runat="server" Text="Name :" meta:resourcekey="lblNameResource1"></asp:Label>
                               <asp:RequiredFieldValidator runat="server" ID="rfvName" ErrorMessage="Name is required"
                                  ControlToValidate="txtName"  ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvNameResource1">*
                               </asp:RequiredFieldValidator>
                               <AJAX:ValidatorCalloutExtender  runat="server" ID="vceName" TargetControlID="rfvName" Enabled="True">
                              </AJAX:ValidatorCalloutExtender>     
                          </div>
                          <div class="InputDiv">
                              <asp:TextBox ID="txtName" runat="server" Width="70%" meta:resourcekey="txtNameResource1"></asp:TextBox>
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
