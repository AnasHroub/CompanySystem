using REGISTRAION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

public partial class Registration : Localization
    {
    #region [ Events ]

    #region [ Page_Init ]
    protected void Page_Init(object sender, EventArgs e)
    {
        btnRegistration.Click += new EventHandler(btnRegistration_Click);
    }
    #endregion

    #region [ Page_Load ]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtPassword.Attributes["type"] = "password";
            txtConfirmPassword.Attributes["type"] = "password";
        }
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

    #region [ btnRegistration_Click ]
    private void btnRegistration_Click(object sender, EventArgs e)
    {
        REGISTRAION_BLL oRegistration = new REGISTRAION_BLL();
        REGISTRAION_ENTITY oRegistrationEntity = new REGISTRAION_ENTITY();

        oRegistrationEntity.NAME = txtName.Text;

        oRegistrationEntity.PASSWORD = txtPassword.Text;

        oRegistrationEntity.EMAIL = txtEmail.Text;

        oRegistration.Insert(oRegistrationEntity);

        Response.Redirect("SignIn.aspx");
    }
    #endregion

    #endregion
}
