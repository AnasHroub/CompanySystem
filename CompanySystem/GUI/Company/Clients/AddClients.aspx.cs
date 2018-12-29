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

public partial class AddClients : Localization
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
            CLIENTS_BLL oClient = new CLIENTS_BLL();
            CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

            oClientEntity.NAME = txtName.Text;

            oClientEntity.EMAIL = txtEmail.Text;

            oClientEntity.PHONE1 = txtPhone1.Text;

            oClientEntity.PHONE2 = txtPhone2.Text;

            oClientEntity.ADDRESS = txtAddress.Text;

            oClientEntity.DELEGATE_ID = Convert.ToInt64(ddlDelegates.SelectedValue);

            oClientEntity.RESPONSIBLE_PEARSON = txtResponsiblePerson.Text;

            oClient.Insert(oClientEntity);

            BeginAddMode();
        }
        else
        {
            CLIENTS_BLL oClient = new CLIENTS_BLL();
            CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

            oClientEntity.ID = Convert.ToInt32(Request.QueryString["ID"]);

            oClientEntity.NAME = txtName.Text;

            oClientEntity.EMAIL = txtEmail.Text;

            oClientEntity.PHONE1 = txtPhone1.Text;

            oClientEntity.PHONE2 = txtPhone2.Text;

            oClientEntity.ADDRESS = txtAddress.Text;

            oClientEntity.DELEGATE_ID = Convert.ToInt64(ddlDelegates.SelectedValue);

            oClientEntity.RESPONSIBLE_PEARSON = txtResponsiblePerson.Text;

            oClient.Update(oClientEntity);

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
        FillddlDelegates();

        #region Translation
          if (Session["Lang"].ToString() == "ar")
          {        
              Controls.Style["direction"] = "rtl";
              Controls.Style["display"] = "inline-block";
              Controls.Style["margin-left"] = "45%";

            Name_div.Style["direction"] = "rtl";
              Name_Secondary.Style["display"] = "inline-flex";
              Name_Secondary.Style["direction"] = "rtl";
          
              Email_div.Style["direction"] = "rtl";
              Email_Secondary.Style["display"] = "inline-flex";
              Email_Secondary.Style["direction"] = "rtl";
          
              Phone1_div.Style["direction"] = "rtl";
              Phone1_Secondary.Style["display"] = "inline-flex";
              Phone1_Secondary.Style["direction"] = "rtl";
          
              Phone2_div.Style["direction"] = "rtl";
              Phone2_Secondary.Style["display"] = "inline-flex";
              Phone2_Secondary.Style["direction"] = "rtl";
          
              Address_div.Style["direction"] = "rtl";
              Address_Secondary.Style["display"] = "inline-flex";
              Address_Secondary.Style["direction"] = "rtl";
          
              Delegates_div.Style["direction"] = "rtl";
              Delegates_Secondary.Style["display"] = "inline-flex";
              Delegates_Secondary.Style["direction"] = "rtl";
          
              ResponsiblePerson_div.Style["direction"] = "rtl";
              ResponsiblePerson_secondary.Style["display"] = "inline-flex";
              ResponsiblePerson_secondary.Style["direction"] = "rtl";
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

    #region [ FillddlDelegates ]
    private void FillddlDelegates()
    {
        EstablishConnection();

        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Delegates", _conConnection);
        da.SelectCommand.CommandType = CommandType.Text;

        DataSet ds = new DataSet();
        da.Fill(ds);

        _conConnection.Open();
        ddlDelegates.DataSource = ds;
        ddlDelegates.DataValueField = "ID";
        ddlDelegates.DataTextField = "Name";
        ddlDelegates.DataBind();
        ddlDelegates.Items.Insert(0, new ListItem("", "0"));
        _conConnection.Close();
    }
    #endregion

    #region [ BeginAddMode ]
    private void BeginAddMode()
    {
        Response.Redirect("AddClients.aspx");

        txtName.Text = "";
        txtEmail.Text = "";
        txtPhone1.Text = "";
        txtPhone2.Text = "";
        txtAddress.Text = "";
        ddlDelegates.SelectedIndex = -1;
        txtResponsiblePerson.Text = "";
    }
    #endregion

    #endregion
}
