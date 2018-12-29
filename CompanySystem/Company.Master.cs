using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company : System.Web.UI.MasterPage
{
    #region [ Events ]

    #region [ Page_Load ]
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PerformSetting();
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

    #endregion

    #region [ Methods ]

    #region [ PerformSetting ]
    private void PerformSetting()
    {
        FetchingName();

        #region Translation
           if (Session["Lang"].ToString() == "ar")
           {
               Arrow.InnerHtml = "◀";
               Arrow.Style["float"] = "left";

               hList.Style["display"] = "inline-flex";
               hList.Style["direction"] = "rtl";
           
               id_UserArea.Style["float"] = "left";
           
               lbl_Welcome.Style["direction"] = "rtl";
               lbl_Welcome.Style["float"] = "right";
               lbl_Welcome.Style["margin-right"] = "30px";
               lbl_Welcome.Style["margin-left"] = "-20px";
               SiteMap.Style["direction"] = "rtl";
               SiteMap.Style["margin-right"] = "2.4%";
        }
           else
           {
               bottom_Arrow1.Style["float"] = "right";
               bottom_Arrow1.Style["padding-right"] = "3%";

               bottom_Arrow2.Style["float"] = "right";
               bottom_Arrow2.Style["padding-right"] = "3%";
            
               bottom_Arrow3.Style["float"] = "right";
               bottom_Arrow3.Style["padding-right"] = "3%";

               Tran1.Style["padding-right"] = "22%";
               Tran2.Style["margin-left"] = "22%";

              bottom_Arrow4.Style["float"] = "right";
               bottom_Arrow4.Style["padding-right"] = "3%";
               bottom_Arrow4.Style["margin-right"] = "-20%";


               bottom_Arrow5.Style["float"] = "right";
               bottom_Arrow5.Style["padding-right"] = "3%";

               Arrow.InnerHtml = "▶";
               Arrow.Style["float"] = "Right";

               id_UserArea.Style["float"] = "right";

               Lang.Style["margin-left"] = "10px";
                Lang.Style["float"] = "left";

            hList.Style["margin-left"] = "10%";
               hList.Style["margin-bottom"] = "12%";
           
               Profilediv.Style["height"] = "30px";

               menu_showright.Style["margin-left"] = "93.5%";
               menu_showright.Style["margin-top"] = "-32%";
        }
        #endregion

        hdn_Session.Value = Session["Lang"].ToString();
    }
    #endregion

    #region [ FetchingName ]
    private void FetchingName()
    {
        if (Session["Name"] != null)
        {
            lbl_Name.Text = (string)Session["Name"];
        }
        else
        {
            //Response.Redirect("/GUI/Error/NotAuthorizedPage.aspx");
        }
    }
    #endregion

    #region [ SiteMapPath1_ItemCreated ]
    protected void SiteMapPath1_ItemCreated(object sender, SiteMapNodeItemEventArgs e)
    {
      if (e.Item.ItemType == SiteMapNodeItemType.Root || (e.Item.ItemType == SiteMapNodeItemType.PathSeparator && e.Item.ItemIndex == 1))
      {
          e.Item.Visible = false;
      }
    }
    #endregion

    #endregion
}
