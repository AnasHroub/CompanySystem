using CLIENTS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLIENTS
{
    public partial class CLIENTS_BLL
    {
        #region [ Insert ]
        public void Insert(CLIENTS_ENTITY oEntity)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            oObject.Insert(oEntity);
        }
        #endregion

        #region [ Update ]
        public void Update(CLIENTS_ENTITY oEntity)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            oObject.Update(oEntity);
        }

        #endregion

        #region [ Delete ]
        public void Delete(CLIENTS_ENTITY oEntity)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            oObject.Delete(oEntity);
        }
        #endregion

        #region [ Load ]
        public CLIENTS_ENTITY Load(int ID)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.Load(ID);
        }
        #endregion      

        #region [ CS_Delete ]
        public void CS_Delete(CLIENTS_ENTITY oEntity)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            oObject.CS_Delete(oEntity);
        }
        #endregion
    }
}