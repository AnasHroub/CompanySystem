using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanySystem.GUI.Error
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        #region [ Page_Load ]
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Exception objErr = (Exception)Session["LAST_ERROR"];
                    lblErrorInPage.Text = Session["PAGE_URL"].ToString();
                    lblMessageError.Text = objErr.Message.Replace("\n", "<br/>"); ;
                    lblStackTrace.Text = objErr.ToString().Replace("\n", "<br/>");
                }
                catch
                {

                }
            }
        }
        #endregion
    }
}