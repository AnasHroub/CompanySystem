using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ITEMS.DAL
{
    public partial class ITEMS_DAL
    {
        #region [ Members ]

        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlCommand _cmdCommand;
        private SqlConnection _conConnection;
        private SqlDataReader _dtrDataReader;
        private SqlDataAdapter _dataAdapter;

        private SqlParameter _ID;
        private SqlParameter _CODE;
        private SqlParameter _NAME;
        private SqlParameter _GROUP_ID;
        private SqlParameter _LARGIST_UNIT_TYPE;
        private SqlParameter _SMALLEST_UNIT_TYPE;
        private SqlParameter _LARGIST_UNIT_PRICE;
        private SqlParameter _SMALLEST_UNIT_PRICE;

        #endregion

        #region [ ITEMS_INSERT ]
        public void Insert(ITEMS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "ITEMS_INSERT";

            _CODE = _cmdCommand.Parameters.Add("P_Code", SqlDbType.NChar);
            _CODE.Direction = ParameterDirection.Input;
            _CODE.Value = oEntity.CODE;

            _NAME = _cmdCommand.Parameters.Add("P_Name", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _GROUP_ID = _cmdCommand.Parameters.Add("P_Group_ID", SqlDbType.Int);
            _GROUP_ID.Direction = ParameterDirection.Input;
            _GROUP_ID.Value = oEntity.GROUP_ID;

            _LARGIST_UNIT_TYPE = _cmdCommand.Parameters.Add("P_Largist_Unit_Type", SqlDbType.NVarChar);
            _LARGIST_UNIT_TYPE.Direction = ParameterDirection.Input;
            _LARGIST_UNIT_TYPE.Value = oEntity.LARGIST_UNIT_TYPE;

            _SMALLEST_UNIT_TYPE = _cmdCommand.Parameters.Add("P_Smallest_Unit_Type", SqlDbType.NVarChar);
            _SMALLEST_UNIT_TYPE.Direction = ParameterDirection.Input;
            _SMALLEST_UNIT_TYPE.Value = oEntity.SMALLEST_UNIT_TYPE;

            _LARGIST_UNIT_PRICE = _cmdCommand.Parameters.Add("P_Largist_Unit_Price", SqlDbType.Decimal);
            _LARGIST_UNIT_PRICE.Direction = ParameterDirection.Input;
            _LARGIST_UNIT_PRICE.Value = oEntity.LARGIST_UNIT_PRICE;

            _SMALLEST_UNIT_PRICE = _cmdCommand.Parameters.Add("P_Smallest_Unit_Price", SqlDbType.Decimal);
            _SMALLEST_UNIT_PRICE.Direction = ParameterDirection.Input;
            _SMALLEST_UNIT_PRICE.Value = oEntity.SMALLEST_UNIT_PRICE;       

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ ITEMS_UPDATE ]
        public void Update(ITEMS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "ITEMS_UPDATE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _CODE = _cmdCommand.Parameters.Add("P_Code", SqlDbType.NChar);
            _CODE.Direction = ParameterDirection.Input;
            _CODE.Value = oEntity.CODE;

            _NAME = _cmdCommand.Parameters.Add("P_Name", SqlDbType.NVarChar);
            _NAME.Direction = ParameterDirection.Input;
            _NAME.Value = oEntity.NAME;

            _GROUP_ID = _cmdCommand.Parameters.Add("P_Group_ID", SqlDbType.Int);
            _GROUP_ID.Direction = ParameterDirection.Input;
            _GROUP_ID.Value = oEntity.GROUP_ID;

            _LARGIST_UNIT_TYPE = _cmdCommand.Parameters.Add("P_Largist_Unit_Type", SqlDbType.NVarChar);
            _LARGIST_UNIT_TYPE.Direction = ParameterDirection.Input;
            _LARGIST_UNIT_TYPE.Value = oEntity.LARGIST_UNIT_TYPE;

            _SMALLEST_UNIT_TYPE = _cmdCommand.Parameters.Add("P_Smallest_Unit_Type", SqlDbType.NVarChar);
            _SMALLEST_UNIT_TYPE.Direction = ParameterDirection.Input;
            _SMALLEST_UNIT_TYPE.Value = oEntity.SMALLEST_UNIT_TYPE;

            _LARGIST_UNIT_PRICE = _cmdCommand.Parameters.Add("P_Largist_Unit_Price", SqlDbType.Decimal);
            _LARGIST_UNIT_PRICE.Direction = ParameterDirection.Input;
            _LARGIST_UNIT_PRICE.Value = oEntity.LARGIST_UNIT_PRICE;

            _SMALLEST_UNIT_PRICE = _cmdCommand.Parameters.Add("P_Smallest_Unit_Price", SqlDbType.Decimal);
            _SMALLEST_UNIT_PRICE.Direction = ParameterDirection.Input;
            _SMALLEST_UNIT_PRICE.Value = oEntity.SMALLEST_UNIT_PRICE;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ ITEMS_DELETE ]
        public void Delete(ITEMS_ENTITY oEntity)
        {
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "ITEMS_DELETE";

            _ID = _cmdCommand.Parameters.Add("P_ID", SqlDbType.Int);
            _ID.Direction = ParameterDirection.Input;
            _ID.Value = oEntity.ID;

            _conConnection.Open();
            _cmdCommand.ExecuteNonQuery();
            _conConnection.Close();
        }
        #endregion

        #region [ ITEMS_LOAD ]
        public ITEMS_ENTITY Load(int ID)
        {
            ITEMS_ENTITY oEntity = new ITEMS_ENTITY();

            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "ITEMS_LOAD";

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

                    oEntity.CODE = _dtrDataReader["Code"].ToString();

                    oEntity.NAME = _dtrDataReader["Name"].ToString();

                    oEntity.GROUP_ID = Convert.ToInt32(_dtrDataReader["Group_ID"].ToString());

                    oEntity.LARGIST_UNIT_TYPE = _dtrDataReader["Largist_Unit_Type"].ToString();

                    oEntity.SMALLEST_UNIT_TYPE = _dtrDataReader["Smallest_Unit_Type"].ToString();

                    oEntity.LARGIST_UNIT_PRICE = Convert.ToDecimal(_dtrDataReader["Largist_Unit_Price"].ToString());

                    oEntity.SMALLEST_UNIT_PRICE = Convert.ToDecimal(_dtrDataReader["Smallest_Unit_Price"].ToString());
                }
            }
            _dtrDataReader.Close();
            _conConnection.Close();
            return oEntity;
        }
        #endregion
    }
}