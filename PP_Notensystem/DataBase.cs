using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BS2DB;

namespace PP_Notensystem
{
    public static class DataBase
    {
        public static IDbConnection dbCon;
        //public static DBHelper.DBTransaction dbTrans;
        public static string id { get; set; }
        private static int port { get; set; }
        private static string user { get; set; }
        private static string pwd { get; set; }
        private static string db { get; set; }

        public static void initialize(string idArg, int portArg, string userArg, string pwdArg, string dbArg){
            id = idArg;
            port = portArg;
            user = userArg;
            pwd = pwdArg;
            db = dbArg;
            connect();
        }

        public static void connect()
        {
            try
            {
                if (dbCon == null)
                {
                    dbCon = DBHelper.GetMySQLDBConnection(id, port, user, pwd, db);
                    dbCon.Open();
                    //dbTrans = DBHelper.GetTransaction(dbCon, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void disconnect()
        {
            dbCon.Close();
        }
        public static void reconnect() {
            dbCon = DBHelper.GetMySQLDBConnection(id, port, user, pwd, db);
            dbCon.Close();
            dbCon.Open();
        }
        public static object insert(string query)
        {
            return DBHelper.ExecuteScalarGetInsertedID(dbCon, query);
        }
        public static IDataReader select(string query)
        {
            try{
                return DBHelper.ExecuteReader(dbCon, query);
            }catch(Exception e){
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static void update(string query)
        {
            try{
                DBHelper.ExecuteNonQuery(dbCon, query);
            }catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }
        public static IDataReader getClasses(){
            return DataBase.select("SELECT * FROM klasse");
        }
        public static IDataReader getSubjects()
        {
            return DataBase.select("SELECT * FROM unterrichstfach");
        }
    }
}
