using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Data;
using System.Collections;

namespace REGISTRAION
{
    [Serializable]
    public partial class REGISTRAION_ENTITY
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
    }
}