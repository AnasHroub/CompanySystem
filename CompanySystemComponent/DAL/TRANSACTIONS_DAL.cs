using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TRANSACTIONS.DAL
{
    public partial class TRANSACTIONS_DAL
    {
        #region [ Members ]

        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlCommand _cmdCommand;
        private SqlConnection _conConnection;
        private SqlDataReader _dtrDataReader;
        private SqlDataAdapter _dataAdapter;

        private SqlParameter _ID;
        private SqlParameter _NAME;
        private SqlParameter _DELEGATE_ID;
        private SqlParameter _GROUP_ID;
        private SqlParameter _ITEM_ID;
        private SqlParameter _LARGIST_UNIT_QUANTITY;
        private SqlParameter _SMALLEST_UNIT_QUANTITY;
        private SqlParameter _INSERTED_DATE;
        private SqlParameter _UPDATED_DATE;


        #endregion

        #region [ TRANSACTIONS_INSERT ]
        public void Insert(TRANSACTIONS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "TRANSACTIONS_INSERT";

            _DELEGATE_ID = _cmdCommand.Parameters.Add("P_Delegate_ID", SqlDbType.Int);
            _DELEGATE_ID.Direction = ParameterDirection.Input;
            _DELEGATE_ID.Value = oEntity.Delegate_ID;

            _GROUP_ID = _cmdCommand.Parameters.Add("P_Group_ID", SqlDbType.Int);
            _GROUP_ID.Direction = ParameterDirection.Input;
            _GROUP_ID.Value = oEntity.Group_ID;

            _ITEM_ID = _cmdCommand.Parameters.Add("P_Item_ID", SqlDbType.Int);
            _ITEM_ID.Direction = ParameterDirection.Input;
            _ITEM_ID.Value = oEntity.Item_ID;

            _LARGIST_UNIT_QUANTITY = _cmdCommand.Parameters.Add("P_Largist_Unit_Quantity", SqlDbType.Float);
            _LARGIST_UNIT_QUANTITY.Direction = ParameterDirection.Input;
            _LARGIST_UNIT_QUANTITY.Value = oEntity.Largist_Unit_Quantity;

            _SMALLEST_UNIT_QUANTITY = _cmdCommand.Parameters.Add("P_Smallest_Unit_Quantity ", SqlDbType.Float);
            _SMALLEST_UNIT_QUANTITY.Direction = ParameterDirection.Input;
            _SMALLEST_UNIT_QUANTITY.Value = oEntity.Smallest_Unit_Quantity;

            _INSERTED_DATE = _cmdCommand.Parameters.Add("P_Inserted_Date ", SqlDbType.NVarChar);
            _INSERTED_DATE.Direction = ParameterDirection.Input;
            _INSERTED_DATE.Value = oEntity.Inserted_Date;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ TRANSACTIONS_UPDATE ]
        public void Update(TRANSACTIONS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "TRANSACTIONS_UPDATE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _DELEGATE_ID = _cmdCommand.Parameters.Add("P_Delegate_ID", SqlDbType.Int);
            _DELEGATE_ID.Direction = ParameterDirection.Input;
            _DELEGATE_ID.Value = oEntity.Delegate_ID;

            _GROUP_ID = _cmdCommand.Parameters.Add("P_Group_ID", SqlDbType.Int);
            _GROUP_ID.Direction = ParameterDirection.Input;
            _GROUP_ID.Value = oEntity.Group_ID;

            _ITEM_ID = _cmdCommand.Parameters.Add("P_Item_ID", SqlDbType.Int);
            _ITEM_ID.Direction = ParameterDirection.Input;
            _ITEM_ID.Value = oEntity.Item_ID;

            _LARGIST_UNIT_QUANTITY = _cmdCommand.Parameters.Add("P_Largist_Unit_Quantity", SqlDbType.Float);
            _LARGIST_UNIT_QUANTITY.Direction = ParameterDirection.Input;
            _LARGIST_UNIT_QUANTITY.Value = oEntity.Largist_Unit_Quantity;

            _SMALLEST_UNIT_QUANTITY = _cmdCommand.Parameters.Add("P_Smallest_Unit_Quantity ", SqlDbType.Float);
            _SMALLEST_UNIT_QUANTITY.Direction = ParameterDirection.Input;
            _SMALLEST_UNIT_QUANTITY.Value = oEntity.Smallest_Unit_Quantity;

            _UPDATED_DATE = _cmdCommand.Parameters.Add("P_Updated_Date ", SqlDbType.NVarChar);
            _UPDATED_DATE.Direction = ParameterDirection.Input;
            _UPDATED_DATE.Value = oEntity.Updated_Date;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ TRANSACTIONS_DELETE ]
        public void Delete(TRANSACTIONS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "TRANSACTIONS_DELETE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ TRANSACTIONS_LOAD ]
        public TRANSACTIONS_ENTITY Load(int ID)
        {
            TRANSACTIONS_ENTITY oEntity = new TRANSACTIONS_ENTITY();

            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "TRANSACTIONS_LOAD";

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

                    oEntity.Delegate_ID = Convert.ToInt32(_dtrDataReader["Delegate_ID"].ToString());

                    oEntity.Group_ID = Convert.ToInt32(_dtrDataReader["Group_ID"].ToString());

                    oEntity.Item_ID = Convert.ToInt32(_dtrDataReader["Item_ID"].ToString());

                    oEntity.Largist_Unit_Quantity = Convert.ToInt64(_dtrDataReader["Largist_Unit_Quantity"].ToString());

                    oEntity.Smallest_Unit_Quantity = Convert.ToInt64(_dtrDataReader["Smallest_Unit_Quantity"].ToString());

                    oEntity.Inserted_Date =_dtrDataReader["Inserted_Date"].ToString();

                    oEntity.Updated_Date = _dtrDataReader["Updated_Date"].ToString();
                }
            }
            _dtrDataReader.Close();
            _conConnection.Close();
            return oEntity;
        }
        #endregion
    }
}