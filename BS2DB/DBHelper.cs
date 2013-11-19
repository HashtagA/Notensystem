using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BS2DB
{
  public static class DBHelper
  {
    #region Inner-Classes

    public class DBTransaction
      : IDisposable
    {
      #region Members

      protected IDbConnection dbCon;
      protected IDbTransaction transaction;

      #endregion

      public DBTransaction(IDbConnection dbCon, bool beginTransaction)
      {
        if (dbCon == null)
          throw new ArgumentNullException();

        this.dbCon = dbCon;

        if (beginTransaction)
          BeginTransaction();
      }

      public void BeginTransaction()
      {
        if (transaction == null)
          transaction = dbCon.BeginTransaction();
      }

      public void Commit()
      {
        if (transaction != null)
        {
          transaction.Commit();

          transaction = null;
        }
      }

      public void Rollback()
      {
        if (transaction != null)
        {
          transaction.Rollback();

          transaction = null;
        }
      }

      public void Dispose()
      {
        Rollback();
      }
    }

    #endregion
    
    public static DBTransaction GetTransaction(IDbConnection dbCon, bool beginTransaction)
    {
      return new DBTransaction(dbCon, beginTransaction);
    }

    public static object ExecuteScalar(IDbConnection dbCon, string sql)
    {
      if ((dbCon == null) || (sql == null))
        throw new ArgumentNullException();

      IDbCommand cmd = dbCon.CreateCommand();

      cmd.Connection = dbCon;

      cmd.CommandText = sql;

      return cmd.ExecuteScalar();
    }

    public static object ExecuteScalarGetInsertedID(IDbConnection dbCon, string sql)
    {
      return DBHelper.ExecuteScalar(dbCon, sql + "; SELECT last_insert_id();");
    }

    public static IDataReader ExecuteReader(IDbConnection dbCon, string sql)
    {
      if ((dbCon == null) || (sql == null))
        throw new ArgumentNullException();

      IDbCommand cmd = dbCon.CreateCommand();

      cmd.Connection = dbCon;

      cmd.CommandText = sql;

      return cmd.ExecuteReader();
    }

    public static int ExecuteNonQuery(IDbConnection dbCon, string sql)
    {
      if ((dbCon == null) || (sql == null))
        throw new ArgumentNullException();

      IDbCommand cmd = dbCon.CreateCommand();

      cmd.Connection = dbCon;

      cmd.CommandText = sql;

      return cmd.ExecuteNonQuery();
    }

    public static string ToConnectionString(string ip, int port, string user, string pwd, string database)
    {
      string conStr = "server=" + ip + ";" +
                      "port=" + port + ";" +
                      "database=" + database + ";";

      if ((user != null) && (user != string.Empty))
      {
        conStr += "User Id=" + user + ";";

        if ((pwd != null) && (pwd != string.Empty))
          conStr += "password=" + pwd + ";";
      }

      return conStr.Substring(0, conStr.Length - 1);
    }

    public static IDbConnection GetMySQLDBConnection(string ip, int port, string user, string pwd, string database)
    {
      return new MySqlConnection(ToConnectionString(ip, port, user, pwd, database));
    }
  }
}
