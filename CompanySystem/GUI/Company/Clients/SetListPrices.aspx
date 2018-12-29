<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="SetListPrices.aspx.cs" Inherits="SetListPrices" %>

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


       <asp:MultiView ID="MultiView"  runat="server">

           <asp:View ID="View1" runat="server">
              <asp:GridView id="gvSetListPrices_1" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" GridHeight="196px"
                Width="97.7%" ShowHeaderWhenEmpty="True" HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#068EC7" HeaderStyle-ForeColor="White" >

                 <Columns>

                    <asp:BoundField HeaderText="ID" DataField="ID" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="20%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>
                  
                    <asp:BoundField HeaderText="PriceList" DataField="Name" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="50%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>
                  
                    <asp:TemplateField HeaderText="Action" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter">
                      <ItemTemplate>
                        <asp:Button ID="btnSetPrice" runat="server" Text="Set Prices" CssClass="btn btn-primary" CommandName="btn_Set_Prices" BackColor="Green"
                          PostBackUrl='<%# Eval("ID", "?ID={0}") + Eval("Name", "?Name={0}") %>' CommandArgument='<%# Session["PriceList"] = Eval("Name") %>'/>
                      </ItemTemplate>
                    </asp:TemplateField>

                 </Columns>
              </asp:GridView>
           </asp:View>

           <asp:View ID="View2" runat="server">
              <asp:GridView id="gvSetListPrices_2" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="GridView" GridHeight="196px"
                 Width="97.7%" ShowHeaderWhenEmpty="True" HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#068EC7" HeaderStyle-ForeColor="White" >

                 <Columns>

                    <asp:BoundField HeaderText="ID" DataField="ID" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="20%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>
                  
                    <asp:BoundField HeaderText="Code" DataField="Code" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="30%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>
                  
                    <asp:BoundField HeaderText="Name" DataField="Name" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="30%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>

                    <asp:BoundField HeaderText="Group Name" DataField="Group_NAME" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="30%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>

                    <asp:BoundField HeaderText="Largist Unit Price" DataField="Largist_Unit_Prices" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="30%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>

                     <asp:BoundField HeaderText="Smallest Unit Price" DataField="Smallest_Unit_Prices" HeaderStyle-CssClass="textCenter"  HeaderStyle-Width="30%" ItemStyle-CssClass="textCenter">
                    </asp:BoundField>

                    <asp:TemplateField HeaderText="Action" HeaderStyle-CssClass="textCenter" ItemStyle-CssClass="textCenter">
                      <ItemTemplate>
                         <asp:ImageButton ID="grv_img_edit" runat="server" ImageUrl="~/App_Themes/Images/edit.png" Width="15px" Height="15px" PostBackUrl='<%# Eval("ID", "?ID={0}") %>' 
                            CommandName="img_edit" CommandArgument='<%# Eval("ID") %>'/>
                      </ItemTemplate>
                    </asp:TemplateField>

                 </Columns>
              </asp:GridView>
           </asp:View>


       </asp:MultiView>

</asp:Content>
