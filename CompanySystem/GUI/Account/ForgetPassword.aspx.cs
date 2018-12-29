using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace CompanySystem.GUI.Account
{
    public partial class ForgetPassword : Localization
    {

        #region [ Properties ]

        public SqlConnection _conConnection;

        #endregion

        #region [ Page_Init ]
        protected void Page_Init(object sender, EventArgs e)
        {
            btn_Submit.Click += new EventHandler(btn_Submit_Click);
        }
        #endregion

        #region [ Page_Load ]
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Lang"].ToString() == "ar")
                {

                    Header_title.Style["margin-left"] = "79.5%";

                    Email_Secondary.Style["margin-left"] = "45%";
                    Email_Secondary.Style["Display"] = "inline-flex";
                    Email_Secondary.Style["direction"] = "rtl";

                    Email_div.Style["width"] = "45%";
                    txtEmail.Style["width"] = "200%";

                    Controls.Style["margin-right"] = "10%";

                    div_login.Style["margin-right"] = "10%";
                    div_login.Style["direction"] = "rtl";

                    divhelp.Style["margin-right"] = "10%";

                    lblMessage.Style["margin-right"] = "10%";
                }
                else
                {

                }
            }
        }
        #endregion

        #region [ btn_Submit_Click ]
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string username = string.Empty;
            string password = string.Empty;
            
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name, [Password] FROM Users WHERE Email = @Email"))
                {
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            username = sdr["Name"].ToString();
                            password = sdr["Password"].ToString();
                        }
                    }
                    con.Close();
                }
            }

            if (!string.IsNullOrEmpty(password))
            {
                MailMessage mm = new MailMessage("anas-alhroub@hotmail.com", txtEmail.Text.Trim());
                mm.Subject = "Password Recovery";
                mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", username, password);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.live.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = "anas-alhroub@hotmail.com";
                NetworkCred.Password = "93/An17/93";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                lblMessage.ForeColor = Color.Green;

                if (Session["Lang"].ToString() == "ar")
                {
                    lblMessage.Text = "لقد تم إرسال كلمة المرور إلى البريد الإلكتروني الخاص بك";

                }
                else
                { 
                lblMessage.Text = "Password has been sent to your email address.";
                }
            }
            else
            {
                lblMessage.ForeColor = Color.Red;

                if (Session["Lang"].ToString() == "ar")
                {
                    lblMessage.Text = "هذا البريد الإلكتروني غير متشابه مع السجلات التي لدينا";

                }
                else
                {
                    lblMessage.Text = "This email address does not match our records.";
                }
            }
        }
        #endregion
    }
}