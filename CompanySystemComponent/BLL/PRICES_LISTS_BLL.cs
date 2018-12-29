using PRICES.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRICES
{
    public partial class PRICES_LISTS_BLL
    {
        #region [ Insert ]
        public void Insert(PRICES_ENTITY oEntity)
        {
            PRICES_LISTS_DAL oObject = new PRICES_LISTS_DAL();
            oObject.Insert(oEntity);
        }
        #endregion

        #region [ Update ]
        public void Update(PRICES_ENTITY oEntity)
        {
            PRICES_LISTS_DAL oObject = new PRICES_LISTS_DAL();
            oObject.Update(oEntity);
        }

        #endregion

        #region [ Delete ]
        public void Delete(PRICES_ENTITY oEntity)
        {
            PRICES_LISTS_DAL oObject = new PRICES_LISTS_DAL();
            oObject.Delete(oEntity);
        }
        #endregion       

    }
}