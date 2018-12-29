using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace PRICES.DAL
{
    public partial class PRICES_LISTS_DAL
    {       
        #region [ FillPricesList ]
        public DataSet FillPricesList()
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "FILL_PRICES_LISTS";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FillPricesItems ]
        public DataSet FillPricesItems()
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "FILL_PRICES_ITEMS";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

    }
}