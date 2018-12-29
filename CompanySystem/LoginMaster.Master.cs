using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanySystem
{
    public partial class LoginMaster : System.Web.UI.MasterPage
    {

        #region [ Page_Load ]
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Lang"].ToString() == "ar")
                {
                    Lang.Style["margin-left"] = "17%";
                }
                else
                {
                    Lang.Style["margin-left"] = "-67%";
                }
            }
        }
        #endregion

        #region [ Lbtn_lang1_Click ]
        protected void Lbtn_lang1_Click(object sender, EventArgs e)
        {
            Session["Lang"] = "ar";
            Server.Transfer(Request.Url.PathAndQuery);

        }
        #endregion

        #region [ Lbtn_lang2_Click ]
        protected void Lbtn_lang2_Click(object sender, EventArgs e)
        {
            Session["Lang"] = "en";
            Server.Transfer(Request.Url.PathAndQuery);

        }
        #endregion
    }
}