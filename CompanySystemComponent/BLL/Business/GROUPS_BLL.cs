using GROUPS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GROUPS
{
    public partial class GROUPS_BLL
    {
        #region [ SearchGroups ]
        public DataSet SearchGroups(string NAME)
        {
            GROUPS_DAL oObject = new GROUPS_DAL();
            return oObject.SearchGroups(NAME);
        }
        #endregion
    }
}