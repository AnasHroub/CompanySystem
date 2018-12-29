using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Web
{
    public class Localization : Page
    {
        #region [ Properties ]

        #region ErrorPageURL
        public string ErrorPageURL
        {
            get
            {
                string ErrPage = Request.ApplicationPath + "/GUI/Error/ErrorPage.aspx";
                return ErrPage;
            }
        }
        #endregion

        #endregion

        #region [ Events ]

        #region [ InitializeCulture ]
        protected override void InitializeCulture()
        {
            if (Session["Lang"] != null)
            {
                Culture = Session["Lang"].ToString();
                UICulture = Session["Lang"].ToString();
            }

            base.InitializeCulture();
        }
        #endregion

        //#region [ Page_Error ]
        //public void Page_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError().GetBaseException();
        //    Session["Exception"] = ex; 
        //    Session["LAST_ERROR"] = Server.GetLastError().GetBaseException();
        //    Session["PAGE_URL"] = Request.Url.ToString();
        //    Response.Redirect(ErrorPageURL);
        //}
        //#endregion



        #endregion
    }
}