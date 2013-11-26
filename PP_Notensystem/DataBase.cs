using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BS2DB;

namespace PP_Notensystem
{
    public class DataBase
    {
        public IDbConnection dbCon;
        public DBHelper.DBTransaction dbTrans;
        private string id {get;set;}
        private int port { get; set; }
        private string user { get; set; }
        private string pwd { get; set; }
        private string db { get; set; }

        public DataBase(string idArg, int portArg, string userArg, string pwdArg, string dbArg){
            id = idArg;
            port = portArg;
            user = userArg;
            pwd = pwdArg;
            db = dbArg;
            connect();
        }

        public void connect()
        {
            try
            {
                if (dbCon == null)
                {
                    dbCon = DBHelper.GetMySQLDBConnection(id, port, user, pwd, db);
                    dbCon.Open();
                    dbTrans = DBHelper.GetTransaction(dbCon, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disconnect()
        {
            dbCon.Close();
        }
        public void reconnect() {
            dbCon = DBHelper.GetMySQLDBConnection(id, port, user, pwd, db);
            dbCon.Close();
            dbCon.Open();
        }
        public void insert(string query)
        {
            using (dbTrans){
                DBHelper.ExecuteScalarGetInsertedID(dbCon, query);
            }
        }
        public IDataReader select(string query)
        {
            try{
                return DBHelper.ExecuteReader(dbCon, query);
            }catch(Exception e){
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
