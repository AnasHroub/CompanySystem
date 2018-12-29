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
        #region [ REGISTRAION_INSERT ]
        public void Insert(REGISTRAION_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "REGISTRAION_INSERT";


            _EMAIL = _cmdCommand.Parameters.Add("P_EMAIL", SqlDbType.VarChar);
            _EMAIL.Direction = ParameterDirection.Input;
            _EMAIL.Value = oEntity.EMAIL;

            _PASSWORD = _cmdCommand.Parameters.Add("P_PASSWORD", SqlDbType.VarChar);
            _PASSWORD.Direction = ParameterDirection.Input;
            _PASSWORD.Value = oEntity.PASSWORD;

            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion
    }
}