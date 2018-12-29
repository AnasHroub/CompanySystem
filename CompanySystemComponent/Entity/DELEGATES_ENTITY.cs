using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DELEGATES
{
    [Serializable]
    public partial class DELEGATES_ENTITY
    {
        #region [ ID ]
        public Int64 ID
        {
            get;
            set;
        }
        #endregion

        #region [ EMAIL ]
        public string EMAIL
        {
            get;
            set;
        }
        #endregion

        #region [ PASSWORD ]
        public string PASSWORD
        {
            get;
            set;
        }
        #endregion

        #region [ NAME ]
        public string NAME
        {
            get;
            set;
        }
        #endregion

        #region [ GENDER_ID ]
        public Int64 GENDER_ID 
        {
            get;
            set;
        }
        #endregion

        #region [ MARTIAL_STATUS_ID ]
        public Int64 MARTIAL_STATUS_ID
        {
            get;
            set;
        }
        #endregion

        #region [ BIRTH_DATE ]
        public string BIRTH_DATE
        {
            get;
            set;
        }
        #endregion

        #region [ PHONE_NO ]
        public string PHONE_NO
        {
            get;
            set;
        }
        #endregion

        #region [ ADDRESS ]
        public string ADDRESS
        {
            get;
            set;
        }
        #endregion
    }
}