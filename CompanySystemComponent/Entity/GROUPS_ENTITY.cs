using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GROUPS
{
    [Serializable]
    public partial class GROUPS_ENTITY
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
    }
}