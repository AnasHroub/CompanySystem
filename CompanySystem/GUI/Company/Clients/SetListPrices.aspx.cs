using ITEMS;
using PRICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

public partial class SetListPrices : Localization
{
    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        gvSetListPrices_1.PageIndexChanging += new GridViewPageEventHandler(gvSetListPrices_1_PageIndexChanging);

        gvSetListPrices_1.RowUpdating += new GridViewUpdateEventHandler(gvSetListPrices_1_RowUpdating);

        gvSetListPrices_1.RowCommand += new GridViewCommandEventHandler(gvSetListPrices_1_RowCommand);
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

        }
    }
    #endregion

    #region [ btn_Cancel_Click ]
    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {

        }
    }
    #endregion

    #region [ gvSetListPrices_1_PageIndexChanging ]
    private void gvSetListPrices_1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvSetListPrices_1.PageIndex = e.NewPageIndex;
        FillgvSetListPrices_1();
    }
    #endregion

    #region [ gvSetListPrices_1_RowUpdating ]
    private void gvSetListPrices_1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //CLIENTS_BLL oClient = new CLIENTS_BLL();
        //CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

        //Label lblgvID = (Label)gvClient.Rows[gvClient.EditIndex].FindControl("lblgvID");
        //oClientEntity.ID = Convert.ToInt32(lblgvID.Text);

        //TextBox txtgvName = (TextBox)gvClient.Rows[gvClient.EditIndex].FindControl("txtgvName");
        //oClientEntity.NAME = txtgvName.Text;
    }
    #endregion

    #region [ gvSetListPrices_1_RowCommand ]
    private void gvSetListPrices_1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btn_Set_Prices")
        {

            MultiView.ActiveViewIndex = 1;


        }
    }
    #endregion

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvSetListPrices_1();

        FillgvSetListPrices_2();


        SetDefaultView();

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {
            gvSetListPrices_1.Style["direction"] = "rtl";
            gvSetListPrices_1.Style["float"] = "left";
        }
        else
        {
        }
        #endregion
    }
    #endregion

    #region [ FillgvSetListPrices_1 ]
    private void FillgvSetListPrices_1()
    {
        PRICES_LISTS_BLL oPrices = new PRICES_LISTS_BLL();

        gvSetListPrices_1.DataSource = oPrices.FillPricesLists();
        gvSetListPrices_1.DataBind();
    }

    #endregion

    #region [ FillgvSetListPrices_2 ]
    private void FillgvSetListPrices_2()
    {
        PRICES_LISTS_BLL oPrice = new PRICES_LISTS_BLL();

        gvSetListPrices_2.DataSource = oPrice.FillPricesItems();
        gvSetListPrices_2.DataBind();
    }

    #endregion

    #region [ SetDefaultView ]
    private void SetDefaultView()
    {
        MultiView.ActiveViewIndex = 0;
    }
    #endregion

    #endregion
}
