using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ShopApp
{
    public class DbAccess
    {
        //region for logical segmentation
        #region Constructor + Members
        protected OleDbConnection _conn = null;

        public DbAccess(string connectionString)
        {
            try
            {
                _conn = new OleDbConnection(connectionString);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Protected Methods
        protected void Connect()
        {
            if (_conn.State != ConnectionState.Open)
            {
                try
                {
                    _conn.Open();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        protected void Disconnect()
        {
            _conn.Close();
        }

        protected void ExecuteSimpleQuery(OleDbCommand command)
        {
            lock (_conn)//lock the connection for data base
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    command.ExecuteNonQuery();//Query like insert/update/delete
                }
                
                finally
                {
                    Disconnect();
                }
            }
        }

        protected int ExecuteScalarIntQuery(OleDbCommand command)
        {
            int ret = -1;
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = (int)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }

        protected DataSet GetMultipleQuery(OleDbCommand command)
        {
            DataSet dataset = new DataSet();
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset);

                }
                finally
                {
                    Disconnect();
                }
            }
            return dataset;
        }
        #endregion
    }
}
