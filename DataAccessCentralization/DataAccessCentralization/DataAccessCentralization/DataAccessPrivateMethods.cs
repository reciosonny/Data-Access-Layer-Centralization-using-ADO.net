using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCentralization
{
    /// <summary>
    /// put private methods here
    /// </summary>
    public partial class BaseDataAccess
    {
        /// <summary>
        /// initialization casting for InitializeDataAccess()
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="Query"></param>
        private void castProvider(ProviderType type, string ConnectionString, string Query = null)
        {
            switch (type)
            {
                case ProviderType.Oledb:
                    conn = new OleDbConnection(ConnectionString);
                    cmd = new OleDbCommand(Query, (OleDbConnection)conn);
                    da = new OleDbDataAdapter();
                    break;
                case ProviderType.Odbc:
                    conn = new OdbcConnection(ConnectionString);
                    cmd = new OdbcCommand(Query, (OdbcConnection)conn);
                    da = new OdbcDataAdapter();
                    break;
                case ProviderType.SqlClient:
                    conn = new SqlConnection(ConnectionString);
                    cmd = new SqlCommand(Query, (SqlConnection)conn);
                    da = new SqlDataAdapter();
                    break;
                //case ProviderType.OracleClient:
                //    conn = new OracleConnection(ConnectionString);
                //    cmd = new OracleCommand(Query,(OracleConnection)conn);
                //    break;
            }
        }

        /// <summary>
        /// counts for number of rows.
        /// </summary>
        /// <param name="rowCount"></param>
        private void CheckForRows(int rowCount)
        {
            if (rowCount > 0)
                HasRows = true;
            else HasRows = false;
        }
    }
}
