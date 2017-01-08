using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMELINE.Universal_Statics;

namespace TIMELINE.Manager.Database
{
    struct DataBaseHelper
    {
        public struct StoreProcedure
        {
            public static DataSet getData(Dictionary<string, object> dicValue, string spKey)
            {
                SqlConnection sqlConn = new SqlConnection(Constants.DbConstant.connectionString);
                string spName = Constants.getStoreProcedureName(spKey);
                SqlCommand sqlcomm = new SqlCommand();

                sqlcomm.Connection = sqlConn;
                using (sqlConn)
                {
                    try
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            // This will be your input parameter and its value
                            foreach (KeyValuePair<string, object> itm in dicValue)
                            {
                                sqlcomm.Parameters.AddWithValue(itm.Key, itm.Value);
                            }
                            sqlcomm.CommandText = spName;
                            da.SelectCommand = sqlcomm;
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;

                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            return ds;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error: " + ex.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
                return new DataSet();

            }

        }

        public struct QueryTableOrView
        {
            public static DataSet executeQuery(Dictionary<string, object> dicValue, string tableOrViewKey, string queryType)
            {
                SqlConnection connection = new SqlConnection(Constants.DbConstant.connectionString);
                string query = generateQuery(queryType, Constants.getTableOrViewName(tableOrViewKey), dicValue);
                // Creates a SQL connection
                using (connection)
                {
                    connection.Open();
                    DataSet ds = new DataSet();
                    // Creates a SQL command
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        DataTable table = new DataTable();
                        table.Load(cmd.ExecuteReader());
                        ds.Tables.Add(table);
                    }
                    connection.Close();
                    return ds;
                }
            }

            private static string generateQuery(string queryType, string tableOrViewName, Dictionary<string, object> parameters)
            {
                switch (queryType)
                {
                    case "SELECT":
                        string query = "SELECT * FROM " + tableOrViewName;
                        //add the parameter as its parameters 
                        return query;
                    case "UPDATE":
                        return "";
                    case "DELETE":
                        return "";
                    case "INSERT":
                        return "";

                    default:
                        return "";
                }
            }
        }
    }

}
