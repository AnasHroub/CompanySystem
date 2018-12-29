using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TRANSACTIONS;
using Web;

public partial class Transactions : Localization
{
    #region [ Properties ]

    public SqlConnection _conConnection;
    private SqlParameter _NAME;

    #endregion

    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        btn_search.Click += new EventHandler(btn_search_Click);

        gvTransactions.RowCommand += new GridViewCommandEventHandler(gvTransactions_RowCommand);

        gvTransactions.DataBound += new EventHandler(gvTransactions_DataBound);

        gvTransactions.RowEditing += new GridViewEditEventHandler(gvTransactions_RowEditing);

        gvTransactions.RowCancelingEdit += new GridViewCancelEditEventHandler(gvTransactions_RowCancelingEdit);

        gvTransactions.RowUpdating += new GridViewUpdateEventHandler(gvTransactions_RowUpdating);

        gvTransactions.RowDataBound += new GridViewRowEventHandler(gvTransactions_RowDataBound);

    }
    #endregion

    #region [ Page_Load ]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PerformSetting();
        }
        if (!IsPostBack)
        {
            if (Session["Lang"].ToString() == "ar")
            {
                div_Search.Style["direction"] = "rtl";
                div_Search.Style["margin-right"] = "2.5%";

                gvTransactions.Style["direction"] = "rtl";
                gvTransactions.Style["float"] = "left";
            }

        }

    }
    #endregion

    #region [ btn_search_Click ]
    private void btn_search_Click(object sender, EventArgs e)
    {
        FillgvTransactions();
    }

    #endregion

    #region [ btnAdd_Click ]
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        TRANSACTIONS_BLL oTransactions = new TRANSACTIONS_BLL();
        TRANSACTIONS_ENTITY oTransactionsEntity = new TRANSACTIONS_ENTITY();

        DropDownList ddlgvDelegates = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvDelegates");
        oTransactionsEntity.Delegate_ID = Convert.ToInt64(ddlgvDelegates.SelectedValue);

        DropDownList ddlgvGroups = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvGroups");
        oTransactionsEntity.Group_ID = Convert.ToInt64(ddlgvGroups.SelectedValue);

        DropDownList ddlgvItems = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvItems");
        oTransactionsEntity.Item_ID = Convert.ToInt64(ddlgvItems.SelectedValue);

        TextBox txtgvLargestUnit = (TextBox)gvTransactions.FooterRow.FindControl("txtgvLargistUnit");
        oTransactionsEntity.Largist_Unit_Quantity = Convert.ToInt64(txtgvLargestUnit.Text);

        TextBox txtgvSmallestUnit = (TextBox)gvTransactions.FooterRow.FindControl("txtgvSmallestUnit");
        oTransactionsEntity.Smallest_Unit_Quantity = Convert.ToInt64(txtgvSmallestUnit.Text);

        oTransactionsEntity.Inserted_Date = DateTime.Now.ToString("MMM dd yyyy hh:mm tt");

        oTransactions.Insert(oTransactionsEntity);

        FillgvTransactions();
    }
    #endregion

    #region [ gvTransactions_DataBound ]
    private void gvTransactions_DataBound(object sender, EventArgs e)
    {
        #region [ FillddlDelegates ]
        //Database Table
        EstablishConnection();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Delegates", _conConnection);
        cmd.CommandType = CommandType.Text;

        SqlDataAdapter daDelegates = new SqlDataAdapter();
        daDelegates.SelectCommand = cmd;

        DataTable dtDelegates = new DataTable();
        daDelegates.Fill(dtDelegates);


        //Find the DropDownList in the Row
        DropDownList ddlgvDelegates = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvDelegates");
        ddlgvDelegates.DataSource = dtDelegates;
        ddlgvDelegates.DataValueField = "ID";
        ddlgvDelegates.DataTextField = "Name";
        ddlgvDelegates.DataBind();

        //Add Default Item in the DropDownList
        ddlgvDelegates.Items.Insert(0, new ListItem("", "0"));
        #endregion

        #region [ FillddlGroups ]
        //Database Table
        EstablishConnection();

        SqlDataAdapter daGroups = new SqlDataAdapter("SELECT * FROM Groups", _conConnection);
        daGroups.SelectCommand.CommandType = CommandType.Text;

        DataTable dtGroups = new DataTable();
        daGroups.Fill(dtGroups);

        //Find the DropDownList in the Row
        DropDownList ddlgvGroups = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvGroups");
        ddlgvGroups.DataSource = dtGroups;
        ddlgvGroups.DataValueField = "ID";
        ddlgvGroups.DataTextField = "Name";
        ddlgvGroups.DataBind();

        //Add Default Item in the DropDownList
        ddlgvGroups.Items.Insert(0, new ListItem("", "0"));
        #endregion       
    }
    #endregion

    #region [ ddlgvGroups_SelectedIndexChanged ]
    protected void ddlgvGroups_SelectedIndexChanged(object sender, EventArgs e)
    {
        #region [ FillddlItems ]
        //Database Table
        EstablishConnection();
        DropDownList ddlgvGroups = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvGroups");

        SqlDataAdapter daItems = new SqlDataAdapter("SELECT * FROM Items WHERE Group_ID = " + ddlgvGroups.SelectedValue, _conConnection);
        daItems.SelectCommand.CommandType = CommandType.Text;

        DataTable dtItem = new DataTable();
        daItems.Fill(dtItem);

        //Find the DropDownList in the Row
        DropDownList ddlgvItems = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvItems");
        ddlgvItems.DataSource = dtItem;
        ddlgvItems.DataValueField = "ID";
        ddlgvItems.DataTextField = "Name";
        ddlgvItems.DataBind();

        //Add Default Item in the DropDownList
        ddlgvItems.Items.Insert(0, new ListItem("", "0"));
        #endregion
    }
    #endregion

    #region [ ddlgvGroups_SelectedIndexChanged1 ]
    protected void ddlgvGroups_SelectedIndexChanged1(object sender, EventArgs e)
    {
        #region [ FillddlItems ]
        //Database Table
        EstablishConnection();
        DropDownList ddlgvGroups = (DropDownList)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("ddlgvGroups");

        SqlDataAdapter daItems = new SqlDataAdapter("SELECT * FROM Items WHERE Group_ID = " + ddlgvGroups.SelectedValue, _conConnection);
        daItems.SelectCommand.CommandType = CommandType.Text;

        DataTable dtItem = new DataTable();
        daItems.Fill(dtItem);

        //Find the DropDownList in the Row
        DropDownList ddlgvItems = (DropDownList)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("ddlgvItems");
        ddlgvItems.DataSource = dtItem;
        ddlgvItems.DataValueField = "ID";
        ddlgvItems.DataTextField = "Name";
        ddlgvItems.DataBind();

        //Add Default Item in the DropDownList
        ddlgvItems.Items.Insert(0, new ListItem("", "0"));
        #endregion
    }
    #endregion

    #region [ gvTransactions_RowCommand ]
    private void gvTransactions_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "img_delete")
        {
            TRANSACTIONS_BLL oTransaction = new TRANSACTIONS_BLL();
            TRANSACTIONS_ENTITY oTransactionEntity = new TRANSACTIONS_ENTITY();

            oTransactionEntity.ID = Convert.ToInt32(e.CommandArgument);
            oTransaction.Delete(oTransactionEntity);

            FillgvTransactions();
        }
    }
    #endregion

    #region [ gvTransactions_RowDataBound ]
    private void gvTransactions_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                #region [ FillddlDelegates ]
                EstablishConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Delegates", _conConnection);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter daDelegates = new SqlDataAdapter();
                daDelegates.SelectCommand = cmd;

                DataSet dsDelegates = new DataSet();
                daDelegates.Fill(dsDelegates);

                //Code for binding dropdown on selected index of edit
                HiddenField hdgvDelegates = (HiddenField)e.Row.FindControl("hdgvDelegates");

                DropDownList ddlgvDelegates = (DropDownList)e.Row.FindControl("ddlgvDelegates");

                if (dsDelegates.Tables[0].Rows.Count != 0)
                {
                    ddlgvDelegates.DataSource = dsDelegates.Tables[0];
                    ddlgvDelegates.DataTextField = "Name";
                    ddlgvDelegates.DataValueField = "Id";
                    ddlgvDelegates.DataBind();
                }

                ddlgvDelegates.Items.Insert(0, new ListItem("", "0"));

                ddlgvDelegates.Items.FindByText(hdgvDelegates.Value).Selected = true;
                #endregion

                #region [ FillddlGroups ]
                //Database Table
                EstablishConnection();

                SqlDataAdapter daGroups = new SqlDataAdapter("SELECT * FROM Groups", _conConnection);
                daGroups.SelectCommand.CommandType = CommandType.Text;

                DataSet dsGroups = new DataSet();
                daGroups.Fill(dsGroups);

                //Find the DropDownList in the Row
                HiddenField hdgvGroups = (HiddenField)e.Row.FindControl("hdgvGroups");

                DropDownList ddlgvGroups = (DropDownList)e.Row.FindControl("ddlgvGroups");

                if (dsGroups.Tables[0].Rows.Count != 0)
                {
                    ddlgvGroups.DataSource = dsGroups;
                    ddlgvGroups.DataValueField = "ID";
                    ddlgvGroups.DataTextField = "Name";
                    ddlgvGroups.DataBind();
                }

                ddlgvGroups.Items.Insert(0, new ListItem("", "0"));

                ddlgvGroups.Items.FindByText(hdgvGroups.Value).Selected = true;

                #endregion

                #region [ FillddlItems ]
                //Database Table
                EstablishConnection();
                SqlDataAdapter daItems = new SqlDataAdapter("SELECT * FROM Items WHERE Group_ID = " + ddlgvGroups.SelectedValue, _conConnection);
                daItems.SelectCommand.CommandType = CommandType.Text;

                DataTable dtItem = new DataTable();
                daItems.Fill(dtItem);

                //Find the DropDownList in the Row
                HiddenField hdgvItems = (HiddenField)e.Row.FindControl("hdgvItems");

                DropDownList ddlgvItems = (DropDownList)e.Row.FindControl("ddlgvItems");
                ddlgvItems.DataSource = dtItem;
                ddlgvItems.DataValueField = "ID";
                ddlgvItems.DataTextField = "Name";
                ddlgvItems.DataBind();

                //Add Default Item in the DropDownList
                ddlgvItems.Items.Insert(0, new ListItem("", "0"));

                ddlgvItems.Items.FindByText(hdgvItems.Value).Selected = true;

                #endregion
            }
        }
    }
    #endregion

    #region [ gvTransactions_RowEditing ]
    private void gvTransactions_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvTransactions.EditIndex = e.NewEditIndex;
        FillgvTransactions();
    }
    #endregion

    #region [ gvTransactions_RowCancelingEdit ]
    private void gvTransactions_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvTransactions.EditIndex = -1;
        FillgvTransactions();
    }
    #endregion

    #region [ gvTransactions_RowUpdating ]
    private void gvTransactions_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TRANSACTIONS_BLL oTransactions = new TRANSACTIONS_BLL();
        TRANSACTIONS_ENTITY oTransactionsEntity = new TRANSACTIONS_ENTITY();

        Label lblgvID = (Label)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("lblgvID");
        oTransactionsEntity.ID = Convert.ToInt32(lblgvID.Text);

        DropDownList ddlgvDelegates = (DropDownList)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("ddlgvDelegates");
        oTransactionsEntity.Delegate_ID = Convert.ToInt64(ddlgvDelegates.SelectedValue);

        DropDownList ddlgvGroups = (DropDownList)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("ddlgvGroups");
        oTransactionsEntity.Group_ID = Convert.ToInt64(ddlgvGroups.SelectedValue);

        DropDownList ddlgvItems = (DropDownList)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("ddlgvItems");
        oTransactionsEntity.Item_ID = Convert.ToInt64(ddlgvItems.SelectedValue);

        TextBox txtgvLargistUnit = (TextBox)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("txtgvLargistUnit");
        oTransactionsEntity.Largist_Unit_Quantity = Convert.ToInt64(txtgvLargistUnit.Text);

        TextBox txtgvSmallestUnit = (TextBox)gvTransactions.Rows[gvTransactions.EditIndex].FindControl("txtgvSmallestUnit");
        oTransactionsEntity.Smallest_Unit_Quantity = Convert.ToInt64(txtgvSmallestUnit.Text);

        oTransactionsEntity.Updated_Date = DateTime.Now.ToString("MMM dd yyyy hh:mm tt");


        oTransactions.Update(oTransactionsEntity);

        Response.Redirect("Transactions.aspx");

    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvTransactions();
    }
    #endregion

    #region [ EstablishConnection ]
    private void EstablishConnection()
    {
        _conConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    }
    #endregion

    #region [ FillgvTransactions ]
    private void FillgvTransactions()
    {
        TRANSACTIONS_BLL oTransaction = new TRANSACTIONS_BLL();

        DataSet dsTransactions = RetrieveTransactions();
        DataTable dtTransactions = dsTransactions.Tables[0];


        if (dtTransactions.Rows.Count == 0)
        {
            FixGridHeader(dtTransactions);
        }
        else
        {
            gvTransactions.DataSource = oTransaction.SearchTransactions(txtSearch.Text);
            gvTransactions.DataBind();
        }
    }
    #endregion

    #region [ FixGridHeader ]
    private void FixGridHeader(DataTable dataSource)
    {
        //add blank row to the the resultset
        dataSource.Rows.Add(dataSource.NewRow());

        gvTransactions.DataSource = dataSource;
        gvTransactions.DataBind();

        //hide empty row
        gvTransactions.Rows[0].Visible = false;
        gvTransactions.Rows[0].Controls.Clear();
    }
    #endregion

    #region [ RetrieveTransactions ]
    private DataSet RetrieveTransactions()
    {

        //fetch the connection string from web.config
        string _conConnectionfetch = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //SQL statement to fetch entries from products
        //string sql = @"Select * From Transactions";

        DataSet dsTransactions = new DataSet();
        //Open SQL Connection
        using (SqlConnection conn = new SqlConnection(_conConnectionfetch))
        {
            conn.Open();
            //Initialize command object
            //using (SqlCommand cmd = new SqlCommand("SEARCH_TRANSACTIONS", conn))
            //{
            SqlCommand _cmdCommand = new SqlCommand();
            SqlDataAdapter _dataAdapter = new SqlDataAdapter();
            _cmdCommand.Connection = conn;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "SEARCH_TRANSACTIONS";


            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.VarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = !string.IsNullOrEmpty(txtSearch.Text.Trim()) ? txtSearch.Text.Trim() : (object)DBNull.Value;

            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(dsTransactions);

        }
        return dsTransactions;
    }
    #endregion
    
    #region [ BeginAddMode ]
    private void BeginAddMode()
    {
        Response.Redirect("Transactions.aspx");

        DropDownList ddlgvDelegates = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvDelegates");

        ddlgvDelegates.SelectedIndex = -1;

        DropDownList ddlgvGroups = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvGroups");

        ddlgvGroups.SelectedIndex = -1;

        DropDownList ddlgvItems = (DropDownList)gvTransactions.FooterRow.FindControl("ddlgvItems");

        ddlgvItems.SelectedIndex = -1;

        TextBox txtgvLargestUnit = (TextBox)gvTransactions.FooterRow.FindControl("txtgvLargistUnit");

        txtgvLargestUnit.Text = "";

        TextBox txtgvSmallestUnit = (TextBox)gvTransactions.FooterRow.FindControl("txtgvSmallestUnit");

        txtgvSmallestUnit.Text = "";
    }



    #endregion

    #endregion
}
