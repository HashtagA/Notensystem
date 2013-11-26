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
        private string id;
        private int port;
        private string user;
        private string pwd;
        private string db;

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
                using (IDataReader dbReader = DBHelper.ExecuteReader(dbCon, query)){
                    return dbReader;
                }
            }catch(Exception e){
                MessageBox.Show(Form_Hauptmaske.ActiveForm, e.Message);
                return null;
            }
        }
    }
}
