using ITEMS;
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

public partial class Items : Localization
{
    #region [ Events ]

    #region [ Properties ]

    private SqlConnection _conConnection;

    #endregion

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        btn_search.Click += new EventHandler(btn_search_Click);
        btn_Save.Click += new EventHandler(btn_Save_Click);
        btn_Cancel.Click += new EventHandler(btn_Cancel_Click);
        gvItem.RowCommand += new GridViewCommandEventHandler(gvItem_RowCommand);

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

                gvItem.Style["direction"] = "rtl";
                gvItem.Style["float"] = "left";

                Controls.Style["direction"] = "rtl";


                div_Code_secondary.Style["display"] = "inline-flex";
                div_Code_secondary.Style["direction"] = "rtl";

                div_Name_secondary.Style["display"] = "inline-flex";
                div_Name_secondary.Style["direction"] = "rtl";

                div_Groups_secondary.Style["display"] = "inline-flex";
                div_Groups_secondary.Style["direction"] = "rtl";

                div_LargistUnitType_secondary.Style["display"] = "inline-flex";
                div_LargistUnitType_secondary.Style["direction"] = "rtl";

                div_SmallestUnitType_secondary.Style["display"] = "inline-flex";
                div_SmallestUnitType_secondary.Style["direction"] = "rtl";

                div_LargestUnit_secondary.Style["display"] = "inline-flex";
                div_LargestUnit_secondary.Style["direction"] = "rtl";

                div_SmallestUnit_secondary.Style["display"] = "inline-flex";
                div_SmallestUnit_secondary.Style["direction"] = "rtl";             
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
        FillgvItemList();
    }

    #endregion

    #region [ btn_Save_Click ]
    private void btn_Save_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            ITEMS_BLL oItem = new ITEMS_BLL();
            ITEMS_ENTITY oItemEntity = new ITEMS_ENTITY();

            oItemEntity.CODE = txtCode.Text;

            oItemEntity.NAME = txtName.Text;

            oItemEntity.GROUP_ID = Convert.ToInt64(ddlGroups.SelectedValue);

            oItemEntity.LARGIST_UNIT_TYPE = txtLargistUnitype.Text;

            oItemEntity.SMALLEST_UNIT_TYPE = txtSmallestUnitype.Text;

            if (!txtLargestUnit.Text.Contains(".00"))
             {
                oItemEntity.LARGIST_UNIT_PRICE = Convert.ToDecimal(txtLargestUnit.Text) + Convert.ToDecimal(".00");
            }
            else
            {
                oItemEntity.LARGIST_UNIT_PRICE = Convert.ToDecimal(txtLargestUnit.Text);
            }

            if (!txtSmallestUnit.Text.Contains(".00"))
            {
                oItemEntity.SMALLEST_UNIT_PRICE = Convert.ToDecimal(txtSmallestUnit.Text) + Convert.ToDecimal(".00");
            }
            else
            {
                oItemEntity.SMALLEST_UNIT_PRICE = Convert.ToDecimal(txtSmallestUnit.Text);
            }

            oItem.Insert(oItemEntity);

            FillgvItemList();

            BeginAddMode();
        }
        else
        {
            ITEMS_BLL oItem = new ITEMS_BLL();
            ITEMS_ENTITY oItemEntity = new ITEMS_ENTITY();

            oItemEntity.ID = Convert.ToInt32(Request.QueryString["ID"]);

            oItemEntity.CODE = txtCode.Text;

            oItemEntity.NAME = txtName.Text;

            oItemEntity.GROUP_ID = Convert.ToInt64(ddlGroups.SelectedValue);

            oItemEntity.LARGIST_UNIT_TYPE = txtLargistUnitype.Text;

            oItemEntity.SMALLEST_UNIT_TYPE = txtSmallestUnitype.Text;

            oItemEntity.LARGIST_UNIT_PRICE = Convert.ToDecimal(txtLargestUnit.Text);

            oItemEntity.SMALLEST_UNIT_PRICE = Convert.ToDecimal(txtSmallestUnit.Text);

            oItem.Update(oItemEntity);

            FillgvItemList();

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

    #region [ gvItem_RowCommand ]
    private void gvItem_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "img_edit")
        {
            ITEMS_BLL oItem = new ITEMS_BLL();
            ITEMS_ENTITY oItemEntity = oItem.Load(Convert.ToInt32(e.CommandArgument));

            txtCode.Text = oItemEntity.CODE;

            txtName.Text = oItemEntity.NAME;

            ddlGroups.SelectedValue = Convert.ToString(oItemEntity.GROUP_ID);

            txtLargistUnitype.Text = oItemEntity.LARGIST_UNIT_TYPE;

            txtSmallestUnitype.Text = oItemEntity.SMALLEST_UNIT_TYPE;

            txtLargestUnit.Text = Convert.ToString(oItemEntity.LARGIST_UNIT_PRICE);

            txtSmallestUnit.Text = Convert.ToString(oItemEntity.SMALLEST_UNIT_PRICE);

            ModalPopupExtender1.Show();


        }
        else if (e.CommandName == "img_delete")
        {
            ITEMS_BLL oItem = new ITEMS_BLL();
            ITEMS_ENTITY oItemEntity = new ITEMS_ENTITY();

            oItemEntity.ID = Convert.ToInt32(e.CommandArgument);
            oItem.Delete(oItemEntity);

            FillgvItemList();
        }
    }
    #endregion


    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvItemList();

        FillddlGroups();

    }
    #endregion

    #region [ EstablishConnection ]
    private void EstablishConnection()
    {
        _conConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    }
    #endregion

    #region [ FillgvItemList ]
    private void FillgvItemList()
    {
        ITEMS_BLL oItem = new ITEMS_BLL();

        gvItem.DataSource = oItem.FillItems();
        gvItem.DataBind();
    }

    #endregion

    #region [ FillddlGroups ]
    private void FillddlGroups()
    {
        EstablishConnection();

        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GROUPS", _conConnection);
        da.SelectCommand.CommandType = CommandType.Text;

        DataSet ds = new DataSet();
        da.Fill(ds);

        _conConnection.Open();
        ddlGroups.DataSource = ds;
        ddlGroups.DataValueField = "ID";
        ddlGroups.DataTextField = "Name";
        ddlGroups.DataBind();
        ddlGroups.Items.Insert(0, new ListItem("--Select Group--", "0"));
        _conConnection.Close();
    }
    #endregion

    #region [ BeginAddMode ]
    private void BeginAddMode()
    {
        Response.Redirect("Items.aspx");

        txtCode.Text = "";
        txtName.Text = "";
        ddlGroups.SelectedIndex = -1;
        txtLargestUnit.Text = "";
        txtSmallestUnit.Text = "";
    }
    #endregion

    #endregion
}
