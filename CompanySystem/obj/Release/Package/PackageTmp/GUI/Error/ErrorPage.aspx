<%@ Page Title="" Language="C#" MasterPageFile="~/WebMaster.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="CompanySystem.GUI.Error.ErrorPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
     <div id="MainDiv" class="MainDiv">
       <asp:UpdatePanel runat="server" ID="upLoginArea" RenderMode="Inline" UpdateMode="Conditional">
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
                                                    <img src="../../App_Themes/Images/Error.png" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblErrorInPage" runat="server"></asp:Label>
                                                    <br />
                                                    <asp:Label ID="lblMessageError" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                        <table border="0">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblStackTrace" runat="server" ForeColor="Red" Text="Error Message"
                                                        Width="100%"></asp:Label>
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
