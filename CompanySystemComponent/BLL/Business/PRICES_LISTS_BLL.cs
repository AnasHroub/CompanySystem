using PRICES.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PRICES
{
    public partial class PRICES_LISTS_BLL
    {
        #region [ FillPricesLists ]
        public DataSet FillPricesLists()
        {
            PRICES_LISTS_DAL oObject = new PRICES_LISTS_DAL();
            return oObject.FillPricesList();
        }
        #endregion

        #region [ FillPricesItems ]
        public DataSet FillPricesItems()
        {
            PRICES_LISTS_DAL oObject = new PRICES_LISTS_DAL();
            return oObject.FillPricesItems();
        }
        #endregion

    }
}