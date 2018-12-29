using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanySystem
{
    public partial class ControlPanel : System.Web.UI.MasterPage
    {
        #region [ Page_Load ]
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Lang"].ToString() == "ar")
                {
                    SignInLeft.Style["float"] = "right";
                    SignInLeft.Style["direction"] = "rtl";
                    SignInLeft.Style["margin-right"] = "07%";
                    SignInLeft.Style.Add("border-right", "");
                    SignInLeft.Style.Add("border-left", "2px #ccc solid");
                    SignInLeft.Style.Add("margin-right", "3%");

                    SignInRight.Style.Remove("margin-right");

                    Header_title.Style["margin-left"] = "79.5%";

                }
                else
                {
                    SignInLeft.Style.Add("border-right", "2px #ccc solid");
                    SignInLeft.Style.Add("margin-left", "3%");


                    SignInRight.Style.Add("float", "right");
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