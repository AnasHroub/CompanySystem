using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using System.Globalization;

public partial class EditProfile : Localization
{
    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
    }
    #endregion

    #region [ Page_Load ]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Lang"].ToString() == "ar")
            {


            }
            else
            {

            }
        }
    }
    #endregion
}
