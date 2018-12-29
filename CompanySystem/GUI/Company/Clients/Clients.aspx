<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Clients.aspx.cs" Inherits="Clients" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">      
      
       <style type="text/css">
          .CF
          {
             padding-left: 5%;
             padding-right: 5%;
          }
       </style>

       <div>
          <br />
       </div>
                  
       <asp:GridView id="gvClient" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" AllowSorting="True"
            GridHeight="196px" Width="97.7%" ShowHeaderWhenEmpty="True" HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#068EC7" HeaderStyle-ForeColor="White" 
            meta:resourcekey="gvClientResource1" >
         <Columns>

               <asp:TemplateField HeaderText="ID" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="6%" ItemStyle-CssClass="textCenter" SortExpression="ID" meta:resourcekey="TemplateFieldResource3">
                   <HeaderTemplate>
                       <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="ID" ForeColor="White" meta:resourcekey="TF_hdr_ID_Resource1"></asp:LinkButton>
                       <asp:TextBox ID="TF_hdr_ID"  runat="server" AutoPostBack="True" Width="70%" TextMode="Number" Style=" margin-top:7%"
                          OnTextChanged="TF_hdr_TextChanged" meta:resourcekey="TF_hdr_IDResource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource2"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource1"></asp:Label>
                   </EditItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Name" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="14%" ItemStyle-CssClass="textCenter" SortExpression="Name" meta:resourcekey="TemplateFieldResource4">
                  <HeaderTemplate>
                      <asp:LinkButton  runat="server" CommandName="Sort" CommandArgument="Name" ForeColor="White" meta:resourcekey="TF_hdr_Name_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Name" runat="server" Width="80%" Style="margin-top:5%" AutoPostBack="True" OnTextChanged="TF_hdr_TextChanged" meta:resourcekey="TF_hdr_NameResource1"></asp:TextBox>
                   </HeaderTemplate>
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

                 <asp:TemplateField HeaderText="Email" HeaderStyle-Width="13%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" SortExpression="Email" meta:resourcekey="TemplateFieldResource5">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Email"  ForeColor="White" meta:resourcekey="TF_hdr_Email_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Email" runat="server" OnTextChanged="TF_hdr_TextChanged" AutoPostBack="True" TextMode="Email" Width="95%" Style=" margin-top:5%;" meta:resourcekey="TF_hdr_EmailResource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvEmail" runat="server" Text='<%# Eval("Email") %>' meta:resourcekey="lblgvEmailResource1"></asp:Label>  
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvEmail" runat="server" TextMode="Email" Width="80%" Text='<%# Eval("Email") %>' meta:resourcekey="txtgvEmailResource1"></asp:TextBox>
                  </EditItemTemplate>
               </asp:TemplateField>

                <asp:TemplateField HeaderText="Phone 1" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="8%" ItemStyle-CssClass="textCenter" SortExpression="Phone1" meta:resourcekey="TemplateFieldResource6">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Phone1"  ForeColor="White" meta:resourcekey="TF_hdr_Phone1_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Phone1" runat="server" OnTextChanged="TF_hdr_TextChanged" AutoPostBack="True" TextMode="Phone" MaxLength="10" Width="90%" Style=" margin-top:5%;" meta:resourcekey="TF_hdr_Phone1Resource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvPhone1" runat="server" Text='<%# Eval("Phone1") %>' meta:resourcekey="lblgvPhone1Resource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvPhone1" runat="server"  Width="80%" Text='<%# Eval("Phone1") %>' meta:resourcekey="txtgvPhone1Resource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Phone 2" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="8%" ItemStyle-CssClass="textCenter" SortExpression="Phone2" meta:resourcekey="TemplateFieldResource7">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Phone2"  ForeColor="White" meta:resourcekey="TF_hdr_Phone2_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Phone2" runat="server" OnTextChanged="TF_hdr_TextChanged" AutoPostBack="True" TextMode="Phone" MaxLength="10" Width="90%" Style=" margin-top:5%;" meta:resourcekey="TF_hdr_Phone2Resource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvPhone2" runat="server" Text='<%# Eval("Phone2") %>' meta:resourcekey="lblgvPhone2Resource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvPhone2" runat="server"  Width="80%" Text='<%# Eval("Phone2") %>' meta:resourcekey="txtgvPhone2Resource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

              <asp:TemplateField HeaderText="Address" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="15%" ItemStyle-CssClass="textCenter" SortExpression="Address" meta:resourcekey="TemplateFieldResource8">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Address"  ForeColor="White" meta:resourcekey="TF_hdr_Address_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Address" runat="server" OnTextChanged="TF_hdr_TextChanged" AutoPostBack="True" TextMode="Search" Width="100%" Style=" margin-top:5%;" meta:resourcekey="TF_hdr_AddressResource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvAddress" runat="server" Text='<%# Eval("Address") %>' meta:resourcekey="lblgvAddressResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvAddress" runat="server"  Width="80%" Text='<%# Eval("Address") %>' meta:resourcekey="txtgvAddressResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

                <asp:TemplateField  HeaderText="Delegate" HeaderStyle-Width="12%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" SortExpression="Delegate" meta:resourcekey="TemplateFieldResource9">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Delegate" ForeColor="White" meta:resourcekey="TF_hdr_Delegate_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Delegate" runat="server" OnTextChanged="TF_hdr_TextChanged" AutoPostBack="True" TextMode="Search" Width="100%" Style=" margin-top:5%;" meta:resourcekey="TF_hdr_AddressResource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate >
                      <asp:Label ID="lblgvDelegate" runat="server" Text='<%# Eval("Delegate") %>' meta:resourcekey="lblgvDelegateResource1"></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:DropDownList ID="ddlgvDelegate" Width="100%" runat="server" meta:resourcekey="ddlgvDelegateResource1">
                      </asp:DropDownList>    
                      <asp:HiddenField ID="hdgvDelegate" runat="server" Value='<%# Eval("Delegate") %>' />  
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvDelegate" ErrorMessage="Delegate is required"
                           ControlToValidate="ddlgvDelegate" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvDelegateResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvDelegate" TargetControlID="rfvgvDelegate" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                  </EditItemTemplate> 
               </asp:TemplateField>

              <asp:TemplateField HeaderText="Responsible Person" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="12%" ItemStyle-CssClass="textCenter" SortExpression="Responsible_Person" meta:resourcekey="TemplateFieldResource10">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Responsible_Person"  ForeColor="White" meta:resourcekey="TF_hdr_Responsible_Person_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Responsible_Person" runat="server" OnTextChanged="TF_hdr_TextChanged" AutoPostBack="True" TextMode="Search" Width="100%" Style=" margin-top:5%;" meta:resourcekey="TF_hdr_Responsible_PersonResource1" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvResponsible_Person" runat="server" Text='<%# Eval("Responsible_Person") %>' meta:resourcekey="lblgvResponsible_PersonResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvResponsible_Person" runat="server"  Width="80%" Text='<%# Eval("Responsible_Person") %>' meta:resourcekey="txtgvResponsible_PersonResource1"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvResponsible_Person" ErrorMessage="Responsible Person is required"
                           ControlToValidate="txtgvResponsible_Person" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvResponsible_PersonResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvResponsible_Person" TargetControlID="rfvgvResponsible_Person" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                  </EditItemTemplate> 
               </asp:TemplateField>

                <asp:CommandField HeaderText="Action" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter"  ValidationGroup="EditSave"  ButtonType="Image" 
                    ShowDeleteButton="true" DeleteText="Delete" DeleteImageUrl="~/App_Themes/Images/delete.png"  ShowEditButton="true" EditText="Edit" 
                    EditImageUrl="~/App_Themes/Images/edit.png" ShowCancelButton="true" CancelImageUrl="~/App_Themes/Images/cancel.png" 
                    UpdateImageUrl="~/App_Themes/Images/Update.png" meta:resourcekey="CFgv_ActionResource1" ControlStyle-CssClass="CF" >
                </asp:CommandField>

           </Columns>
       </asp:GridView>   
</asp:Content>
