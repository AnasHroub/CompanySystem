using ITEMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEMS
{
    public partial class ITEMS_BLL
    {
        #region [ Insert ]
        public void Insert(ITEMS_ENTITY oEntity)
        {
            ITEMS_DAL oObject = new ITEMS_DAL();
            oObject.Insert(oEntity);
        }
        #endregion

        #region [ Update ]
        public void Update(ITEMS_ENTITY oEntity)
        {
            ITEMS_DAL oObject = new ITEMS_DAL();
            oObject.Update(oEntity);
        }

        #endregion

        #region [ Delete ]
        public void Delete(ITEMS_ENTITY oEntity)
        {
            ITEMS_DAL oObject = new ITEMS_DAL();
            oObject.Delete(oEntity);
        }
        #endregion

        #region [ Load ]
        public ITEMS_ENTITY Load(int ID)
        {
            ITEMS_DAL oObject = new ITEMS_DAL();
            return oObject.Load(ID);
        }
        #endregion      
    }
}