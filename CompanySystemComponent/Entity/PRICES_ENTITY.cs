using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRICES
{
    [Serializable]
    public partial class PRICES_ENTITY
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

        #region [ CLIENT_ID ]
        public Int64 CLIENT_ID
        {
            get;
            set;
        }
        #endregion    
        
    }
}