using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRANSACTIONS.DAL;

namespace TRANSACTIONS
{
    public partial class TRANSACTIONS_BLL
    {
        #region [ Insert ]
        public void Insert(TRANSACTIONS_ENTITY oEntity)
        {
            TRANSACTIONS_DAL oObject = new TRANSACTIONS_DAL();
            oObject.Insert(oEntity);
        }
        #endregion

        #region [ Update ]
        public void Update(TRANSACTIONS_ENTITY oEntity)
        {
            TRANSACTIONS_DAL oObject = new TRANSACTIONS_DAL();
            oObject.Update(oEntity);
        }

        #endregion

        #region [ Delete ]
        public void Delete(TRANSACTIONS_ENTITY oEntity)
        {
            TRANSACTIONS_DAL oObject = new TRANSACTIONS_DAL();
            oObject.Delete(oEntity);
        }
        #endregion

        #region [ Load ]
        public TRANSACTIONS_ENTITY Load(int ID)
        {
            TRANSACTIONS_DAL oObject = new TRANSACTIONS_DAL();
            return oObject.Load(ID);
        }
        #endregion      
    }
}