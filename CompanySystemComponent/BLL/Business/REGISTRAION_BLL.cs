using REGISTRAION.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REGISTRAION
{
    public partial class REGISTRAION_BLL
    {
        #region [ Check_User_Authorized ]
        public Int64 Check_User_Authorized(string EMAIL, string PASSWORD)
        {
            REGISTRAION_DAL oObject = new REGISTRAION_DAL();
            return oObject.Check_User_Authorized(EMAIL, PASSWORD);
        }
        #endregion

        #region [ Get_User_Info ]
        public REGISTRAION_ENTITY Get_User_Info(string EMAIL)
        {
            REGISTRAION_DAL oObject = new REGISTRAION_DAL();
            return oObject.Get_User_Info(EMAIL);
        }
        #endregion

        #region [ Check_Email_Duplicated ]
        public Int64 Check_Email_Duplicated(string EMAIL)
        {
            REGISTRAION_DAL oObject = new REGISTRAION_DAL();
            return oObject.Check_Email_Duplicated(EMAIL);
        }
        #endregion
    }
}