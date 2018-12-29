<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="ClientsDelegates.aspx.cs" Inherits="ClientsDelegates" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">

       <style type="text/css">
          .CF
          {
            padding: 5%
          }
       </style>

       <script type="text/javascript">
           function confirmation_Approved()
           {
               if (document.getElementById("<%=hdn_Session.ClientID %>").value == "ar") {
                   return confirm("هل تريد قبول هذا السجل ؟");
               }
               else
               {
                  return confirm("Do you want to Approve this record ?");
               }
           }

           function confirmation_NonApproved()
           {
               if (document.getElementById("<%=hdn_Session.ClientID %>").value == "ar") {
                   return confirm("هل تريد عدم قبول هذا السجل ؟");
               }
               else
               {
                  return confirm("Do you want to Non Approve this record ?");
               }
           }
       </script>

        <asp:HiddenField ID="hdn_Session" runat="server" />
      
       <div>
          <br />
       </div> 
    
      <asp:GridView id="gvClientDelegate" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" 
             GridHeight="196px" Width="97.7%" ShowHeaderWhenEmpty="True" HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#068EC7" HeaderStyle-ForeColor="White" 
             meta:resourcekey="gvClientDelegateResource1" >
          <Columns>

               <asp:BoundField HeaderText="ID" DataField="ID" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" HeaderStyle-Width="6%" 
                   meta:resourcekey="BoundFieldResource1">
               </asp:BoundField>

               <asp:BoundField HeaderText="Name" DataField="Name" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" HeaderStyle-Width="12%"
                   meta:resourcekey="BoundFieldResource2">
               </asp:BoundField>

               <asp:BoundField HeaderText="Email" DataField="Email" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" HeaderStyle-Width="15%"
                   meta:resourcekey="BoundFieldResource3" >
               </asp:BoundField>

               <asp:BoundField HeaderText="Phone 1" DataField="Phone1" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter"  HeaderStyle-Width="7%" 
                   meta:resourcekey="BoundFieldResource4" >
               </asp:BoundField>

               <asp:BoundField HeaderText="Phone 2" DataField="Phone2" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter"  HeaderStyle-Width="7%" 
                   meta:resourcekey="BoundFieldResource5" >
               </asp:BoundField>

               <asp:BoundField HeaderText="Address" DataField="Address" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter"  HeaderStyle-Width="12%" 
                   meta:resourcekey="BoundFieldResource6" >
               </asp:BoundField>

               <asp:BoundField HeaderText="Delegate" DataField="Delegate" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" HeaderStyle-Width="12%" 
                   meta:resourcekey="BoundFieldResource7">
               </asp:BoundField>

               <asp:BoundField HeaderText="Responsible Person" DataField="Responsible_Person" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" 
                   HeaderStyle-Width="9%" meta:resourcekey="BoundFieldResource8">              
               </asp:BoundField>

               <asp:TemplateField HeaderText="Action" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter" meta:resourcekey="TemplateFieldResource1">
                   <ItemTemplate>
                      <asp:Button ID="btnApproved" runat="server" Text="Approve it" CssClass="btn btn-primary" CommandName="btn_Approved"  CommandArgument='<%# ((GridViewRow) Container).RowIndex %>' 
                          OnClientClick="return confirmation_Approved();" BackColor="Green" meta:resourcekey="btnApprovedResource1"/>
                      <asp:Button ID="btnNonApproved" runat="server" Text="Non Approve it" CssClass="btn btn-primary" CommandName="btn_Non_Approved" BackColor="Red"
                          CommandArgument='<%# Eval("ID") %>'  OnClientClick="return confirmation_NonApproved();" meta:resourcekey="btnNonApprovedResource1"/>
                   </ItemTemplate>
                </asp:TemplateField>

          </Columns>
     </asp:GridView>        
</asp:Content>

