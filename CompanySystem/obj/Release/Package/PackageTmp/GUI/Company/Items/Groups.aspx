<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Groups.aspx.cs" Inherits="Groups" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

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
       </style>

      <div>
         <div id="div_Search" runat="server">
             <asp:Label ID="lbl_Group" runat="server" Text="Group" CssClass="lblSearch" Width="5%" meta:resourcekey="lbl_GroupResource1"></asp:Label>
             <asp:TextBox ID="txtSearch" runat="server" width="79.9%" meta:resourcekey="txtSearchResource1"></asp:TextBox>
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
                  
       <asp:GridView id="gvGroups" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" 
                     GridHeight="196px" Width="97.7%" ShowHeaderWhenEmpty="True" meta:resourcekey="gvGroupsResource1">

           <Columns>

             <asp:BoundField HeaderText="ID" DataField="ID" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource1">

<HeaderStyle CssClass="textCenter"></HeaderStyle>

<ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:BoundField>

             <asp:BoundField HeaderText="Name" DataField="Name" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="BoundFieldResource2">           
             
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
