using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLIENTS
{
    [Serializable]
    public partial class CLIENTS_ENTITY
    {
        #region [ ID ]
        public Int64 ID
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

        #region [ EMAIL ]
        public string EMAIL
        {
            get;
            set;
        }
        #endregion

        #region [ PHONE1 ]
        public string PHONE1
        {
            get;
            set;
        }
        #endregion

        #region [ PHONE2 ]
        public string PHONE2
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

        #region [ DELEGATE_ID ]
        public Int64 DELEGATE_ID
        {
            get;
            set;
        }
        #endregion

        #region [ RESPONSIBLE_PEARSON ]
        public string RESPONSIBLE_PEARSON
        {
            get;
            set;
        }
        #endregion

        
    }
}