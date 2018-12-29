using CLIENTS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CLIENTS
{
    public partial class CLIENTS_BLL
    {

        #region [ FillClientsDelegates ]
        public DataSet FillClientsDelegates()
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FillClientsDelegates();
        }
        #endregion

        #region [ FillClients ]
        public DataSet FillClients()
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FillClients();
        }
        #endregion

        #region [ FilterClients_ID ]
        public DataSet FilterClients_ID(Int64 ID)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_ID(ID);
        }
        #endregion

        #region [ FilterClients_Name ]
        public DataSet FilterClients_Name(string NAME)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_Name(NAME);
        }
        #endregion

        #region [ FilterClients_Email ]
        public DataSet FilterClients_Email(string Email)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_Email(Email);
        }
        #endregion

        #region [ FilterClients_Phone1 ]
        public DataSet FilterClients_Phone1(string Phone1)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_Phone1(Phone1);
        }
        #endregion

        #region [ FilterClients_Phone2 ]
        public DataSet FilterClients_Phone2(string Phone2)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_Phone2(Phone2);
        }
        #endregion

        #region [ FilterClients_Address ]
        public DataSet FilterClients_Address(string Address)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_Address(Address);
        }
        #endregion

        #region [ FilterClients_Delegate ]
        public DataSet FilterClients_Delegate(String Delegate)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_Delegate(Delegate);
        }
        #endregion

        #region [ FilterClients_ResponsiblePerson ]
        public DataSet FilterClients_ResponsiblePerson(String ResponsiblePerson)
        {
            CLIENTS_DAL oObject = new CLIENTS_DAL();
            return oObject.FilterClients_ResponsiblePerson(ResponsiblePerson);
        }
        #endregion
    }
}