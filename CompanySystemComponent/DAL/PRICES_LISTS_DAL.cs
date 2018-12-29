using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PRICES.DAL
{
    public partial class PRICES_LISTS_DAL
    {
        #region [ Members ]

        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlCommand _cmdCommand;
        private SqlConnection _conConnection;
        private SqlDataReader _dtrDataReader;
        private SqlDataAdapter _dataAdapter;

        private SqlParameter _ID;
        private SqlParameter _NAME;       

        #endregion

        #region [ PRICES_LIST_INSERT ]
        public void Insert(PRICES_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "PRICES_LIST_INSERT";

            _NAME = _cmdCommand.Parameters.Add("P_Name", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;        

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ PRICES_LIST_UPDATE ]
        public void Update(PRICES_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "PRICES_LIST_UPDATE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _NAME = _cmdCommand.Parameters.Add("P_Name", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ PRICES_LIST_DELETE ]
        public void Delete(PRICES_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "PRICES_LIST_DELETE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion
    
    }
}