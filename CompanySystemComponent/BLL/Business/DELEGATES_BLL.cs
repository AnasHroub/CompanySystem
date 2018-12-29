using DELEGATES.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DELEGATES
{
    public partial class DELEGATES_BLL
    {
        #region [ FillDelegates ]
        public DataSet FillDelegates()
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FillDelegates();
        }
        #endregion

        #region [ FilterDelegates_ID ]
        public DataSet FilterDelegates_ID(Int64 ID)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_ID(ID);
        }
        #endregion

        #region [ FilterDelegates_Name ]
        public DataSet FilterDelegates_Name(string NAME)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_Name(NAME);
        }
        #endregion

        #region [ FilterDelegates_Gender ]
        public DataSet FilterDelegates_Gender(Int64 Gender)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_Gender(Gender);
        }
        #endregion

        #region [ FilterDelegates_Martial_Status ]
        public DataSet FilterDelegates_Martial_Status(Int64 Martial_Status)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_Martial_Status(Martial_Status);
        }
        #endregion

        #region [ FilterDelegates_BirthDate ]
        public DataSet FilterDelegates_BirthDate(string BirthDate)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_BirthDate(BirthDate);
        }
        #endregion

        #region [ FilterDelegates_Phone ]
        public DataSet FilterDelegates_Phone(string Phone_NO)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_Phone(Phone_NO);
        }
        #endregion

        #region [ FilterDelegates_Address ]
        public DataSet FilterDelegates_Address(string Address)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_Address(Address);
        }
        #endregion

        #region [ FilterDelegates_Email ]
        public DataSet FilterDelegates_Email(string Email)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.FilterDelegates_Email(Email);
        }
        #endregion

    }
}