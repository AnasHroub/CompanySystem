<%@ Page Title="" Language="C#" MasterPageFile="~/WebMaster.Master" AutoEventWireup="true" CodeBehind="NotAuthorizedPage.aspx.cs" Inherits="CompanySystem.GUI.Error.NotAuthorizedPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
  <div id="MainDiv" class="MainDiv">
       <asp:UpdatePanel runat="server" ID="upNotAuthorizedArea" RenderMode="Inline" UpdateMode="Conditional">
            <ContentTemplate>
                <table border="0">
                    <tr>
                        <td>
                            <table class="MainTable" border="0">
                                <tr>
                                    <td>
                                        <table border="0">
                                            <tr>
                                                <td>
                                                    <img src="../../App_Themes/Images/403.jpg" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
   </div>
</asp:Content>
