using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TRANSACTIONS.DAL
{
    public partial class TRANSACTIONS_DAL
    {
        #region [ SearchTransactions ]
        public DataSet SearchTransactions(string NAME)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "SEARCH_TRANSACTIONS";

            _NAME = _cmdCommand.Parameters.Add("P_NAME", SqlDbType.VarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = !string.IsNullOrEmpty(NAME.Trim()) ? NAME.Trim() : (object)DBNull.Value;

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion
    }
}