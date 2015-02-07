using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessCentralization
{
    /// <summary>
    /// This class is intended for a more encapsulated approach version of BaseDataAccess and more automated processes. For example, you can already use stored procedures with ease by just naming the stored procedure in string.
    /// </summary>
    public class BaseDataAccessTemplates : BaseDataAccess
    {
        public BaseDataAccessTemplates(string GlobalConnectionString)
        {
            this.GlobalConnectionString = GlobalConnectionString;
        }

        /// <summary>
        /// Automates Stored Procedure. If the Stored Procedure has parameters, use this one. This has no return value
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="providerType"></param>
        /// <param name="parameterList"></param>
        public void AutomateStoredProcedure<T>(string procedureName, ProviderType providerType, Dictionary<String, T> parameterList)
        {
            InitializeDataAccess(procedureName, providerType);
            foreach (KeyValuePair<String, T> item in parameterList)
            {
                CreateCommandParameters(item.Key, item.Value);
            }
            SaveChanges(CommandType.StoredProcedure);
        }

        /// <summary>
        /// Automates Stored Procedure. If the Stored Procedure has parameters, use this one. Returns a value explicitly.
        /// </summary>
        /// <param name="procedureName">name of the Stored Procedure</param>
        /// <param name="providerType">Provider type you used in your database</param>
        public T AutomateStoredProcedure<T>(string procedureName, ProviderType providerType)
        {
            InitializeDataAccess(procedureName, ProviderType.SqlClient);
            var proc_retValue = CreateCommandParametersExplicit("RetVal", typeCastDbType(typeof(T)), ParameterDirection.ReturnValue);
            SaveChanges(CommandType.StoredProcedure);
            return (T) proc_retValue.Value;
        }

        /// <summary>
        /// Automates Stored Procedure. If the Stored Procedure has parameters, use this one. The return value can be casted explicitly.
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="providerType"></param>
        /// <param name="parameterList"></param>
        public T AutomateStoredProcedure<T>(string procedureName, ProviderType providerType, Dictionary<string, object> parameterList)
        {
            InitializeDataAccess(procedureName, ProviderType.SqlClient);
            foreach (KeyValuePair<string, object> item in parameterList)
            {
                CreateCommandParameters(item.Key, item.Value); //ex. "**Column name**, **Row value**"
            }
            var proc_retValue = CreateCommandParametersExplicit("RetVal", typeCastDbType(typeof (T)), ParameterDirection.ReturnValue);

            SaveChanges(CommandType.StoredProcedure);
            return (T) proc_retValue.Value;
        }

        /// <summary>
        /// for use of casting in AutomateStoredProcedure
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        private SqlDbType typeCastDbType(Type T)
        {
            SqlDbType sqlType = SqlDbType.Int;
            
            if (T == typeof(int))
                sqlType=SqlDbType.Int;
            else if (T == typeof(String))
                sqlType = SqlDbType.NVarChar;

            return sqlType;
        }
    }
}
