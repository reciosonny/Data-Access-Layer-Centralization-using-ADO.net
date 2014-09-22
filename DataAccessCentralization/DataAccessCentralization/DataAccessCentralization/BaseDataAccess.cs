using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace DataAccessCentralization
{
    public enum ProviderType { 
        Oledb,
        Odbc,
        SqlClient
    }
    
    public partial class BaseDataAccess
    {
        private IDbConnection conn { get; set; }
        private IDbCommand cmd { get; set; }
        private DataSet ds { get; set; }
        //private DataTable dt { get; set; }
        private IDbDataAdapter da { get; set; }

        /// <summary>
        /// use this to check if your SQL query has rows.
        /// </summary>
        public bool HasRows { get; private set; }

        /// <summary>
        /// passes the chosen type during initialization so that a developer doesn't need to specify a provider type again in each methods.
        /// </summary>
        private ProviderType chosenType { get; set; }


        /// <summary>
        /// use this if you intend to create a parameter-based command for query use. This method is similar to cmd.Parameters.AddWithValue()
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        public void CreateCommandParameters(string parameterName, object value)
        {
            switch (chosenType)
            {
                case ProviderType.Oledb:
                    cmd.Parameters.Add(new OleDbParameter(string.Format("@{0}",parameterName),value));
                    break;
                case ProviderType.Odbc:
                    cmd.Parameters.Add(new OdbcParameter(string.Format("@{0}",parameterName),value));
                    break;
                case ProviderType.SqlClient:
                    cmd.Parameters.Add(new SqlParameter(string.Format("@{0}",parameterName),value));
                    break;
            }
        }

        /// <summary>
        /// Initializes Data Access before you can set perform CRUD Operations
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="Query"></param>
        public void InitializeDataAccess(ProviderType type, string ConnectionString, string Query)
        {
            //conn = new OleDbConnection(ConnectionString);
            //cmd = new OleDbCommand(Query,(OleDbConnection)conn);
            castProvider(type, ConnectionString,Query);
            chosenType = type;
            ds = new DataSet();
            da = new OleDbDataAdapter();
            //dt = new DataTable();
        }

        /// <summary>
        /// Initializes Data Access before you can set perform CRUD Operations
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ConnectionString"></param>
        public void InitializeDataAccess(ProviderType type, string ConnectionString)
        {
            //conn = new OleDbConnection(ConnectionString);
            //cmd = new OleDbCommand(null, (OleDbConnection)conn);
            castProvider(type, ConnectionString);
            chosenType = type;
            ds = new DataSet();
            da = new OleDbDataAdapter();
            //dt = new DataTable();
        }

        /// <summary>
        /// In case you didn't provide a SQL query in InitializeDataAccess() method.
        /// </summary>
        /// <param name="Query"></param>
        public int SaveChanges(string Query, CommandType cmdType = CommandType.Text)
        {
            cmd.CommandText = Query;
            cmd.CommandType = cmdType;
            using (conn)
            {
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
        }

        /// <summary>
        /// provides a straightforward query execution IF you provided a SQL query during InitializeDataAccess() method. Returns number of rows affected.
        /// </summary>
        /// <returns>int</returns>
        public int SaveChanges(CommandType cmdType = CommandType.Text)
        {
            cmd.CommandType = cmdType;
            //cmd.CommandText = Query;
            using (conn)
            {
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
        }

        /// <summary>
        /// Returns first row of the first column value within the resultset. Other values w/in the table are ignored. This is only useful if you are using a SQL functions that returns single column like SUM(), COUNT(), MIN(), MAX()
        /// </summary>
        /// <returns></returns>
        public object GetFirstValueInFirstRow(CommandType cmdType = CommandType.Text)
        {
            cmd.CommandType = cmdType;
            using (conn)
            {
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
        }

        /// <summary>
        /// Returns first row of the first column value within the resultset. Other values w/in the table are ignored. This is only useful if you are using a SQL functions that returns single column like SUM(), COUNT(), MIN(), MAX()
        /// </summary>
        /// <returns></returns>
        public object GetFirstValueInFirstRow(string ScalarQuery, CommandType cmdType = CommandType.Text)
        {
            cmd.CommandText = ScalarQuery;
            cmd.CommandType = cmdType;
            using (conn)
            {
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
        }


        /// <summary>
        /// returns a table version of DataSet
        /// </summary>
        /// <param name="tableIndex"></param>
        /// <returns>DataTable</returns>
        public DataTable getDataTable(int tableIndex = 0, CommandType cmdType = CommandType.Text)
        {
            cmd.CommandType = cmdType;
            da.SelectCommand = cmd;

            try
            {
                da.Fill(ds);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return ds.Tables[tableIndex];
        }

        /// <summary>
        /// returns a table version of DataSet
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable getDataTable(string SelectQuery)
        {
            cmd.CommandText = SelectQuery;
            da.SelectCommand = cmd;
            try
            {
                da.Fill(ds);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            CheckForRows(ds.Tables[0].Rows.Count);
            return ds.Tables[0];
        }

        /// <summary>
        /// returns a table version of DataSet
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable getDataTable(int tableIndex, string SelectQuery, CommandType cmdType = CommandType.Text)
        {
            cmd.CommandText = SelectQuery;
            cmd.CommandType = cmdType;
            da.SelectCommand = cmd;
            try
            {
                da.Fill(ds);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            CheckForRows(ds.Tables[tableIndex].Rows.Count);
            return ds.Tables[tableIndex];
        }

        /// <summary>
        /// Gets a set of Tables involved during the query
        /// </summary>
        /// <param name="SelectQuery"></param>
        /// <returns></returns>
        public DataSet getDataSet(string SelectQuery)
        {
            cmd.CommandText = SelectQuery;
            da.SelectCommand = cmd;
            try
            {
                da.Fill(ds);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return ds;
        }

        /// <summary>
        /// Gets a set of Tables involved during the query
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet getDataSet()
        {
            da.SelectCommand = cmd;
            try
            {
                da.Fill(ds);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return ds;
        }
    }
}
