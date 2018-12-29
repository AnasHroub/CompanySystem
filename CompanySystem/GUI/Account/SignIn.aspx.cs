using REGISTRAION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Web;
using System.Globalization;

public partial class SignIn : Localization
    {
        #region [ Page_Init ]
        protected void Page_Init(object sender, EventArgs e)
        {
            btnSignIn.Click += new EventHandler(btnSignIn_Click);
        }
        #endregion

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
                SignInLeft.Style.Add("border-left", "1px #ccc solid");

                SignInRight.Style.Remove("margin-right");

                Header_title.Style["margin-left"] = "79.5%";

            }
            else
            {
                SignInLeft.Style.Add("border-right", "1px #ccc solid");
                SignInRight.Style.Add("float", "right");
            }
        }
    }
        #endregion

        #region [ btnSignIn_Click ]
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            REGISTRAION_BLL oCheck = new REGISTRAION_BLL();
            int Counter = (int)oCheck.Check_User_Authorized(txtEmail.Text, txtPassword.Text);

            if (Counter > 0)
            {
                REGISTRAION_ENTITY oEntity = oCheck.Get_User_Info(txtEmail.Text);

                Session["Name"] = oEntity.NAME;
                Response.Redirect("~/GUI/Company/Delegates/Delegates.aspx", true);
            }
            else
            {
               if (Session["Lang"].ToString() == "ar")
               {
                lbl_err.Text = "البريد الإلكتروني أو كلمة المرور غير صالحين";
               }
               else
               {
                  lbl_err.Text = "Invalid Email or Password";
               }
        }
        }
        #endregion

    }
