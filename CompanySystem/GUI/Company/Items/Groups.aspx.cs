using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Web;
using GROUPS;

public partial class Groups : Localization
{
    #region [ Events ]

    #region [ Properties ]

    private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    private SqlCommand _cmdCommand;
    private SqlConnection _conConnection;
    private SqlDataReader _dtrDataReader;
    private SqlDataAdapter _dataAdapter;

    #endregion

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        btn_search.Click += new EventHandler(btn_search_Click);
        btn_Save.Click += new EventHandler(btn_Save_Click);
        btn_Cancel.Click += new EventHandler(btn_Cancel_Click);
        gvGroups.RowCommand += new GridViewCommandEventHandler(gvGroups_RowCommand);

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

                gvGroups.Style["direction"] = "rtl";
                gvGroups.Style["float"] = "left";

                Controls.Style["direction"] = "rtl";

                //div_Name.Style["direction"] = "rtl";
                div_Name_secondary.Style["display"] = "inline-flex";
                div_Name_secondary.Style["direction"] = "rtl";               
            }
            else
            {
                icn_btn.Style["float"] = "left";
            }
        }

    }
    #endregion

    #region [ btn_search_Click ]
    private void btn_search_Click(object sender, EventArgs e)
    {
        FillgvGroupList();
    }

    #endregion

    #region [ btn_Save_Click ]
    private void btn_Save_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            GROUPS_BLL oGroups = new GROUPS_BLL();
            GROUPS_ENTITY oGroupsEntity = new GROUPS_ENTITY();

            oGroupsEntity.NAME = txtName.Text;

            oGroups.Insert(oGroupsEntity);

            FillgvGroupList();

            BeginAddMode();
        }
        else
        {
            GROUPS_BLL oGroups = new GROUPS_BLL();
            GROUPS_ENTITY oGroupsEntity = new GROUPS_ENTITY();

            oGroupsEntity.ID = Convert.ToInt32(Request.QueryString["ID"]);

            oGroupsEntity.NAME = txtName.Text;

            oGroups.Update(oGroupsEntity);

            FillgvGroupList();

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

    #region [ gvGroups_RowCommand ]
    private void gvGroups_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "img_edit")
        {
            GROUPS_BLL oGroups = new GROUPS_BLL();
            GROUPS_ENTITY oGroupsEntity = oGroups.Load(Convert.ToInt32(e.CommandArgument));

            txtName.Text = oGroupsEntity.NAME;

            ModalPopupExtender1.Show();

        }
        else if (e.CommandName == "img_delete")
        {
            GROUPS_BLL oGroups = new GROUPS_BLL();
            GROUPS_ENTITY oGroupsEntity = new GROUPS_ENTITY();

            oGroupsEntity.ID = Convert.ToInt32(e.CommandArgument);
            oGroups.Delete(oGroupsEntity);

            FillgvGroupList();
        }
    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvGroupList();

    }
    #endregion

    #region [ FillgvGroupList ]
    private void FillgvGroupList()
    {
        GROUPS_BLL oGroups = new GROUPS_BLL();

        gvGroups.DataSource = oGroups.SearchGroups(txtSearch.Text);
        gvGroups.DataBind();
    }

    #endregion

    #region [ BeginAddMode ]
    private void BeginAddMode()
    {
        Response.Redirect("Groups.aspx");

        txtName.Text = "";
    }
    #endregion

    #endregion
}
