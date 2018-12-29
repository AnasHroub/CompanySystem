<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Reports" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AJAX" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

   <div class="secondary-form-group" style="text-align:center; padding-left: 20%">
      <div id="div_Text" class="TextDiv" style="width: 15%; padding: 5px;" runat="server">
          <asp:Label ID="lblReorts" Text="Select Report :" Font-Bold="true" runat="server"></asp:Label>
      </div>
      <div class="InputDiv" style="float: left; padding: 5px;">
        <asp:DropDownList ID="ddlReports" runat="server" Height="30px" AutoPostBack="true">
            <asp:ListItem Text="تقرير مبيعات عميل"                           Value="View1"></asp:ListItem>
            <asp:ListItem Text="تقرير مبيعات العملاء"                         Value="View2"></asp:ListItem>
            <asp:ListItem Text="تقرير مبيعات مندوب"                          Value="View3"></asp:ListItem>
            <asp:ListItem Text="تقرير المبيعات حسب المادة للعميل"          Value="View4"></asp:ListItem>
            <asp:ListItem Text="تقرير المبيعات حسب المادة للعملاء"          Value="View5"></asp:ListItem>
            <asp:ListItem Text="تقرير مبيعات المواد حسب المجموعة للعميل"  Value="View6"></asp:ListItem>
            <asp:ListItem Text="تقرير مبيعات المواد حسب المجموعة للعملاء"  Value="View7"></asp:ListItem>
            <asp:ListItem Text="تقرير الإدخال (الجرد) حسب المندوب"          Value="View8"></asp:ListItem>
        </asp:DropDownList>   
      </div>
    </div>

   <div class="form-group">
         <br />
     </div>

   <asp:MultiView ID="mvReports" runat="server" ActiveViewIndex="0">

        <asp:View ID="View1" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   <asp:Literal ID="Li_View1" runat="server" meta:resourcekey="Li_View1Resource1"/>
                    تقرير مبيعات عميل
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">
                    <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView1_ClientName" runat="server" Text="Client Name :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView1_ClientName" runat="server" ControlToValidate="ddlView1_ClientName" ValidationGroup="View1"
                            ErrorMessage ="Client Name is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView1_ClientName" TargetControlID="rfvView1_ClientName">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView1_ClientName" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView1_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView1_StartDate" runat="server" ControlToValidate="txtView1_StartDate" ValidationGroup="View1"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView1_StartDate" TargetControlID="rfvView1_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView1_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                     <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView1_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView1_EndDate" runat="server" ControlToValidate="txtView1_EndDate" ValidationGroup="View1"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView1_EndDate" TargetControlID="rfvView1_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView1_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View1" runat="server" Text="View" Width="80px" ValidationGroup="View1" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>

        <asp:View ID="View2" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   تقرير مبيعات العملاء
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView2_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView2_StartDate" runat="server" ControlToValidate="txtView2_StartDate" ValidationGroup="View2"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView2_StartDate" TargetControlID="rfvView2_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView2_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                     <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView2_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView2_EndDate" runat="server" ControlToValidate="txtView2_EndDate" ValidationGroup="View2"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView2_EndDate" TargetControlID="rfvView2_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView2_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View2" runat="server" Text="View" Width="80px" ValidationGroup="View2" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>

        <asp:View ID="View3" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   تقرير مبيعات حسب المندوب
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">
                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView3_DelegateName" runat="server" Text="Delegate Name :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView3_DelegateName" runat="server" ControlToValidate="ddlView3_DelegateName" ValidationGroup="View3"
                            ErrorMessage ="Delegate Name is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView3_DelegateName" TargetControlID="rfvView3_DelegateName">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView3_DelegateName" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView3_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView3_StartDate" runat="server" ControlToValidate="txtView3_StartDate" ValidationGroup="View3"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView3_StartDate" TargetControlID="rfvView3_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView3_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                     <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView3_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView3_EndDate" runat="server" ControlToValidate="txtView3_EndDate" ValidationGroup="View3"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView3_EndDate" TargetControlID="rfvView3_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView3_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View3" runat="server" Text="View" Width="80px" ValidationGroup="View3" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>

        <asp:View ID="View4" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   تقرير مبيعات حسب المادة للعميل
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">
                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView4_ClientName" runat="server" Text="Client Name :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView4_ClientName" runat="server" ControlToValidate="ddlView4_ClientName" ValidationGroup="View4"
                            ErrorMessage ="Client Name is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView4_ClientName" TargetControlID="rfvView4_ClientName">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView4_ClientName" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                   <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView4_Group" runat="server" Text="Group :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView4_Group" runat="server" ControlToValidate="ddlView4_Group" ValidationGroup="View4"
                            ErrorMessage ="Group is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView4_Group" TargetControlID="rfvView4_Group">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView4_Group" AutoPostBack="true" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView4_Item" runat="server" Text="Item :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView4_Item" runat="server" ControlToValidate="ddlView4_Item" ValidationGroup="View4"
                            ErrorMessage ="Item is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView4_Item" TargetControlID="rfvView4_Item">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView4_Item" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView4_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView4_StartDate" runat="server" ControlToValidate="txtView4_StartDate" ValidationGroup="View4"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView4_StartDate" TargetControlID="rfvView4_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView4_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                     <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView4_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView4_EndDate" runat="server" ControlToValidate="txtView4_EndDate" ValidationGroup="View4"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView4_EndDate" TargetControlID="rfvView4_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView4_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View4" runat="server" Text="View" Width="80px" ValidationGroup="View4" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>

        <asp:View ID="View5" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   تقرير مبيعات حسب المادة للعملاء
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">

                   <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView5_Group" runat="server" Text="Group :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView5_Group" runat="server" ControlToValidate="ddlView5_Group" ValidationGroup="View5"
                            ErrorMessage ="Group is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView5_Group" TargetControlID="rfvView5_Group">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView5_Group" AutoPostBack="true" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView5_Item" runat="server" Text="Item :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView5_Item" runat="server" ControlToValidate="ddlView5_Item" ValidationGroup="View5"
                            ErrorMessage ="Item is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView5_Item" TargetControlID="rfvView5_Group">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView5_Item" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView5_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView5_StartDate" runat="server" ControlToValidate="txtView5_StartDate" ValidationGroup="View5"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView5_StartDate" TargetControlID="rfvView5_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView5_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                     <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView5_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView5_EndDate" runat="server" ControlToValidate="txtView5_EndDate" ValidationGroup="View5"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView5_EndDate" TargetControlID="rfvView5_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView5_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View5" runat="server" Text="View" Width="80px" ValidationGroup="View5" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>

        <asp:View ID="View6" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   تقرير مبيعات المواد حسب المجموعة للعميل
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">
                    <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView6_ClientName" runat="server" Text="Client Name :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView6_ClientName" runat="server" ControlToValidate="ddlView6_ClientName" ValidationGroup="View6"
                            ErrorMessage ="Client Name is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView6_ClientName" TargetControlID="rfvView6_ClientName">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView6_ClientName" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                   <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView6_Group" runat="server" Text="Group :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView6_Group" runat="server" ControlToValidate="ddlView6_Group" ValidationGroup="View6"
                            ErrorMessage ="Group is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView6_Group" TargetControlID="rfvView6_Group">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView6_Group" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView6_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView6_StartDate" runat="server" ControlToValidate="txtView6_StartDate" ValidationGroup="View6"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView6_StartDate" TargetControlID="rfvView6_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView6_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                    <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView6_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView6_EndDate" runat="server" ControlToValidate="txtView6_EndDate" ValidationGroup="View6"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView6_EndDate" TargetControlID="rfvView6_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView6_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View6" runat="server" Text="View" Width="80px" ValidationGroup="View6" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>

        <asp:View ID="View7" runat="server">
                       
             <div class="panel-heading">
                 <h3 class="panel-title" style="text-align:center; font-size:large">
                   تقرير مبيعات المواد حسب المجموعة للعملاء
                 </h3>
              </div>
              <div class="panel-body">
                <div class="Secondery-panel-content">

                   <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView7_Group" runat="server" Text="Group :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView7_Group" runat="server" ControlToValidate="ddlView7_Group" ValidationGroup="View7"
                            ErrorMessage ="Group is required !" Text="*" ForeColor="Red" SetFocusOnError="true" InitialValue="0" >
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView7_Group" TargetControlID="rfvView7_Group">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:DropDownList ID="ddlView7_Group" Width="60%" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView7_StartDate" runat="server" Text="Start Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView7_StartDate" runat="server" ControlToValidate="txtView7_StartDate" ValidationGroup="View7"
                            ErrorMessage ="Start Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView7_StartDate" TargetControlID="rfvView7_StartDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 1%">
                            <asp:TextBox ID="txtView7_StartDate" TextMode="Date" Height="50%" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>
                    <br />
                    <br />
                    <br />
                    <br />
                      <div class="secondary-form-group">
                        <div class="TextDiv">
                            <asp:Label ID="lblView7_EndDate" runat="server" Text="End Date :"></asp:Label>
                           <asp:RequiredFieldValidator ID="rfvView7_EndDate" runat="server" ControlToValidate="txtView7_EndDate" ValidationGroup="View7"
                            ErrorMessage ="End Date is required !" Text="*" ForeColor="Red" SetFocusOnError="true">
                            </asp:RequiredFieldValidator> 
                            <AJAX:ValidatorCalloutExtender runat="server" ID="vceView7_EndDate" TargetControlID="rfvView7_EndDate">
                           </AJAX:ValidatorCalloutExtender> 
                        </div>
                        <div class="InputDiv" style="margin-bottom: 2%">
                            <asp:TextBox ID="txtView7_EndDate" TextMode="Date" Width="60%" runat="server"></asp:TextBox>
                        </div>
                     </div>

                     <div class="secondary-form-group">
                        <div class="TextDiv">

                        </div>
                        <div class="InputDiv" style="margin-left:400px">
                            <asp:Button ID="btn_View7" runat="server" Text="View" Width="80px" ValidationGroup="View7" CssClass="btn btn-primary" />
                        </div>
                    </div>
                 </div>
               </div>

        </asp:View>
      
    </asp:MultiView>

</asp:Content>
