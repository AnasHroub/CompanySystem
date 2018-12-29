using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEMS
{
    [Serializable]
    public partial class ITEMS_ENTITY
    {
        #region [ ID ]
        public Int64 ID
        {
            get;
            set;
        }
        #endregion

        #region [ CODE ]
        public string CODE
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

        #region [ GROUP_ID ]
        public Int64 GROUP_ID
        {
            get;
            set;
        }
        #endregion

        #region [ LARGIST_UNIT_TYPE ]
        public string LARGIST_UNIT_TYPE
        {
            get;
            set;
        }
        #endregion

        #region [ SMALLEST_UNIT_TYPE ]
        public string SMALLEST_UNIT_TYPE
        {
            get;
            set;
        }
        #endregion

        #region [ LARGIST_UNIT_PRICE ]
        public decimal LARGIST_UNIT_PRICE
        {
            get;
            set;
        }
        #endregion

        #region [ SMALLEST_UNIT_PRICE ]
        public decimal SMALLEST_UNIT_PRICE
        {
            get;
            set;
        }
        #endregion
    }
}