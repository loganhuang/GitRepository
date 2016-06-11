using System;
using System.Data.SqlClient;

namespace SQLPractice
{
    class DBOperate : IDisposable
    {
        #region fields and properies
        private string connectionString;
        private bool connected = false;
        public string ConnectionString { get; private set; }
        private SqlConnection sqlConnection;
        #endregion

        #region Constructor
        public DBOperate()
            : this(Varables.ConnectionStr) { }
        public DBOperate(string connectionString)
        {
            this.connectionString = connectionString;
        }
        #endregion

        #region Motheds
        public bool Connect()
        {
            if(connectionString != null)
            {
                try
                {
                    if(!connected)
                    {
                        sqlConnection = new SqlConnection(connectionString);
                        sqlConnection.Open();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool CloseOperate()
        {
            try
            {
                Dispose(true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region IDisposable Support
        private bool disposed = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    sqlConnection.Close();
                    sqlConnection.Dispose();                    
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
