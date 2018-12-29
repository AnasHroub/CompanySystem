using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace REGISTRAION.DAL
{
    public partial class REGISTRAION_DAL
    {
        #region [ Members ]

        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlCommand _cmdCommand;
        private SqlConnection _conConnection;
        private SqlDataReader _dtrDataReader;
        private SqlDataAdapter _dataAdapter;


        private SqlParameter _ID;
        private SqlParameter _EMAIL;
        private SqlParameter _PASSWORD;
        private SqlParameter _NAME;
        private SqlParameter _PHONE_NO;


        #endregion

        #region [ Check_User_Authorized ]
        public Int64 Check_User_Authorized(string EMAIL, string PASSWORD)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "CHECK_USER_AUTHORIZED";

            _EMAIL = _cmdCommand.Parameters.Add("P_EMAIL", SqlDbType.NVarChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = EMAIL;

            _PASSWORD = _cmdCommand.Parameters.Add("P_PASSWORD", SqlDbType.NVarChar);
            _PASSWORD.Direction = ParameterDirection.Input;
            _PASSWORD.Value = PASSWORD;

            _conConnection.Open();
            DataTable _dataTable = new DataTable();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(_dataTable);

           return _dataTable.Rows.Count;


        }
        #endregion

        #region [ Get_User_Info ]
        public REGISTRAION_ENTITY Get_User_Info(string EMAIL)
        {
            REGISTRAION_ENTITY oEntity = new REGISTRAION_ENTITY();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "GET_USER_INFO";

            _EMAIL = _cmdCommand.Parameters.Add("P_EMAIL", SqlDbType.NVarChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = EMAIL;


            _conConnection.Open();
            _dtrDataReader = _cmdCommand.ExecuteReader();
            if (_dtrDataReader.HasRows)
            {
                while (_dtrDataReader.Read())
                {
                    oEntity.ID = Convert.ToInt64(_dtrDataReader["ID"].ToString());

                    oEntity.EMAIL = Convert.ToString(_dtrDataReader["EMAIL"].ToString());

                    oEntity.PASSWORD = Convert.ToString(_dtrDataReader["PASSWORD"].ToString());

                    oEntity.NAME = Convert.ToString(_dtrDataReader["NAME"].ToString());
                }
            }
            _dtrDataReader.Close();
            _conConnection.Close();
            return oEntity;
        }
        #endregion

        #region [ Check_Email_Duplicated ]
        public Int64 Check_Email_Duplicated(string EMAIL)
        {
            REGISTRAION_ENTITY oEntity = new REGISTRAION_ENTITY();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "GET_USER_INFO";

            _EMAIL = _cmdCommand.Parameters.Add("P_EMAIL", SqlDbType.NVarChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = EMAIL;


            _conConnection.Open();
            DataTable _dataTable = new DataTable();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(_dataTable);

            return _dataTable.Rows.Count;
        }
        #endregion
    }
}
