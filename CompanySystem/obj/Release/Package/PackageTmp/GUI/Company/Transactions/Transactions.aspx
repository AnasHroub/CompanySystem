<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="Transactions" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

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
             <asp:Label ID="lbl_Transaction" runat="server" Text="Delegate" CssClass="lblSearch" Width="7%" meta:resourcekey="lbl_TransactionResource1"></asp:Label>
             <asp:TextBox ID="txtSearch" runat="server" Width="77.9%" meta:resourcekey="txtSearchResource1"></asp:TextBox>
             <asp:Button ID="btn_search" runat="server" Text="Search" CssClass="btn btn-primary" meta:resourcekey="btn_searchResource1" />
         </div>
       </div>
      
      
       <div>
          <br />
       </div>
                  
       <asp:GridView id="gvTransactions" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" 
                     GridHeight="196px" Width="97.7%" ShowFooter="True" ShowHeaderWhenEmpty="True" meta:resourcekey="gvTransactionsResource1">
           <Columns>               
                <asp:TemplateField HeaderText="ID" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="4%" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource1">
                   <ItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource2"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource1"></asp:Label>
                   </EditItemTemplate>

                    <HeaderStyle CssClass="textCenter" Width="4%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Delegate" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="13%" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource2">
                   <ItemTemplate>
                      <asp:Label ID="lblgvDelegates" runat="server" Text='<%# Eval("Delegate") %>' meta:resourcekey="lblgvDelegatesResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvDelegates" ErrorMessage="Delegates is required"
                           ControlToValidate="ddlgvDelegates" ValidationGroup="EditSave" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvgvDelegatesResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvDelegates" TargetControlID="rfvgvDelegates" Enabled="True">
                      </AJAX:ValidatorCalloutExtender> 
                       <asp:DropDownList ID="ddlgvDelegates" Width="80%" runat="server" meta:resourcekey="ddlgvDelegatesResource1">                        
                       </asp:DropDownList>  
                      <asp:HiddenField ID="hdgvDelegates" runat="server" Value='<%# Eval("Delegate") %>' />
                  </EditItemTemplate> 
                  <FooterTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvDelegates" ErrorMessage="Delegates is required"
                           ControlToValidate="ddlgvDelegates" ValidationGroup="Save" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvgvDelegatesResource2">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvDelegates" TargetControlID="rfvgvDelegates" Enabled="True">
                      </AJAX:ValidatorCalloutExtender> 
                       <asp:DropDownList ID="ddlgvDelegates" Width="80%" runat="server" meta:resourcekey="ddlgvDelegatesResource2">
                       </asp:DropDownList>  
                  </FooterTemplate>

                    <HeaderStyle CssClass="textCenter" Width="13%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Group" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="13%" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource3">
                   <ItemTemplate>
                      <asp:Label ID="lblgvGroups" runat="server" Text='<%# Eval("Group") %>' meta:resourcekey="lblgvGroupsResource1"></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvGroups" ErrorMessage="Groups is required"
                           ControlToValidate="ddlgvGroups" ValidationGroup="EditSave" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvgvGroupsResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvGroups" TargetControlID="rfvgvGroups" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>  
                      <asp:DropDownList ID="ddlgvGroups" AutoPostBack="True" Width="80%" runat="server" OnSelectedIndexChanged="ddlgvGroups_SelectedIndexChanged1" meta:resourcekey="ddlgvGroupsResource1">
                      </asp:DropDownList>  
                     <asp:HiddenField ID="hdgvGroups" runat="server" Value='<%# Eval("Group") %>' />  
                  </EditItemTemplate> 
                  <FooterTemplate>
                     <asp:RequiredFieldValidator runat="server" ID="rfvgvGroups" ErrorMessage="Groups is required"
                           ControlToValidate="ddlgvGroups" ValidationGroup="Save" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvgvGroupsResource2">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvGroups" TargetControlID="rfvgvGroups" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>  
                       <asp:DropDownList ID="ddlgvGroups" AutoPostBack="True" Width="80%" runat="server" OnSelectedIndexChanged="ddlgvGroups_SelectedIndexChanged" meta:resourcekey="ddlgvGroupsResource2" >
                       </asp:DropDownList>  
                  </FooterTemplate>

                    <HeaderStyle CssClass="textCenter" Width="13%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Item" HeaderStyle-Width="10%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource4">
                   <ItemTemplate>
                      <asp:Label ID="lblgvItems" runat="server" Text='<%# Eval("Item") %>' meta:resourcekey="lblgvItemsResource1"></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                       <asp:RequiredFieldValidator runat="server" ID="rfvgvItems" ErrorMessage="Items is required"
                           ControlToValidate="ddlgvItems" ValidationGroup="EditSave" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvgvItemsResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvItems" TargetControlID="rfvgvItems" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>  
                      <asp:DropDownList ID="ddlgvItems" AutoPostBack="True" Width="80%" runat="server" meta:resourcekey="ddlgvItemsResource1">
                      </asp:DropDownList>    
                      <asp:HiddenField ID="hdgvItems" runat="server" Value='<%# Eval("Item") %>' />  
                  </EditItemTemplate> 
                  <FooterTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvItems" ErrorMessage="Items is required"
                           ControlToValidate="ddlgvItems" ValidationGroup="Save" SetFocusOnError="True" InitialValue="0" meta:resourcekey="rfvgvItemsResource2">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvItems" TargetControlID="rfvgvItems" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>  
                      <asp:DropDownList ID="ddlgvItems" AutoPostBack="True" Width="80%" runat="server" meta:resourcekey="ddlgvItemsResource2">
                      </asp:DropDownList>     
                  </FooterTemplate>

                    <HeaderStyle CssClass="textCenter" Width="10%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Largist Unit Quantity" HeaderStyle-Width="11%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource5">
                   <ItemTemplate>
                      <asp:Label ID="lblgvLargistUnit" runat="server" Text='<%# Eval("Largist_Unit_Quantity") %>' meta:resourcekey="lblgvLargistUnitResource1"></asp:Label>  
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvLargistUnit" ErrorMessage="Largist Unit Quantity is required"
                           ControlToValidate="txtgvLargistUnit" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvLargistUnitResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvLargistUnit" TargetControlID="rfvgvLargistUnit" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                     <asp:TextBox ID="txtgvLargistUnit" runat="server" TextMode="Number" MaxLength="15" Width="80%" Text='<%# Eval("Largist_Unit_Quantity") %>' meta:resourcekey="txtgvLargistUnitResource1"></asp:TextBox>
                  </EditItemTemplate> 
                  <FooterTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvLargistUnit" ErrorMessage="Largist Unit Quantity is required"
                           ControlToValidate="txtgvLargistUnit" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvgvLargistUnitResource2">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvLargistUnit" TargetControlID="rfvgvLargistUnit" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                     <asp:TextBox ID="txtgvLargistUnit" runat="server" TextMode="Number" MaxLength="15" Width="80%" meta:resourcekey="txtgvLargistUnitResource2"></asp:TextBox>   
                  </FooterTemplate>

                       <HeaderStyle CssClass="textCenter" Width="11%"></HeaderStyle>

                        <ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Smallest Unit Quantity" HeaderStyle-Width="12%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource6">
                   <ItemTemplate>
                      <asp:Label ID="lblgvSmallestUnit" runat="server" Text='<%# Eval("Smallest_Unit_Quantity") %>' meta:resourcekey="lblgvSmallestUnitResource1"></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                       <asp:RequiredFieldValidator runat="server" ID="rfvgvSmallestUnit" ErrorMessage="Smallest Unit Quantity is required"
                           ControlToValidate="txtgvSmallestUnit" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvSmallestUnitResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvSmallestUnit" TargetControlID="rfvgvSmallestUnit" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>  
                     <asp:TextBox ID="txtgvSmallestUnit" runat="server" TextMode="Number" MaxLength="15" Width="80%" Text='<%# Eval("Smallest_Unit_Quantity") %>' meta:resourcekey="txtgvSmallestUnitResource1"></asp:TextBox>
                  </EditItemTemplate> 
                  <FooterTemplate>
                     <asp:RequiredFieldValidator runat="server" ID="rfvgvSmallestUnit" ErrorMessage="Smallest Unit Quantity is required"
                           ControlToValidate="txtgvSmallestUnit" ValidationGroup="Save" SetFocusOnError="True" meta:resourcekey="rfvgvSmallestUnitResource2">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvSmallestUnit" TargetControlID="rfvgvSmallestUnit" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>  
                     <asp:TextBox ID="txtgvSmallestUnit" runat="server" TextMode="Number" MaxLength="15" Width="80%" meta:resourcekey="txtgvSmallestUnitResource2"></asp:TextBox>   
                  </FooterTemplate>

                    <HeaderStyle CssClass="textCenter" Width="12%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Inserted Date" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="12%" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource7">
                   <ItemTemplate>
                      <asp:Label ID="lblgvInsertedDate" runat="server" Text='<%# Eval("Inserted_Date") %>' meta:resourcekey="lblgvInsertedDateResource1"></asp:Label>
                   </ItemTemplate>

                    <HeaderStyle CssClass="textCenter" Width="12%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Updated Date" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="12%" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource8">
                   <ItemTemplate>
                      <asp:Label ID="lblgvUpdatedDate" runat="server" Text='<%# Eval("Updated_Date") %>' meta:resourcekey="lblgvUpdatedDateResource1"></asp:Label>
                   </ItemTemplate>

                    <HeaderStyle CssClass="textCenter" Width="12%"></HeaderStyle>

                    <ItemStyle CssClass="textCenter"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Add / Delete" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="12%" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource9">
                      <ItemTemplate>
                         <asp:Button ID="btnDelete" runat="server" Width="100%" OnClientClick="return confirm('Do you want to delete this record');" Text="Delete" 
                             CommandName="img_delete" CommandArgument='<%# Eval("ID") %>' CssClass="btn btn-primary" meta:resourcekey="btnDeleteResource1"/>
                     </ItemTemplate>
                      <FooterTemplate>
                         <asp:Button ID="btnAdd" runat="server" ValidationGroup="Save" Width="100%" OnClick="btnAdd_Click" Text="Add" 
                             CssClass="btn btn-primary" meta:resourcekey="btnAddResource1" />
                      </FooterTemplate>                      

                        <HeaderStyle CssClass="textCenter" Width="12%"></HeaderStyle>

                        <ItemStyle CssClass="textCenter"></ItemStyle>
                 </asp:TemplateField>

                 <asp:CommandField HeaderText="Update" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" 
                                   ShowEditButton="true" ValidationGroup="EditSave" meta:resourcekey="CommandFieldResource1"  >       
                           <HeaderStyle CssClass="textCenter"></HeaderStyle>

                           <ItemStyle CssClass="textCenter"></ItemStyle>
                </asp:CommandField>
             </Columns>
       </asp:GridView>     
</asp:Content>
