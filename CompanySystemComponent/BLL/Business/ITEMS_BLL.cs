using ITEMS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ITEMS
{
    public partial class ITEMS_BLL
    {
        #region [ FillItems ]
        public DataSet FillItems()
        {
            ITEMS_DAL oObject = new ITEMS_DAL();
            return oObject.FillItems();
        }
        #endregion
    }
}