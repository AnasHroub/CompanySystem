using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using CLIENTS;
using System.Data;

public partial class ClientsDelegates : Localization
{
    #region [ Events ]

    #region [ Properties ]

    private SqlConnection _conConnection;

    #endregion

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        gvClientDelegate.RowCommand += new GridViewCommandEventHandler(gvClientDelegate_RowCommand);
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

    #region [ gvClientDelegate_RowCommand ]
    private void gvClientDelegate_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btn_Approved")
        {
            CLIENTS_BLL oClient = new CLIENTS_BLL();
            CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvClientDelegate.Rows[rowIndex];

            oClientEntity.NAME = row.Cells[1].Text;

            oClientEntity.EMAIL = row.Cells[2].Text;

            oClientEntity.PHONE1 = row.Cells[3].Text;

            oClientEntity.PHONE2 = row.Cells[4].Text;

            oClientEntity.ADDRESS = row.Cells[5].Text;

            #region [ Get_Delegate_ID ]
            EstablishConnection();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Delegates WHERE Name = '" + row.Cells[6].Text + "'", _conConnection);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter daDelegates = new SqlDataAdapter();
            daDelegates.SelectCommand = cmd;

            DataTable dtDelegates = new DataTable();
            daDelegates.Fill(dtDelegates);
            #endregion

            oClientEntity.DELEGATE_ID = Convert.ToInt64(dtDelegates.Rows[0][0]);

            oClientEntity.RESPONSIBLE_PEARSON = row.Cells[7].Text;

            oClient.Insert(oClientEntity);


            oClientEntity.ID = Convert.ToInt32(row.Cells[0].Text);
            oClient.CS_Delete(oClientEntity);

           FillgvClientDelegateList();
        }
        else if (e.CommandName == "btn_Non_Approved")
        {
            CLIENTS_BLL oClient = new CLIENTS_BLL();
            CLIENTS_ENTITY oClientEntity = new CLIENTS_ENTITY();

            oClientEntity.ID = Convert.ToInt32(e.CommandArgument);
            oClient.CS_Delete(oClientEntity);

            FillgvClientDelegateList();
        }
    }
    #endregion 

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FillgvClientDelegateList();

        hdn_Session.Value = Session["Lang"].ToString();

        #region Translation
        if (Session["Lang"].ToString() == "ar")
        {
            gvClientDelegate.Style["direction"] = "rtl";
            gvClientDelegate.Style["float"] = "left";
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
    private void FillgvClientDelegateList()
    {
        CLIENTS_BLL oClient = new CLIENTS_BLL();

        gvClientDelegate.DataSource = oClient.FillClientsDelegates();
        gvClientDelegate.DataBind();
    }

    #endregion

    #endregion
}
