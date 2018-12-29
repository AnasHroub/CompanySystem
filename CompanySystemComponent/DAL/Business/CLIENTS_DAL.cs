using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CLIENTS.DAL
{
    public partial class CLIENTS_DAL
    {
        #region [ FillClientsDelegates ]
        public DataSet FillClientsDelegates()
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "FILL_CLIENTS_DELEGATES";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FillClients ]
        public DataSet FillClients()
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.StoredProcedure;
            _cmdCommand.CommandText = "FILL_CLIENTS";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_ID ]
        public DataSet FilterClients_ID(Int64 ID)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
               " From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.ID Like '%' + \'" + @ID + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_Name ]
        public DataSet FilterClients_Name(string NAME)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
               " From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.Name Like '%' + \'" + @NAME + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_Email ]
        public DataSet FilterClients_Email(string Email)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
                 "From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.Email Like '%' + \'" + @Email + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_Phone1 ]
        public DataSet FilterClients_Phone1(string Phone1)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
                 "From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.Phone1 Like '%' + \'" + @Phone1 + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_Phone2 ]
        public DataSet FilterClients_Phone2(string Phone2)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
                 "From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.Phone2 Like '%' + \'" + @Phone2 + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_Address ]
        public DataSet FilterClients_Address(string Address)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
                 "From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.Address Like '%' + \'" + @Address + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_Delegate ]
        public DataSet FilterClients_Delegate(String Delegate)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
                 "From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Delegates.Name Like '%' + \'" + @Delegate + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

        #region [ FilterClients_ResponsiblePerson ]
        public DataSet FilterClients_ResponsiblePerson(String ResponsiblePerson)
        {
            DataSet ds = new DataSet();
            _conConnection = new SqlConnection();
            _cmdCommand = new SqlCommand();
            _dataAdapter = new SqlDataAdapter();
            _conConnection.ConnectionString = _ConnectionString;
            _cmdCommand.Connection = _conConnection;
            _cmdCommand.CommandType = CommandType.Text;
            _cmdCommand.CommandText = "Select Clients.ID, Clients.Name, Clients.Email, Clients.Phone1, Clients.Phone2, Clients.Address, Delegates.Name \"Delegate\", Clients.Responsible_Person " +
                 "From Clients inner join Delegates on Clients.Delegate_ID = Delegates.ID where Clients.Responsible_Person Like '%' + \'" + @ResponsiblePerson + "\' + '%' ";

            _conConnection.Open();
            _dataAdapter.SelectCommand = _cmdCommand;
            _dataAdapter.Fill(ds);
            _conConnection.Close();
            return ds;
        }
        #endregion

    }
}