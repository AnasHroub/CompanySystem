using PRICES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

public partial class PricesLists : Localization
{
    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        btn_Save.Click += new EventHandler(btn_Save_Click);

        btn_Cancel.Click += new EventHandler(btn_Cancel_Click);

        gvTableOfPriceLists.PageIndexChanging += new GridViewPageEventHandler(gvTableOfPriceLists_PageIndexChanging);

        gvTableOfPriceLists.RowEditing += new GridViewEditEventHandler(gvTableOfPriceLists_RowEditing);

        gvTableOfPriceLists.RowCancelingEdit += new GridViewCancelEditEventHandler(gvTableOfPriceLists_RowCancelingEdit);

        gvTableOfPriceLists.RowUpdating += new GridViewUpdateEventHandler(gvTableOfPriceLists_RowUpdating);

        gvTableOfPriceLists.RowDeleting += new GridViewDeleteEventHandler(gvTableOfPriceLists_RowDeleting);

        gvTableOfPriceLists.RowDataBound += new GridViewRowEventHandler(gvTableOfPriceLists_RowDataBound);

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
            PRICES_LISTS_BLL oPrices = new PRICES_LISTS_BLL();
            PRICES_ENTITY oPricesEntity = new PRICES_ENTITY();

            oPricesEntity.NAME = txtName.Text;

            oPrices.Insert(oPricesEntity);

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

    #region [ gvTableOfPriceLists_PageIndexChanging ]
    private void gvTableOfPriceLists_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvTableOfPriceLists.PageIndex = e.NewPageIndex;
        FillgvTableOfPriceLists();
    }
    #endregion

    #region [ gvTableOfPriceLists_RowEditing ]
    private void gvTableOfPriceLists_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvTableOfPriceLists.EditIndex = e.NewEditIndex;
        FillgvTableOfPriceLists();
    }
    #endregion

    #region [ gvTableOfPriceLists_RowCancelingEdit ]
    private void gvTableOfPriceLists_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvTableOfPriceLists.EditIndex = -1;
        FillgvTableOfPriceLists();
    }
    #endregion

    #region [ gvTableOfPriceLists_RowUpdating ]
    private void gvTableOfPriceLists_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        PRICES_LISTS_BLL oPrices = new PRICES_LISTS_BLL();
        PRICES_ENTITY oPricesEntity = new PRICES_ENTITY();

        Label lblgvID = (Label)gvTableOfPriceLists.Rows[gvTableOfPriceLists.EditIndex].FindControl("lblgvID");
        oPricesEntity.ID = Convert.ToInt32(lblgvID.Text);

        TextBox txtgvName = (TextBox)gvTableOfPriceLists.Rows[gvTableOfPriceLists.EditIndex].FindControl("txtgvName");
        oPricesEntity.NAME = txtgvName.Text;

        oPrices.Update(oPricesEntity);

        Response.Redirect("priceslists.aspx");

    }
    #endregion

    #region [ gvTableOfPriceLists_RowDeleting ]
    private void gvTableOfPriceLists_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        PRICES_LISTS_BLL oPrices = new PRICES_LISTS_BLL();
        PRICES_ENTITY oPricesEntity = new PRICES_ENTITY();

        oPricesEntity.ID = Convert.ToInt32(gvTableOfPriceLists.DataKeys[e.RowIndex].Value);
        oPrices.Delete(oPricesEntity);

        FillgvTableOfPriceLists();
    }
    #endregion

    #region [ gvTableOfPriceLists_RowDataBound ]
    private void gvTableOfPriceLists_RowDataBound(object sender, GridViewRowEventArgs e)
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

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvTableOfPriceLists();

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {
            gvTableOfPriceLists.Style["direction"] = "rtl";
            gvTableOfPriceLists.Style["float"] = "left";

            Controls.Style["direction"] = "rtl";
            Controls.Style["display"] = "inline-block";
            Controls.Style["margin-left"] = "35%";

            div_Name_secondary.Style["display"] = "inline-flex";
            div_Name_secondary.Style["direction"] = "rtl";
        }
        else
        {
            icn_btn.Style["float"] = "left";
            Controls.Style["margin-left"] = "20%";

        }
        #endregion
    }
    #endregion

    #region [ FillgvTableOfPriceLists ]
    private void FillgvTableOfPriceLists()
    {
        PRICES_LISTS_BLL oPrices = new PRICES_LISTS_BLL();

        gvTableOfPriceLists.DataSource = oPrices.FillPricesLists();
        gvTableOfPriceLists.DataBind();
    }

    #endregion

    #region [ BeginAddMode ]
    private void BeginAddMode()
    {
        Response.Redirect("priceslists.aspx");

        txtName.Text = "";
    }
    #endregion

    #endregion
}
