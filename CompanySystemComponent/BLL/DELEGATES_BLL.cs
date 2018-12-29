using DELEGATES.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DELEGATES
{
    public partial class DELEGATES_BLL
    {
        #region [ Insert ]
        public void Insert(DELEGATES_ENTITY oEntity)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            oObject.Insert(oEntity);
        }
        #endregion

        #region [ Update ]
        public void Update(DELEGATES_ENTITY oEntity)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            oObject.Update(oEntity);
        }

        #endregion

        #region [ Delete ]
        public void Delete(DELEGATES_ENTITY oEntity)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            oObject.Delete(oEntity);
        }
        #endregion

        #region [ Load ]
        public DELEGATES_ENTITY Load(int ID)
        {
            DELEGATES_DAL oObject = new DELEGATES_DAL();
            return oObject.Load(ID);
        }
        #endregion      
    }
}