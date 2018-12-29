using REGISTRAION.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REGISTRAION
{
    public partial class REGISTRAION_BLL
    {
        #region [ Insert ]
        public void Insert(REGISTRAION_ENTITY oEntity)
        {
            REGISTRAION_DAL oObject = new REGISTRAION_DAL();
            oObject.Insert(oEntity);
        }
        #endregion
    }
}