using CLIENTS;
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

public partial class Clients : Localization
{
    #region [ Events ]

    #region [ Properties ]

    private SqlConnection _conConnection;

    #endregion

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        gvClient.PageIndexChanging += new GridViewPageEventHandler(gvClient_PageIndexChanging);

        gvClient.Sorting += new GridViewSortEventHandler(gvClient_Sorting);

        gvClient.RowEditing += new GridViewEditEventHandler(gvClient_RowEditing);

        gvClient.RowCancelingEdit += new GridViewCancelEditEventHandler(gvClient_RowCancelingEdit);

        gvClient.RowUpdating += new GridViewUpdateEventHandler(gvClient_RowUpdating);

        gvClient.RowDeleting += new GridViewDeleteEventHandler(gvClient_RowDeleting);

        gvClient.RowDataBound += new GridViewRowEventHandler(gvClient_RowDataBound);

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

    #region [ gvClient_PageIndexChanging ]
    private void gvClient_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvClient.PageIndex = e.NewPageIndex;
        FillgvClientList();
    }
    #endregion

    #region [ SortDirection ]
    public SortDirection dir
    {
        get
        {
            if (ViewState["dirState"] == null)
            {
                ViewState["dirState"] = SortDirection.Ascending;
            }
            return (SortDirection)ViewState["dirState"];
        }
        set
        {
            ViewState["dirState"] = value;
        }
    }
    #endregion

    #region [ gvClient_Sorting ]
    private void gvClient_Sorting(object sender, GridViewSortEventArgs e)
    {
        string sortingDirection = string.Empty;

        if (dir == SortDirection.Ascending)
        {
            dir = SortDirection.Descending;
            sortingDirection = "Desc";
        }
        else
        {
            dir = SortDirection.Ascending;
            sortingDirection = "Asc";
        }

        DataView sortedView = new DataView(BindGridView());
        sortedView.Sort = e.SortExpression + " " + sortingDirection;

        gvClient.DataSource = sortedView;
        gvClient.DataBind();
    }
    #endregion

    #region [ gvClient_RowEditing ]
    private void gvClient_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvClient.EditIndex = e.NewEditIndex;
        FillgvClientList();
    }
    #endregion

    #region [ gvClient_RowCancelingEdit ]
    private void gvClient_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvClient.EditIndex = -1;
        FillgvClientList();
    }
    #endregion

    #region [ gvClient_RowUpdating ]
    private void gvClient_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        CLIENTS_BLL oClient = new CLIENTS_BLL();
        CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

        Label lblgvID = (Label)gvClient.Rows[gvClient.EditIndex].FindControl("lblgvID");
        oClientEntity.ID = Convert.ToInt32(lblgvID.Text);

        TextBox txtgvName = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvName");
        oClientEntity.NAME = txtgvName.Text;

        TextBox txtgvEmail = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvEmail");
        oClientEntity.EMAIL = txtgvEmail.Text;

        TextBox txtgvPhone1 = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvPhone1");
        oClientEntity.PHONE1 = txtgvPhone1.Text;

        TextBox txtgvPhone2 = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvPhone2");
        oClientEntity.PHONE2 = txtgvPhone2.Text;

        TextBox txtgvAddress = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvAddress");
        oClientEntity.ADDRESS = txtgvAddress.Text;

        DropDownList ddlgvDelegate = (DropDownList)gvClient.Rows[gvClient.EditIndex].FindControl("ddlgvDelegate");
        oClientEntity.DELEGATE_ID = Convert.ToInt64(ddlgvDelegate.SelectedValue);

        TextBox txtgvResponsible_Person = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvResponsible_Person");
        oClientEntity.RESPONSIBLE_PEARSON = txtgvResponsible_Person.Text;

        oClient.Update(oClientEntity);

        Response.Redirect("Clients.aspx");

    }
    #endregion

    #region [ gvClient.RowDeleting ]
    private void gvClient_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        CLIENTS_BLL oClient = new CLIENTS_BLL();
        CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

        oClientEntity.ID = Convert.ToInt32(gvClient.DataKeys[e.RowIndex].Value);
        oClient.Delete(oClientEntity);

        FillgvClientList();    
    }
    #endregion

    #region [ gvClient_RowDataBound ]
    public void gvClient_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        #region [ Rows ]
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
                HiddenField hdgvDelegate = (HiddenField)e.Row.FindControl("hdgvDelegate");

                DropDownList ddlgvDelegate = (DropDownList)e.Row.FindControl("ddlgvDelegate");

                if (dsDelegates.Tables[0].Rows.Count != 0)
                {
                    ddlgvDelegate.DataSource = dsDelegates.Tables[0];
                    ddlgvDelegate.DataTextField = "Name";
                    ddlgvDelegate.DataValueField = "Id";
                    ddlgvDelegate.DataBind();
                }

                ddlgvDelegate.Items.Insert(0, new ListItem("", "0"));

                ddlgvDelegate.Items.FindByText(hdgvDelegate.Value).Selected = true;                

                #endregion               
            }

            ConfirmDelete((GridView)sender, e);
        }
        #endregion       
    }
    #endregion

    #region [ TF_hdr_TextChanged ]
    protected void TF_hdr_TextChanged(object sender, EventArgs e)
    {
        if (sender is TextBox)
        {
            TextBox txtBox = (TextBox)sender;

            if (txtBox.ID == "TF_hdr_ID")
            {
                ViewState["hdr_ID"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Name")
            {
                ViewState["hdr_Name"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Email")
            {
                ViewState["hdr_Email"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Phone1")
            {
                ViewState["hdr_Phone1"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Phone2")
            {
                ViewState["hdr_Phone2"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Address")
            {
                ViewState["hdr_Address"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Delegate")
            {
                ViewState["hdr_Delegate"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Responsible_Person")
            {
                ViewState["hdr_Responsible_Person"] = txtBox.Text;
            }

        }
        FillgvClientList();
    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvClientList();

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {
            gvClient.Style["direction"] = "rtl";
            gvClient.Style["float"] = "left";
        }
        #endregion
    }
    #endregion

    #region [ EstablishConnection ]
    private void EstablishConnection()
    {
        _conConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    }
    #endregion

    #region [ FillgvClientList ]
    private void FillgvClientList()
    {
        CLIENTS_BLL oClient = new CLIENTS_BLL();
        if (ViewState["hdr_ID"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_ID(Convert.ToInt64(ViewState["hdr_ID"]));
            gvClient.DataBind();

            ViewState["hdr_ID"] = null;
        }
        else if (ViewState["hdr_Name"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_Name(ViewState["hdr_Name"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Name"] = null;
        }
        else if (ViewState["hdr_Email"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_Email(ViewState["hdr_Email"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Email"] = null;
        }
        else if (ViewState["hdr_Phone1"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_Phone1(ViewState["hdr_Phone1"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Phone1"] = null;
        }
        else if (ViewState["hdr_Phone2"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_Phone2(ViewState["hdr_Phone2"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Phone2"] = null;
        }
        else if (ViewState["hdr_Address"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_Address(ViewState["hdr_Address"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Address"] = null;
        }
        else if (ViewState["hdr_Delegate"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_Delegate(ViewState["hdr_Delegate"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Delegate"] = null;
        }
        else if (ViewState["hdr_Responsible_Person"] != null)
        {
            gvClient.DataSource = oClient.FilterClients_ResponsiblePerson(ViewState["hdr_Responsible_Person"].ToString());
            gvClient.DataBind();

            ViewState["hdr_Responsible_Person"] = null;
        }
        else
        {
            gvClient.DataSource = oClient.FillClients();
            gvClient.DataBind();
        }

    }
    #endregion

    #region [ BindGridView ]
    private DataTable BindGridView()
    {
        DataTable dtGrid = new DataTable();
        EstablishConnection();
        string strSelect = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID";
        SqlCommand cmd = new SqlCommand(strSelect, _conConnection);
        SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
        dAdapter.Fill(dtGrid);
        return dtGrid;
    }

    #endregion

    #region [ ConfirmDelete ]
    private void ConfirmDelete(GridView sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            foreach (DataControlFieldCell Cell in e.Row.Cells)
            {
                foreach (Control control in Cell.Controls)
                {
                    ImageButton ImgBtn = control as ImageButton;

                    if (ImgBtn != null && ImgBtn.CommandName == "Delete")
                    {
                        if (Session["Lang"].ToString() == "ar")
                        {
                            ImgBtn.OnClientClick = "if (!confirm('هل تريد حقاً حذف هذا السجل ؟')) return;";

                        }
                        else
                        {
                            ImgBtn.OnClientClick = "if (!confirm('Do you want to delete this record ?')) return;";
                        }

                    }
                }
            }
        }
    }
    #endregion

    #endregion
}
