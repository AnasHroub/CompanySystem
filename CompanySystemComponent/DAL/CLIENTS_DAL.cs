using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CLIENTS.DAL
{
    public partial class CLIENTS_DAL
    {
        #region [ Members ]

        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlCommand _cmdCommand;
        private SqlConnection _conConnection;
        private SqlDataReader _dtrDataReader;
        private SqlDataAdapter _dataAdapter;

        private SqlParameter _ID;
        private SqlParameter _NAME;
        private SqlParameter _EMAIL;
        private SqlParameter _PHONE1;
        private SqlParameter _PHONE2;
        private SqlParameter _ADDRESS;
        private SqlParameter _DELEGATE_ID;
        private SqlParameter _RESPONSIBLE_PEARSON_ID;



        #endregion

        #region [ CLIENTS_INSERT ]
        public void Insert(CLIENTS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "CLIENTS_INSERT";

            _NAME = _cmdCommand.Parameters.Add("P_Name", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _EMAIL = _cmdCommand.Parameters.Add("P_Email", SqlDbType.NChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = oEntity.EMAIL;

            _PHONE1 = _cmdCommand.Parameters.Add("P_PHONE1", SqlDbType.NChar);
            _PHONE1.Direction = ParameterDirection.Input;
            _PHONE1.Value = oEntity.PHONE1;

            _PHONE2 = _cmdCommand.Parameters.Add("P_PHONE2", SqlDbType.NChar);
            _PHONE2.Direction = ParameterDirection.Input;
            _PHONE2.Value = oEntity.PHONE2;

            _ADDRESS = _cmdCommand.Parameters.Add("P_Address ", SqlDbType.NText);
            _ADDRESS.Direction = ParameterDirection.Input;
            _ADDRESS.Value = oEntity.ADDRESS;

            _DELEGATE_ID = _cmdCommand.Parameters.Add("P_Delegate_ID", SqlDbType.Int);
            _DELEGATE_ID.Direction = ParameterDirection.Input;
            _DELEGATE_ID.Value = oEntity.DELEGATE_ID;

            _RESPONSIBLE_PEARSON_ID = _cmdCommand.Parameters.Add("P_Responsible_Person", SqlDbType.NVarChar);
            _RESPONSIBLE_PEARSON_ID.Direction = ParameterDirection.Input;
            _RESPONSIBLE_PEARSON_ID.Value = oEntity.RESPONSIBLE_PEARSON;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ CLIENTS_UPDATE ]
        public void Update(CLIENTS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "CLIENTS_UPDATE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _NAME = _cmdCommand.Parameters.Add("P_Name", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _EMAIL = _cmdCommand.Parameters.Add("P_Email", SqlDbType.NChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = oEntity.EMAIL;

            _PHONE1 = _cmdCommand.Parameters.Add("P_PHONE1", SqlDbType.NChar);
            _PHONE1.Direction = ParameterDirection.Input;
            _PHONE1.Value = oEntity.PHONE1;

            _PHONE2 = _cmdCommand.Parameters.Add("P_PHONE2", SqlDbType.NChar);
            _PHONE2.Direction = ParameterDirection.Input;
            _PHONE2.Value = oEntity.PHONE2;

            _ADDRESS = _cmdCommand.Parameters.Add("P_Address ", SqlDbType.NText);
            _ADDRESS.Direction = ParameterDirection.Input;
            _ADDRESS.Value = oEntity.ADDRESS;

            _DELEGATE_ID = _cmdCommand.Parameters.Add("P_Delegate_ID", SqlDbType.Int);
            _DELEGATE_ID.Direction = ParameterDirection.Input;
            _DELEGATE_ID.Value = oEntity.DELEGATE_ID;

            _RESPONSIBLE_PEARSON_ID = _cmdCommand.Parameters.Add("P_Responsible_Person", SqlDbType.NVarChar);
            _RESPONSIBLE_PEARSON_ID.Direction = ParameterDirection.Input;
            _RESPONSIBLE_PEARSON_ID.Value = oEntity.RESPONSIBLE_PEARSON;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ CLIENTS_DELETE ]
        public void Delete(CLIENTS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "CLIENTS_DELETE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ CLIENTS_LOAD ]
        public CLIENTS_ENTITY Load(int ID)
        {
            CLIENTS_ENTITY oEntity = new CLIENTS_ENTITY();

            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "CLIENTS_LOAD";

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

                    oEntity.EMAIL = _dtrDataReader["Email"].ToString();

                    oEntity.PHONE1 = _dtrDataReader["Phone1"].ToString();

                    oEntity.PHONE2 = _dtrDataReader["Phone2"].ToString();

                    oEntity.ADDRESS = _dtrDataReader["Address"].ToString();

                    oEntity.DELEGATE_ID = Convert.ToInt32(_dtrDataReader["Delegate_ID"].ToString());

                    oEntity.RESPONSIBLE_PEARSON = _dtrDataReader["Responsible_Person"].ToString();
                }
            }
            _dtrDataReader.Close();
            _conConnection.Close();
            return oEntity;
        }
        #endregion

        #region [ CLIENTS_DELEGATES_DELETE ]
        public void CS_Delete(CLIENTS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "CLIENTS_DELEGATES_DELETE";

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