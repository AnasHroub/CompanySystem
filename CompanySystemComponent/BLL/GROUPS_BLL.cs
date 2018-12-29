using GROUPS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GROUPS
{
    public partial class GROUPS_BLL
    {
        #region [ Insert ]
        public void Insert(GROUPS_ENTITY oEntity)
        {
            GROUPS_DAL oObject = new GROUPS_DAL();
            oObject.Insert(oEntity);
        }
        #endregion

        #region [ Update ]
        public void Update(GROUPS_ENTITY oEntity)
        {
            GROUPS_DAL oObject = new GROUPS_DAL();
            oObject.Update(oEntity);
        }

        #endregion

        #region [ Delete ]
        public void Delete(GROUPS_ENTITY oEntity)
        {
            GROUPS_DAL oObject = new GROUPS_DAL();
            oObject.Delete(oEntity);
        }
        #endregion

        #region [ Load ]
        public GROUPS_ENTITY Load(int ID)
        {
            GROUPS_DAL oObject = new GROUPS_DAL();
            return oObject.Load(ID);
        }
        #endregion      
    }
}