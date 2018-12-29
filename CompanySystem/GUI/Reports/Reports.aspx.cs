using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

public partial class Reports : Localization
{
    #region [ Properties ]

    private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    private SqlConnection _conConnection;
    private SqlCommand _cmdCommand;
    private SqlDataAdapter _dataAdapter;
    private SqlParameter _CLIENT;
    private SqlParameter _DELEGATE;
    private SqlParameter _GROUP;
    private SqlParameter _ITEM;
    private SqlParameter _START_DATE;
    private SqlParameter _END_DATE;

    #endregion

    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        ddlReports.SelectedIndexChanged += new EventHandler(ddlReports_SelectedIndexChanged);

        ddlView4_Group.SelectedIndexChanged += new EventHandler(ddlView4_Group_SelectedIndexChanged);

        ddlView5_Group.SelectedIndexChanged += new EventHandler(ddlView5_Group_SelectedIndexChanged);

        btn_View1.Click += new EventHandler(btn_View1_Click);

        btn_View2.Click += new EventHandler(btn_View2_Click);

        btn_View3.Click += new EventHandler(btn_View3_Click);

        btn_View4.Click += new EventHandler(btn_View4_Click);

        btn_View5.Click += new EventHandler(btn_View5_Click);

        btn_View6.Click += new EventHandler(btn_View6_Click);

        btn_View7.Click += new EventHandler(btn_View7_Click);


    }
    #endregion

    #region [ Page_Load ]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PerformSetting();
        }
    }
    #endregion

    #region [ ddlReports_SelectedIndexChanged ]
    private void ddlReports_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (ddlReports.SelectedValue)
        {
            case "View1":
                mvReports.SetActiveView(View1);
                break;
            case "View2":
                mvReports.SetActiveView(View2);
                break;
            case "View3":
                mvReports.SetActiveView(View3);
                break;
            case "View4":
                mvReports.SetActiveView(View4);
                break;
            case "View5":
                mvReports.SetActiveView(View5);
                break;
            case "View6":
                mvReports.SetActiveView(View6);
                break;
            case "View7":
                mvReports.SetActiveView(View7);
                break;
                //case "View8":
                //    mvReports.SetActiveView(View8);
                //    break;
        }
    }
    #endregion

    #region [ ddlView4_Group_SelectedIndexChanged ]
    private void ddlView4_Group_SelectedIndexChanged(object sender, EventArgs e)
    {
        #region [ FillddlItem ]
        EstablishConnection();

        SqlDataAdapter _DataAdabter = new SqlDataAdapter("SELECT * FROM Items WHERE Group_ID = " + ddlView4_Group.SelectedValue, _conConnection);
        _DataAdabter.SelectCommand.CommandType = CommandType.Text;

        DataTable _DataTable = new DataTable();
        _DataAdabter.Fill(_DataTable);

        _conConnection.Open();

        ddlView4_Item.DataSource = _DataTable;
        ddlView4_Item.DataValueField = "ID";
        ddlView4_Item.DataTextField = "NAME";
        ddlView4_Item.DataBind();
        ddlView4_Item.Items.Insert(0, new ListItem("-- Select Item --", "0"));

        _conConnection.Close();
        #endregion
}
    #endregion

    #region [ ddlView5_Group_SelectedIndexChanged ]
    private void ddlView5_Group_SelectedIndexChanged(object sender, EventArgs e)
    {
        #region [ FillddlItem ]
        EstablishConnection();

        SqlDataAdapter _DataAdabter = new SqlDataAdapter("SELECT * FROM Items WHERE Group_ID = " + ddlView5_Group.SelectedValue, _conConnection);
        _DataAdabter.SelectCommand.CommandType = CommandType.Text;

        DataTable _DataTable = new DataTable();
        _DataAdabter.Fill(_DataTable);

        _conConnection.Open();

        ddlView5_Item.DataSource = _DataTable;
        ddlView5_Item.DataValueField = "ID";
        ddlView5_Item.DataTextField = "NAME";
        ddlView5_Item.DataBind();
        ddlView5_Item.Items.Insert(0, new ListItem("-- Select Item --", "0"));

        _conConnection.Close();

        #endregion
    }
   #endregion

    #region [ btn_View1_Click ]
    private void btn_View1_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\Specific_Client_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_SPECIFIC_CLIENT_SALES";

        _CLIENT = _cmdCommand.Parameters.Add("P_Client", SqlDbType.Int);
        _CLIENT.Direction = ParameterDirection.Input;
        _CLIENT.Value = ddlView1_ClientName.SelectedValue;

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView1_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView1_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير مبيعات عميل");
    }
    #endregion

    #region [ btn_View2_Click ]
    private void btn_View2_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\All_Client_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_ALL_CLIENT_SALES";

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView2_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView2_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير مبيعات العملاء");
    }
    #endregion

    #region [ btn_View3_Click ]
    private void btn_View3_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\Specific_Delegate_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_SPECIFIC_DELEGATE_SALES";

        _DELEGATE = _cmdCommand.Parameters.Add("P_Delegate", SqlDbType.Int);
        _DELEGATE.Direction = ParameterDirection.Input;
        _DELEGATE.Value = ddlView3_DelegateName.SelectedValue;

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView3_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView3_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير مبيعات مندوب");
    }
    #endregion

    #region [ btn_View4_Click ]
    private void btn_View4_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\Specific_Client_Item_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_SPECIFIC_CLIENT_ITEM_SALES";

        _CLIENT = _cmdCommand.Parameters.Add("P_Client", SqlDbType.Int);
        _CLIENT.Direction = ParameterDirection.Input;
        _CLIENT.Value = ddlView4_ClientName.SelectedValue;

        _GROUP = _cmdCommand.Parameters.Add("P_Group", SqlDbType.Int);
        _GROUP.Direction = ParameterDirection.Input;
        _GROUP.Value = ddlView4_Group.SelectedValue;

        _ITEM = _cmdCommand.Parameters.Add("P_Item", SqlDbType.Int);
        _ITEM.Direction = ParameterDirection.Input;
        _ITEM.Value = ddlView4_Item.SelectedValue;

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView4_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView4_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير مبيعات حسب المادة للعميل");
    }
    #endregion

    #region [ btn_View5_Click ]
    private void btn_View5_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\All_Client_Item_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_ALL_CLIENT_ITEM_SALES";

        _GROUP = _cmdCommand.Parameters.Add("P_Group", SqlDbType.Int);
        _GROUP.Direction = ParameterDirection.Input;
        _GROUP.Value = ddlView5_Group.SelectedValue;

        _ITEM = _cmdCommand.Parameters.Add("P_Item", SqlDbType.Int);
        _ITEM.Direction = ParameterDirection.Input;
        _ITEM.Value = ddlView5_Item.SelectedValue;

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView5_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView5_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير المبيعات حسب المادة للعملاء");
    }
    #endregion

    #region [ btn_View6_Click ]
    private void btn_View6_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\Specific_Client_Group_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_SPECIFIC_CLIENT_GROUP_SALES";

        _CLIENT = _cmdCommand.Parameters.Add("P_Client", SqlDbType.Int);
        _CLIENT.Direction = ParameterDirection.Input;
        _CLIENT.Value = ddlView6_ClientName.SelectedValue;

        _GROUP = _cmdCommand.Parameters.Add("P_Group", SqlDbType.Int);
        _GROUP.Direction = ParameterDirection.Input;
        _GROUP.Value = ddlView6_Group.SelectedValue;

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView6_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView6_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير المبيعات حسب المجموعة للعميل");
    }
    #endregion

    #region [ btn_View7_Click ]
    private void btn_View7_Click(object sender, EventArgs e)
    {
        ReportDocument oReportDocument = new ReportDocument();
        oReportDocument.Load(@"E:\العمل\Projects\Projects\CompanySystem\CompanySystem\Reports\All_Client_Group_Sales.rpt");

        DataSet _DataSet = new DataSet();
        _conConnection = new SqlConnection();
        _cmdCommand = new SqlCommand();
        _dataAdapter = new SqlDataAdapter();
        _conConnection.ConnectionString = _ConnectionString;
        _cmdCommand.Connection = _conConnection;
        _cmdCommand.CommandType = CommandType.StoredProcedure;
        _cmdCommand.CommandText = "REPORT_ALL_CLIENT_GROUP_SALES";


        _GROUP = _cmdCommand.Parameters.Add("P_Group", SqlDbType.Int);
        _GROUP.Direction = ParameterDirection.Input;
        _GROUP.Value = ddlView7_Group.SelectedValue;

        _START_DATE = _cmdCommand.Parameters.Add("P_Start_Date", SqlDbType.Date);
        _START_DATE.Direction = ParameterDirection.Input;
        _START_DATE.Value = txtView7_StartDate.Text;

        _END_DATE = _cmdCommand.Parameters.Add("P_End_Date", SqlDbType.Date);
        _END_DATE.Direction = ParameterDirection.Input;
        _END_DATE.Value = txtView7_EndDate.Text;

        _conConnection.Open();
        _dataAdapter.SelectCommand = _cmdCommand;
        _dataAdapter.Fill(_DataSet);
        _conConnection.Close();

        oReportDocument.SetDataSource(_DataSet.Tables[0]);

        oReportDocument.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, false, "تقرير المبيعات حسب المجموعة للعملاء");
    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillddlClient();

        FillddlDelegate();

        FillddlGroup();

    }
    #endregion

    #region [ EstablishConnection ]
    private void EstablishConnection()
    {
        _conConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    }
    #endregion

    #region [ FillddlClient ]
    public void FillddlClient()
    {
        EstablishConnection();

        SqlDataAdapter _DataAdabter = new SqlDataAdapter("SELECT * FROM Clients", _conConnection);
        _DataAdabter.SelectCommand.CommandType = CommandType.Text;

        DataTable _DataTable = new DataTable();
        _DataAdabter.Fill(_DataTable);

        _conConnection.Open();

        ddlView1_ClientName.DataSource = _DataTable;
        ddlView1_ClientName.DataValueField = "ID";
        ddlView1_ClientName.DataTextField = "NAME";
        ddlView1_ClientName.DataBind();
        ddlView1_ClientName.Items.Insert(0, new ListItem("-- Select Client --", "0"));

        ddlView4_ClientName.DataSource = _DataTable;
        ddlView4_ClientName.DataValueField = "ID";
        ddlView4_ClientName.DataTextField = "NAME";
        ddlView4_ClientName.DataBind();
        ddlView4_ClientName.Items.Insert(0, new ListItem("-- Select Client --", "0"));

        ddlView6_ClientName.DataSource = _DataTable;
        ddlView6_ClientName.DataValueField = "ID";
        ddlView6_ClientName.DataTextField = "NAME";
        ddlView6_ClientName.DataBind();
        ddlView6_ClientName.Items.Insert(0, new ListItem("-- Select Client --", "0"));

        _conConnection.Close();
    }
    #endregion

    #region [ FillddlDelegate ]
    private void FillddlDelegate()
    {
        EstablishConnection();

        SqlDataAdapter _DataAdabter = new SqlDataAdapter("SELECT * FROM Delegates", _conConnection);
        _DataAdabter.SelectCommand.CommandType = CommandType.Text;

        DataTable _DataTable = new DataTable();
        _DataAdabter.Fill(_DataTable);

        _conConnection.Open();

        ddlView3_DelegateName.DataSource = _DataTable;
        ddlView3_DelegateName.DataValueField = "ID";
        ddlView3_DelegateName.DataTextField = "NAME";
        ddlView3_DelegateName.DataBind();
        ddlView3_DelegateName.Items.Insert(0, new ListItem("-- Select Delegate --", "0"));
        _conConnection.Close();
    }
    #endregion

    #region [ FillddlGroup ]
    private void FillddlGroup()
    {
        EstablishConnection();

        SqlDataAdapter _DataAdabter = new SqlDataAdapter("SELECT * FROM Groups", _conConnection);
        _DataAdabter.SelectCommand.CommandType = CommandType.Text;

        DataTable _DataTable = new DataTable();
        _DataAdabter.Fill(_DataTable);

        _conConnection.Open();

        ddlView4_Group.DataSource = _DataTable;
        ddlView4_Group.DataValueField = "ID";
        ddlView4_Group.DataTextField = "NAME";
        ddlView4_Group.DataBind();
        ddlView4_Group.Items.Insert(0, new ListItem("-- Select Group --", "0"));

        ddlView5_Group.DataSource = _DataTable;
        ddlView5_Group.DataValueField = "ID";
        ddlView5_Group.DataTextField = "NAME";
        ddlView5_Group.DataBind();
        ddlView5_Group.Items.Insert(0, new ListItem("-- Select Group --", "0"));

        ddlView6_Group.DataSource = _DataTable;
        ddlView6_Group.DataValueField = "ID";
        ddlView6_Group.DataTextField = "NAME";
        ddlView6_Group.DataBind();
        ddlView6_Group.Items.Insert(0, new ListItem("-- Select Group --", "0"));

        ddlView7_Group.DataSource = _DataTable;
        ddlView7_Group.DataValueField = "ID";
        ddlView7_Group.DataTextField = "NAME";
        ddlView7_Group.DataBind();
        ddlView7_Group.Items.Insert(0, new ListItem("-- Select Group --", "0"));

        _conConnection.Close();
    }
    #endregion

    #endregion
}
