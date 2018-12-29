using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DELEGATES.DAL
{
    public partial class DELEGATES_DAL
    {
        #region [ FillDelegates ]
        public DataSet FillDelegates()
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "[FILL_DELEGATES]";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_ID ]
        public DataSet FilterDelegates_ID(Int64 ID)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.ID Like '%' + \'" + @ID + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_Name ]
        public DataSet FilterDelegates_Name(string NAME)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Name Like '%' + \'" + @NAME + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_Gender ]
        public DataSet FilterDelegates_Gender(Int64 Gender)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Gender_ID Like '%' + \'" + @Gender + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_Martial_Status ]
        public DataSet FilterDelegates_Martial_Status(Int64 Martial_Status)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Martial_Status_ID Like '%' + \'" + @Martial_Status + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_BirthDate ]
        public DataSet FilterDelegates_BirthDate(string BirthDate)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Birth_Date Like '%' + \'" + @BirthDate + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_Phone ]
        public DataSet FilterDelegates_Phone(string Phone_NO)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Phone_NO Like '%' + \'" + @Phone_NO + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_Address ]
        public DataSet FilterDelegates_Address(string Address)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Address Like '%' + \'" + @Address + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterDelegates_Email ]
        public DataSet FilterDelegates_Email(string Email)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Delegates.ID, Delegates.Name, Gender.Name \"Gender\", Martial_Status.Name \"Martial_Status\", " +
             " Delegates.Birth_Date, Delegates.Phone_NO, Delegates.Address, Delegates.Email, Delegates.Password From Delegates inner join Gender on Delegates.Gender_ID " +
             " = Gender.ID inner join Martial_Status on Delegates.Martial_Status_ID = Martial_Status.ID where Delegates.Email Like '%' + \'" + @Email + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

    }
}