using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRANSACTIONS
{
    [Serializable]
    public partial class TRANSACTIONS_ENTITY
    {
        #region [ ID ]
        public Int64 ID
        {
            get;
            set;
        }
        #endregion

        #region [ Delegate_ID ]
        public Int64 Delegate_ID
        {
            get;
            set;
        }
        #endregion

        #region [ Group_ID ]
        public Int64 Group_ID
        {
            get;
            set;
        }
        #endregion

        #region [ Item_ID ]
        public Int64 Item_ID
        {
            get;
            set;
        }
        #endregion

        #region [ Largist_Unit_Quantity ]
        public float Largist_Unit_Quantity
        {
            get;
            set;
        }
        #endregion

        #region [ Smallest_Unit_Quantity ]
        public float Smallest_Unit_Quantity
        {
            get;
            set;
        }
        #endregion

        #region [ Inserted_Date ]
        public string Inserted_Date
        {
            get;
            set;
        }
        #endregion

        #region [ Updated_Date ]
        public string Updated_Date
        {
            get;
            set;
        }
        #endregion

    }
}