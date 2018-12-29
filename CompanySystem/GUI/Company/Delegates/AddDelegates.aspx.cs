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

public partial class AddDelegates : Localization
{

    #region [ Properties ]

    public SqlConnection _conConnection;

    #endregion

    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        btn_Save.Click += new EventHandler(btn_Save_Click);
        btn_Cancel.Click += new EventHandler(btn_Cancel_Click);
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

    #region [ btn_Save_Click ]
    private void btn_Save_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            DELEGATES_BLL oDelegate = new DELEGATES_BLL();
            DELEGATES_ENTITY oDelegateEntity = new DELEGATES_ENTITY();

            oDelegateEntity.NAME = txtName.Text;

            oDelegateEntity.BIRTH_DATE = txtBirthDate.Text;

            oDelegateEntity.GENDER_ID = Convert.ToInt64(ddlgender.SelectedValue);

            oDelegateEntity.MARTIAL_STATUS_ID = Convert.ToInt64(ddlMaritalStatus.SelectedValue);

            oDelegateEntity.PHONE_NO = txtPhone.Text;

            oDelegateEntity.ADDRESS = txtAddress.Text;

            oDelegateEntity.EMAIL = txtEmail.Text;

            oDelegateEntity.PASSWORD = txtPassword.Text;

            oDelegate.Insert(oDelegateEntity);

            BeginAddMode();
        }
        else
        {
            DELEGATES_BLL oDelegate = new DELEGATES_BLL();
            DELEGATES_ENTITY oDelegateEntity = new DELEGATES_ENTITY();

            oDelegateEntity.ID = Convert.ToInt32(Request.QueryString["ID"]);

            oDelegateEntity.NAME = txtName.Text;

            oDelegateEntity.BIRTH_DATE = txtBirthDate.Text;

            oDelegateEntity.GENDER_ID = Convert.ToInt64(ddlgender.SelectedValue);

            oDelegateEntity.MARTIAL_STATUS_ID = Convert.ToInt64(ddlMaritalStatus.SelectedValue);

            oDelegateEntity.PHONE_NO = txtPhone.Text;

            oDelegateEntity.ADDRESS = txtAddress.Text;

            oDelegateEntity.EMAIL = txtEmail.Text;

            oDelegateEntity.PASSWORD = txtPassword.Text;

            oDelegate.Update(oDelegateEntity);

            BeginAddMode();
        }
    }
    #endregion

    #region [ btn_Cancel_Click ]
    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            BeginAddMode();

        }
    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        Fillddl();

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {

            Controls.Style["direction"] = "rtl";
            Controls.Style["display"] = "inline-block";
            Controls.Style["margin-left"] = "45%";

            div_Name.Style["direction"] = "rtl";
            div_Name_secondary.Style["direction"] = "rtl";

            div_BirthDate.Style["direction"] = "rtl";
            div_BirthDate_secondary.Style["direction"] = "rtl";

            div_Gender.Style["direction"] = "rtl";
            div_Gender_secondary.Style["direction"] = "rtl";

            div_MaritalStatus.Style["direction"] = "rtl";
            div_MaritalStatus_secondary.Style["direction"] = "rtl";

            div_Phone.Style["direction"] = "rtl";
            div_Phone_secondary.Style["direction"] = "rtl";

            div_Address.Style["direction"] = "rtl";
            div_Address_secondary.Style["direction"] = "rtl";

            div_Email.Style["direction"] = "rtl";
            div_Email_secondary.Style["direction"] = "rtl";

            div_Password.Style["direction"] = "rtl";
            div_Password_secondary.Style["direction"] = "rtl";

            div_Password.Style["direction"] = "rtl";
            div_Password_secondary.Style["direction"] = "rtl";
        }
        else
        {
            Controls.Style["margin-left"] = "15%";

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

    #region [ BeginAddMode ]
    private void BeginAddMode()
    {
        Response.Redirect("Delegates.aspx");

        txtName.Text                     = "";
        txtBirthDate.Text                = "";
        ddlgender.SelectedIndex          = -1;
        ddlMaritalStatus.SelectedIndex   = -1;
        txtPhone.Text                    = "";
        txtAddress.Text                  = "";
        txtEmail.Text                    = "";
        txtPassword.Text                 = "";
    }
    #endregion

    #region [ Fillddl ]
    private void Fillddl()
    {
        #region [ FillddlGender ]
        //Database Table
        EstablishConnection();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Gender", _conConnection);
        cmd.CommandType = CommandType.Text;

        SqlDataAdapter daGender = new SqlDataAdapter();
        daGender.SelectCommand = cmd;

        DataTable dtGender = new DataTable();
        daGender.Fill(dtGender);


        //Find the DropDownList in the Row
        ddlgender.DataSource = dtGender;
        ddlgender.DataValueField = "ID";
        ddlgender.DataTextField = "Name";
        ddlgender.DataBind();

        //Add Default Item in the DropDownList
        ddlgender.Items.Insert(0, new ListItem("", "0"));

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {
            ddlgender.Items[1].Text = "ذكر";
            ddlgender.Items[2].Text = "أنثى";
        }
        #endregion
        #endregion

        #region [ FillddlMartialStatus ]

        //Database Table
        EstablishConnection();

        SqlCommand cmdm = new SqlCommand("SELECT * FROM Martial_Status", _conConnection);
        cmdm.CommandType = CommandType.Text;

        SqlDataAdapter daMartialStatus = new SqlDataAdapter();
        daMartialStatus.SelectCommand = cmdm;

        DataTable dtMartialStatus = new DataTable();
        daMartialStatus.Fill(dtMartialStatus);

        //Find the DropDownList in the Row
        ddlMaritalStatus.DataSource = dtMartialStatus;
        ddlMaritalStatus.DataValueField = "ID";
        ddlMaritalStatus.DataTextField = "Name";
        ddlMaritalStatus.DataBind();

        //Add Default Item in the DropDownList
        ddlMaritalStatus.Items.Insert(0, new ListItem("", "0"));

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {
            ddlMaritalStatus.Items[1].Text = "أعزب";
            ddlMaritalStatus.Items[2].Text = "متزوج";
            ddlMaritalStatus.Items[3].Text = "مطلق";
            ddlMaritalStatus.Items[4].Text = "أرمل";
        }
        #endregion

        #endregion

    }
    #endregion

    #endregion

}

