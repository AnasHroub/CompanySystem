using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;

namespace DELEGATES.DAL
{
    public partial class DELEGATES_DAL
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
        private SqlParameter _GENDER;
        private SqlParameter _MARTIAL_STATUS;
        private SqlParameter _BIRTH_DATE;
        private SqlParameter _PHONE_NO;
        private SqlParameter _ADDRESS;

        #endregion

        #region [ DELEGATES_INSERT ]
        public void Insert(DELEGATES_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "DELEGATES_INSERT";


            _EMAIL = _cmdCommand.Parameters.Add("P_EMAIL", SqlDbType.NChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = oEntity.EMAIL;

            _PASSWORD = _cmdCommand.Parameters.Add("P_PASSWORD", SqlDbType.NChar);
            _PASSWORD.Direction = ParameterDirection.Input;
            _PASSWORD.Value = oEntity.PASSWORD;

            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _GENDER = _cmdCommand.Parameters.Add("P_Gender_ID", SqlDbType.Int);
            _GENDER.Direction = ParameterDirection.Input;
            _GENDER.Value = oEntity.GENDER_ID;

            _MARTIAL_STATUS = _cmdCommand.Parameters.Add("P_Martial_Status_ID", SqlDbType.Int);
            _MARTIAL_STATUS.Direction = ParameterDirection.Input;
            _MARTIAL_STATUS.Value = oEntity.MARTIAL_STATUS_ID;

            _BIRTH_DATE = _cmdCommand.Parameters.Add("P_BIRTH_DATE", SqlDbType.NVarChar);
            _BIRTH_DATE.Direction = ParameterDirection.Input;
            _BIRTH_DATE.Value = oEntity.BIRTH_DATE;

            _PHONE_NO = _cmdCommand.Parameters.Add("P_PHONE_NO", SqlDbType.NChar);
            _PHONE_NO.Direction = ParameterDirection.Input;
            _PHONE_NO.Value = oEntity.PHONE_NO;

            _ADDRESS = _cmdCommand.Parameters.Add("P_ADDRESS", SqlDbType.NText);
            _ADDRESS.Direction = ParameterDirection.Input;
            _ADDRESS.Value = oEntity.ADDRESS;
            

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ DELEGATES_UPDATE ]
        public void Update(DELEGATES_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "DELEGATES_UPDATE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _EMAIL = _cmdCommand.Parameters.Add("P_Email", SqlDbType.NChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = oEntity.EMAIL;

            _PASSWORD = _cmdCommand.Parameters.Add("P_PASSWORD", SqlDbType.NChar);
            _PASSWORD.Direction = ParameterDirection.Input;
            _PASSWORD.Value = oEntity.PASSWORD;

            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _GENDER = _cmdCommand.Parameters.Add("P_GENDER_ID", SqlDbType.Int);
            _GENDER.Direction = ParameterDirection.Input;
            _GENDER.Value = oEntity.GENDER_ID;

            _MARTIAL_STATUS = _cmdCommand.Parameters.Add("P_Martial_Status_ID", SqlDbType.Int);
            _MARTIAL_STATUS.Direction = ParameterDirection.Input;
            _MARTIAL_STATUS.Value = oEntity.MARTIAL_STATUS_ID;

            _BIRTH_DATE = _cmdCommand.Parameters.Add("P_Birth_Date", SqlDbType.NChar);
            _BIRTH_DATE.Direction = ParameterDirection.Input;
            _BIRTH_DATE.Value = oEntity.BIRTH_DATE;

            _PHONE_NO = _cmdCommand.Parameters.Add("P_PHONE_NO", SqlDbType.NChar);
            _PHONE_NO.Direction = ParameterDirection.Input;
            _PHONE_NO.Value = oEntity.PHONE_NO;                                                         

            _ADDRESS = _cmdCommand.Parameters.Add("P_Address", SqlDbType.NText);
            _ADDRESS.Direction = ParameterDirection.Input;
            _ADDRESS.Value = oEntity.ADDRESS;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ DELEGATES_DELETE ]
        public void Delete(DELEGATES_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "DELEGATES_DELETE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ DELEGATES_LOAD ]
        public DELEGATES_ENTITY Load(int ID)
        {
            DELEGATES_ENTITY oEntity = new DELEGATES_ENTITY();

            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "DELEGATES_LOAD";

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

                    oEntity.EMAIL = _dtrDataReader["Email"].ToString();

                    oEntity.PASSWORD = _dtrDataReader["Password"].ToString();

                    oEntity.NAME = _dtrDataReader["Name"].ToString();

                    oEntity.GENDER_ID = Convert.ToInt64(_dtrDataReader["Gender_ID"].ToString());

                    oEntity.MARTIAL_STATUS_ID = Convert.ToInt64(_dtrDataReader["Martial_Status"].ToString());

                    oEntity.BIRTH_DATE = _dtrDataReader["Birth_Date"].ToString();

                    oEntity.PHONE_NO = _dtrDataReader["Phone_NO"].ToString();

                    oEntity.ADDRESS = _dtrDataReader["Address"].ToString();                 
                }
            }
            _dtrDataReader.Close();
            _conConnection.Close();
            return oEntity;
        }
        #endregion
    }
}