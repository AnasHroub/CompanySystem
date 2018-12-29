using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using DELEGATES;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Delegates : Localization
{

    #region [ Properties ]

      public SqlConnection _conConnection;

    #endregion

    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {

        gvDelegate.PageIndexChanging += new GridViewPageEventHandler(gvDelegate_PageIndexChanging);

        gvDelegate.Sorting += new GridViewSortEventHandler(gvDelegate_Sorting);

        gvDelegate.RowEditing += new GridViewEditEventHandler(gvDelegate_RowEditing);

        gvDelegate.RowCancelingEdit += new GridViewCancelEditEventHandler(gvDelegate_RowCancelingEdit);

        gvDelegate.RowUpdating += new GridViewUpdateEventHandler(gvDelegate_RowUpdating);

        gvDelegate.RowDeleting += new GridViewDeleteEventHandler(gvDelegate_RowDeleting);

        gvDelegate.RowDataBound += new GridViewRowEventHandler(gvDelegate_RowDataBound);
    }
    #endregion
      
    #region [ Page_Load ]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PerformSetting(sender, e);
        }
    }
    #endregion      
      
    #region [ gvDelegate_PageIndexChanging ]
    private void gvDelegate_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDelegate.PageIndex = e.NewPageIndex;
        FillgvDelegate(sender, e);
    }
    #endregion

    #region [ gvDelegate_Sorting ]
    private void gvDelegate_Sorting(object sender, GridViewSortEventArgs e)
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

        gvDelegate.DataSource = sortedView;
        gvDelegate.DataBind();
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
               
    #region [ gvDelegate_RowEditing ]
    private void gvDelegate_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDelegate.EditIndex = e.NewEditIndex;
        FillgvDelegate(sender, e);
    }
    #endregion

    #region [ gvDelegate_RowCancelingEdit ]
    private void gvDelegate_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDelegate.EditIndex = -1;
        FillgvDelegate(sender, e);
    }
    #endregion

    #region [ gvDelegate_RowUpdating ]
    private void gvDelegate_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DELEGATES_BLL oDelegate = new DELEGATES_BLL();
        DELEGATES_ENTITY oDelegateEntity = new DELEGATES_ENTITY();

        Label lblgvID = (Label)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("lblgvID");   
        oDelegateEntity.ID = Convert.ToInt32(lblgvID.Text);

        TextBox txtgvName = (TextBox)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("txtgvName");
        oDelegateEntity.NAME = txtgvName.Text;

        DropDownList ddlgvGender = (DropDownList)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("ddlgvGender");
        oDelegateEntity.GENDER_ID = Convert.ToInt64(ddlgvGender.SelectedValue);


        DropDownList ddlgvMartialStatus = (DropDownList)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("ddlgvMartialStatus");
        oDelegateEntity.MARTIAL_STATUS_ID = Convert.ToInt64(ddlgvMartialStatus.SelectedValue);

        TextBox txtgvBirthDate = (TextBox)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("txtgvBirthDate");
        oDelegateEntity.BIRTH_DATE = txtgvBirthDate.Text;

        TextBox txtgvPhone = (TextBox)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("txtgvPhone");
        oDelegateEntity.PHONE_NO = txtgvPhone.Text;

        TextBox txtgvAddress = (TextBox)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("txtgvAddress");
        oDelegateEntity.ADDRESS = txtgvAddress.Text;

        TextBox txtgvEmail = (TextBox)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("txtgvEmail");
        oDelegateEntity.EMAIL = txtgvEmail.Text;

        TextBox txtgvPassword = (TextBox)gvDelegate.Rows[gvDelegate.EditIndex].FindControl("txtgvPassword");
        oDelegateEntity.PASSWORD = txtgvPassword.Text;

        oDelegate.Update(oDelegateEntity);

        Response.Redirect("Delegates.aspx");

    }
    #endregion

    #region [ gvDelegate.RowDeleting ]
    private void gvDelegate_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DELEGATES_BLL oDelegates = new DELEGATES_BLL();
        DELEGATES_ENTITY oDelegatesEntity = new DELEGATES_ENTITY();

        oDelegatesEntity.ID = Convert.ToInt32(gvDelegate.DataKeys[e.RowIndex].Value);
        oDelegates.Delete(oDelegatesEntity);

        FillgvDelegate(sender, e);
    }
    #endregion

    #region [ gvDelegate_RowDataBound ]
    public void gvDelegate_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        #region [ Rows ]
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                #region [ FillddlGender ]
                EstablishConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Gender" , _conConnection);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter daGender = new SqlDataAdapter();
                daGender.SelectCommand = cmd;

                DataSet dsGender = new DataSet();
                daGender.Fill(dsGender);

                //Code for binding dropdown on selected index of edit
                HiddenField hdgvGender = (HiddenField)e.Row.FindControl("hdgvGender");

                DropDownList ddlgvGender = (DropDownList)e.Row.FindControl("ddlgvGender");

                if (dsGender.Tables[0].Rows.Count != 0)
                {
                    ddlgvGender.DataSource = dsGender.Tables[0];
                    ddlgvGender.DataTextField = "Name";
                    ddlgvGender.DataValueField = "Id";
                    ddlgvGender.DataBind();
                }

                DropDownList TF_hdr_Gender = (DropDownList)e.Row.FindControl("TF_hdr_Gender");

                ddlgvGender.Items.Insert(0, new ListItem("", "0"));

                ddlgvGender.Items.FindByText(hdgvGender.Value).Selected = true;


                #region Translation
                if (Session["Lang"].ToString() == "ar")
                      {
                          ddlgvGender.Items[1].Text = "ذكر";
                          ddlgvGender.Items[2].Text = "أنثى";

                      }
                   #endregion

                #endregion

                #region [ FillddlMartialStatus ]
                EstablishConnection();

                SqlCommand cmdm = new SqlCommand("SELECT * FROM Martial_Status", _conConnection);
                cmdm.CommandType = CommandType.Text;

                SqlDataAdapter daMartialStatus = new SqlDataAdapter();
                daMartialStatus.SelectCommand = cmdm;

                DataSet dsMartialStatus = new DataSet();
                daMartialStatus.Fill(dsMartialStatus);

                //Code for binding dropdown on selected index of edit
                HiddenField hdgvMartialStatus = (HiddenField)e.Row.FindControl("hdgvMartialStatus");

                DropDownList ddlgvMartialStatus = (DropDownList)e.Row.FindControl("ddlgvMartialStatus");

                if (dsMartialStatus.Tables[0].Rows.Count != 0)
                {
                    ddlgvMartialStatus.DataSource = dsMartialStatus.Tables[0];
                    ddlgvMartialStatus.DataTextField = "Name";
                    ddlgvMartialStatus.DataValueField = "Id";
                    ddlgvMartialStatus.DataBind();
                }

                ddlgvMartialStatus.Items.Insert(0, new ListItem("", "0"));

                ddlgvMartialStatus.Items.FindByText(hdgvMartialStatus.Value).Selected = true;

                #region Translation
                    if (Session["Lang"].ToString() == "ar")
                    {
                    ddlgvMartialStatus.Items[1].Text = "أعزب";
                    ddlgvMartialStatus.Items[2].Text = "متزوج";
                    ddlgvMartialStatus.Items[3].Text = "مطلق";
                    ddlgvMartialStatus.Items[4].Text = "أرمل";

                    }
               #endregion

            #endregion
            }

            #region Translation
            //if (!Page.IsPostBack)
            //{
            if ((e.Row.RowState & DataControlRowState.Edit) == 0)
            { 
                if (Session["Lang"].ToString() == "ar")
                {
                    #region Translation_Gender
                    Label lblgvGender = e.Row.FindControl("lblgvGender") as Label;

                    if (lblgvGender.Text == "Male")
                    {
                        lblgvGender.Text = "ذكر";
                    }
                    else if (lblgvGender.Text == "Female")
                    {
                        lblgvGender.Text = "أنثى";
                    }
                    #endregion

                    #region Translation_Martial_Status
                    Label lblgvMartialStatus = e.Row.FindControl("lblgvMartialStatus") as Label;

                    if (lblgvMartialStatus.Text == "Single")
                    {
                        lblgvMartialStatus.Text = "أعزب";
                    }
                    else if (lblgvMartialStatus.Text == "Married")
                    {
                        lblgvMartialStatus.Text = "متزوج";
                    }
                    else if (lblgvMartialStatus.Text == "Divorced ")
                    {
                        lblgvMartialStatus.Text = "مطلق";
                    }
                    else if (lblgvMartialStatus.Text == "Widowed")
                    {
                        lblgvMartialStatus.Text = "أرمل";
                    }
                    #endregion
                }
            }
            //}
            #endregion

            ConfirmDelete((GridView)sender, e);

        }
        #endregion

        #region [ Header ]
        if (e.Row.RowType == DataControlRowType.Header)
        {
            #region [ FillddlGender ]
            EstablishConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Gender", _conConnection);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter daGender = new SqlDataAdapter();
            daGender.SelectCommand = cmd;

            DataSet dsGender = new DataSet();
            daGender.Fill(dsGender);

            DropDownList ddlgvGender = (DropDownList)e.Row.FindControl("ddlgvGender");


            DropDownList TF_hdr_Gender = (DropDownList)e.Row.FindControl("TF_hdr_Gender");

            if (dsGender.Tables[0].Rows.Count != 0)
            {
                TF_hdr_Gender.DataSource = dsGender.Tables[0];
                TF_hdr_Gender.DataTextField = "Name";
                TF_hdr_Gender.DataValueField = "Id";
                TF_hdr_Gender.DataBind();
            }


            TF_hdr_Gender.Items.Insert(0, new ListItem("", "0"));

            #region Translation
            if (Session["Lang"].ToString() == "ar")
            {
                TF_hdr_Gender.Items[1].Text = "ذكر";
                TF_hdr_Gender.Items[2].Text = "أنثى";
            }
            #endregion

            #endregion

            #region [ FillddlMartialStatus ]
            EstablishConnection();

            SqlCommand cmdm = new SqlCommand("SELECT * FROM Martial_Status", _conConnection);
            cmdm.CommandType = CommandType.Text;

            SqlDataAdapter daMartialStatus = new SqlDataAdapter();
            daMartialStatus.SelectCommand = cmdm;

            DataSet dsMartialStatus = new DataSet();
            daMartialStatus.Fill(dsMartialStatus);

            DropDownList TF_hdr_MartialStatus = (DropDownList)e.Row.FindControl("TF_hdr_MartialStatus");

            if (dsMartialStatus.Tables[0].Rows.Count != 0)
            {
                TF_hdr_MartialStatus.DataSource = dsMartialStatus.Tables[0];
                TF_hdr_MartialStatus.DataTextField = "Name";
                TF_hdr_MartialStatus.DataValueField = "Id";
                TF_hdr_MartialStatus.DataBind();
            }

            TF_hdr_MartialStatus.Items.Insert(0, new ListItem("", "0"));

            #region Translation
            if (Session["Lang"].ToString() == "ar")
            {
                TF_hdr_MartialStatus.Items[1].Text = "أعزب";
                TF_hdr_MartialStatus.Items[2].Text = "متزوج";
                TF_hdr_MartialStatus.Items[3].Text = "مطلق";
                TF_hdr_MartialStatus.Items[4].Text = "أرمل";

            }
            #endregion

            #endregion
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
            else if (txtBox.ID == "TF_hdr_BirthDate")
            {
                ViewState["hdr_BirthDate"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Phone")
            {
                ViewState["hdr_Phone"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Address")
            {
                ViewState["hdr_Address"] = txtBox.Text;
            }
            else if (txtBox.ID == "TF_hdr_Email")
            {
                ViewState["hdr_Email"] = txtBox.Text;
            }
        }
        else if (sender is DropDownList)
        {
            DropDownList ddl = (DropDownList)sender;

            if (ddl.ID == "TF_hdr_Gender")
            {
                ViewState["hdr_Gender"] = ddl.SelectedItem.Value;
            }
            if (ddl.ID == "TF_hdr_MartialStatus")
            {
                ViewState["hdr_MartialStatus"] = ddl.SelectedItem.Value;
            }
        }

        FillgvDelegate(sender, e);
    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting(object sender, EventArgs e)
       {
          FillgvDelegate(sender, e);
          
          #region Translation
        if (Session["Lang"].ToString() == "ar")
              {
              
                  gvDelegate.Style["direction"] = "rtl";
                  gvDelegate.Style["float"] = "left";
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

    #region [ FillgvDelegate ]
    private void FillgvDelegate(object sender, EventArgs e)
    {
        DELEGATES_BLL oDelegate = new DELEGATES_BLL();
        if (ViewState["hdr_ID"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_ID(Convert.ToInt64(ViewState["hdr_ID"]));
            gvDelegate.DataBind();

                ViewState["hdr_ID"] = null;
        }
        else if (ViewState["hdr_Name"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_Name(ViewState["hdr_Name"].ToString());
            gvDelegate.DataBind();

            ViewState["hdr_Name"] = null;
        }

        else if (ViewState["hdr_Gender"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_Gender(Convert.ToInt64(ViewState["hdr_Gender"]));
            gvDelegate.DataBind();

            ViewState["hdr_Gender"] = null;
        }
        else if (ViewState["hdr_MartialStatus"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_Martial_Status(Convert.ToInt64(ViewState["hdr_MartialStatus"]));
            gvDelegate.DataBind();

            ViewState["hdr_MartialStatus"] = null;
        }
        else if (ViewState["hdr_BirthDate"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_BirthDate(ViewState["hdr_BirthDate"].ToString());
            gvDelegate.DataBind();

            ViewState["hdr_BirthDate"] = null;
        }
        else if (ViewState["hdr_Phone"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_Phone(ViewState["hdr_Phone"].ToString());
            gvDelegate.DataBind();

            ViewState["hdr_Phone"] = null;
        }
        else if (ViewState["hdr_Address"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_Address(ViewState["hdr_Address"].ToString());
            gvDelegate.DataBind();

            ViewState["hdr_Address"] = null;
        }
        else if (ViewState["hdr_Email"] != null)
        {
            gvDelegate.DataSource = oDelegate.FilterDelegates_Email(ViewState["hdr_Email"].ToString());
            gvDelegate.DataBind();

            ViewState["hdr_Email"] = null;
        }
        else
        {
            gvDelegate.DataSource = oDelegate.FillDelegates();
            gvDelegate.DataBind();
        }
    }
    #endregion

    #region [ BindGridView ]
        private DataTable BindGridView()
    {
        DataTable dtGrid = new DataTable();
        EstablishConnection();
        string strSelect = "Select Delegates.ID, Delegates.Name, Gender.Name 'Gender', Martial_Status.Name 'Martial_Status', Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID";
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

