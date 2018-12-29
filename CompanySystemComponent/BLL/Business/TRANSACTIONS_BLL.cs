using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TRANSACTIONS.DAL;

namespace TRANSACTIONS
{
    public partial class TRANSACTIONS_BLL
    {
        #region [ SearchTransactions ]
        public DataSet SearchTransactions(string NAME)
        {
            TRANSACTIONS_DAL oObject = new TRANSACTIONS_DAL();
            return oObject.SearchTransactions(NAME);
        }
        #endregion
    }
}