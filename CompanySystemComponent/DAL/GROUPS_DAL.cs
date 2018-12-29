using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GROUPS.DAL
{
    public partial class GROUPS_DAL
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

        #region [ GROUPS_INSERT ]
        public void Insert(GROUPS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "GROUPS_INSERT";

            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ GROUPS_UPDATE ]
        public void Update(GROUPS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "GROUPS_UPDATE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ GROUPS_DELETE ]
        public void Delete(GROUPS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "GROUPS_DELETE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ GROUPS_LOAD ]
        public GROUPS_ENTITY Load(int ID)
        {
            GROUPS_ENTITY oEntity = new GROUPS_ENTITY();

            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "GROUPS_LOAD";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = ID;

            _conConnection.Open();
            _dtrDataReader = _cmdCommand.ExecuteReader();
            if (_dtrDataReader.HasRows)
            {
                while (_dtrDataReader.Read())
                {
                    oEntity.ID = Convert.ToInt64(_dtrDataReader["ID"].ToString());
      
                    oEntity.NAME = _dtrDataReader["Name"].ToString();
                }
            }
            _dtrDataReader.Close();
            _conConnection.Close();
            return oEntity;
        }
        #endregion
    }
}