 <%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Delegates.aspx.cs" Inherits="Delegates" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
      
  <style>
    .CF
        {
          padding-left: 5%;
          padding-right: 5%;
        }
  </style>

       <div>
          <br />
       </div>
              <asp:HiddenField ID="hdn_Gender" runat="server" Value='<%# ViewState["hdr_ID"] %>' />  
       <asp:GridView id="gvDelegate" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" AllowSorting="true"
             GridHeight="196px" Width="97.7%"  ShowHeaderWhenEmpty="True" HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#068EC7" HeaderStyle-ForeColor="White" 
             meta:resourcekey="gvDelegateResource1">          
          <Columns>       
               <asp:TemplateField HeaderText="ID" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="6%" ItemStyle-CssClass="textCenter" SortExpression="ID">
                   <HeaderTemplate>
                       <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="ID" ForeColor="White" meta:resourcekey="TF_hdr_ID_Resource1"></asp:LinkButton>
                       <asp:TextBox ID="TF_hdr_ID"  runat="server" AutoPostBack="true" Text='<%# ViewState["hdr_ID"] %>' Width="70%" TextMode="Number" Style=" margin-top:7%"
                          OnTextChanged="TF_hdr_TextChanged" ></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource2"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                      <asp:Label ID="lblgvID" runat="server" Text='<%# Eval("ID") %>' meta:resourcekey="lblgvIDResource1"></asp:Label>
                   </EditItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Name" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="12%" ItemStyle-CssClass="textCenter" SortExpression="Name">
                  <HeaderTemplate>
                      <asp:LinkButton  runat="server" CommandName="Sort" CommandArgument="Name" ForeColor="White" meta:resourcekey="TF_hdr_Name_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Name" runat="server" Width="80%" Style="margin-top:5%" AutoPostBack="true" Text='<%# ViewState["hdr_Name"] %>' 
                          OnTextChanged="TF_hdr_TextChanged"> </asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvName" runat="server" Text='<%# Eval("Name") %>' meta:resourcekey="lblgvNameResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvName" runat="server"  Width="80%" Text='<%# Eval("Name") %>' meta:resourcekey="txtgvNameResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

               <asp:TemplateField  HeaderText="Gender" HeaderStyle-Width="6%" AccessibleHeaderText="2" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" SortExpression="Gender">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Gender" ForeColor="White" meta:resourcekey="TF_hdr_Gender_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:DropDownList ID="TF_hdr_Gender" runat="server" AutoPostBack="true"  Width="80%" Style="margin-top:6%;" OnTextChanged="TF_hdr_TextChanged" >
                      </asp:DropDownList>
                   </HeaderTemplate>
                   <ItemTemplate >
                      <asp:Label ID="lblgvGender" runat="server" Text='<%# Eval("Gender") %>' meta:resourcekey="lblgvGenderResource1"></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:DropDownList ID="ddlgvGender" Width="100%" runat="server" meta:resourcekey="ddlgvGenderResource1">
                      </asp:DropDownList>    
                      <asp:HiddenField ID="hdgvGender" runat="server" Value='<%# Eval("Gender") %>' /> 
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvGender" ErrorMessage="Gender is required"
                           ControlToValidate="ddlgvGender" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvGenderResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvGender" TargetControlID="rfvgvGender" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                  </EditItemTemplate> 
               </asp:TemplateField>

              <asp:TemplateField HeaderText="Martial Status" HeaderStyle-Width="10%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" 
                  SortExpression="Martial_Status" >
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Martial_Status" ForeColor="White" meta:resourcekey="TF_hdr_MartialStatus_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:DropDownList ID="TF_hdr_MartialStatus" runat="server" AutoPostBack="true"  Width="80%" Style="margin-top:10%;" OnTextChanged="TF_hdr_TextChanged" >
                      </asp:DropDownList>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvMartialStatus" runat="server" Text='<%# Eval("Martial_Status") %>' meta:resourcekey="lblgvMartialStatusResource1"></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:DropDownList ID="ddlgvMartialStatus" class="InputDiv" runat="server" meta:resourcekey="ddlgvMartialStatusResource1">
                      </asp:DropDownList>     
                      <asp:HiddenField ID="hdgvMartialStatus" runat="server" Value='<%# Eval("Martial_Status") %>' />  
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvMartialStatusr" ErrorMessage="Martial Status is required"
                           ControlToValidate="ddlgvMartialStatus" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvMartialStatusResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvMartialStatus" TargetControlID="rfvgvMartialStatusr" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                  </EditItemTemplate> 
               </asp:TemplateField>

              <asp:TemplateField HeaderText="Birth Date" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="07%" ItemStyle-CssClass="textCenter" 
                  SortExpression="Birth_Date">
                  <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Birth_Date" ForeColor="White" meta:resourcekey="TF_hdr_BirthDate_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_BirthDate" runat="server" AutoPostBack="true" Text='<%# ViewState["hdr_BirthDate"] %>' Width="90%" TextMode="Date" 
                        Style=" margin-top:5%;" OnTextChanged="TF_hdr_TextChanged"></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvBirthDate" runat="server" Text='<%# Eval("Birth_Date") %>' meta:resourcekey="lblgvBirthDateResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvBirthDate" runat="server"  TextMode="Date" Width="80%" Text='<%# Eval("Birth_Date") %>' meta:resourcekey="txtgvBirthDateResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Phone" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="07%" ItemStyle-CssClass="textCenter" SortExpression="Phone_NO">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Phone_NO"  ForeColor="White" meta:resourcekey="TF_hdr_Phone_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Phone" runat="server" AutoPostBack="true" Text='<%# ViewState["hdr_Phone"] %>' TextMode="Phone" MaxLength="10" Width="90%" 
                         Style=" margin-top:5%;" OnTextChanged="TF_hdr_TextChanged"></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvPhone" runat="server" Text='<%# Eval("Phone_NO") %>' meta:resourcekey="lblgvPhoneResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvPhone" runat="server"  Width="80%" Text='<%# Eval("Phone_NO") %>' meta:resourcekey="txtgvPhoneResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Address" HeaderStyle-CssClass="textCenter" HeaderStyle-Width="12%" ItemStyle-CssClass="textCenter" SortExpression="Address">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Address"  ForeColor="White" meta:resourcekey="TF_hdr_Address_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Address" runat="server" AutoPostBack="true" Text='<%# ViewState["hdr_Address"] %>' TextMode="Search" Width="100%" 
                         Style=" margin-top:5%;"  OnTextChanged="TF_hdr_TextChanged"></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvAddress" runat="server" Text='<%# Eval("Address") %>' meta:resourcekey="lblgvAddressResource1"></asp:Label> 
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtgvAddress" runat="server"  Width="80%" Text='<%# Eval("Address") %>' meta:resourcekey="txtgvAddressResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Email" HeaderStyle-Width="13%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" SortExpression="Email">
                   <HeaderTemplate>
                      <asp:LinkButton runat="server" CommandName="Sort" CommandArgument="Email"  ForeColor="White" meta:resourcekey="TF_hdr_Email_Resource1" ></asp:LinkButton>
                      <br />
                      <asp:TextBox ID="TF_hdr_Email" runat="server" AutoPostBack="true" Text='<%# ViewState["hdr_Email"] %>' TextMode="Email" Width="95%" 
                         Style=" margin-top:5%;" OnTextChanged="TF_hdr_TextChanged"></asp:TextBox>
                   </HeaderTemplate>
                   <ItemTemplate>
                      <asp:Label ID="lblgvEmail" runat="server" Text='<%# Eval("Email") %>' meta:resourcekey="lblgvEmailResource1"></asp:Label>  
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvEmail" ErrorMessage="Email is required"
                           ControlToValidate="txtgvEmail" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvEmailResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvEmail" TargetControlID="rfvgvEmail" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                     <asp:TextBox ID="txtgvEmail" runat="server" TextMode="Email" Width="80%" Text='<%# Eval("Email") %>' meta:resourcekey="txtgvEmailResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

              <asp:TemplateField HeaderText="Password" HeaderStyle-Width="12%" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TF_Password_Resource1">
                   <ItemTemplate>
                      <asp:Label ID="lblgvPassword" runat="server" Text='<%# Eval("Password") %>' meta:resourcekey="lblgvPasswordResource1"></asp:Label>  
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:RequiredFieldValidator runat="server" ID="rfvgvPassword" ErrorMessage="Password is required"
                           ControlToValidate="txtgvPassword" ValidationGroup="EditSave" SetFocusOnError="True" meta:resourcekey="rfvgvPasswordResource1">*
                      </asp:RequiredFieldValidator>
                      <AJAX:ValidatorCalloutExtender runat="server" ID="vcegvPassword" TargetControlID="rfvgvPassword" Enabled="True">
                      </AJAX:ValidatorCalloutExtender>
                     <asp:TextBox ID="txtgvPassword" runat="server" Width="80%" Text='<%# Eval("Password") %>' meta:resourcekey="txtgvPasswordResource1"></asp:TextBox>
                  </EditItemTemplate> 
               </asp:TemplateField>

                <asp:CommandField HeaderText="Action" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter"  ValidationGroup="EditSave"  ButtonType="Image" 
                    ShowDeleteButton="true" DeleteText="Delete" DeleteImageUrl="~/App_Themes/Images/delete.png"  ShowEditButton="true" EditText="<img src='~/edit.jpg' title='Edit' />" 
                    EditImageUrl="~/App_Themes/Images/edit.png" ShowCancelButton="true" CancelImageUrl="~/App_Themes/Images/cancel.png" 
                    UpdateImageUrl="~/App_Themes/Images/Update.png" meta:resourcekey="CommandFieldResource1" ControlStyle-CssClass="CF" >
                </asp:CommandField>



         </Columns>

       </asp:GridView>
     
</asp:Content>
