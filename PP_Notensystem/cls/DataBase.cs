using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BS2DB;

namespace PP_Notensystem.cls
{
    static class DataBase
    {
        public static IDbConnection dbCon;
        public static DBHelper.DBTransaction dbTrans;
        private static string id = "192.168.28.130";
        private static int port = 3306;
        private static string user = "Hashtag";
        private static string pwd = "Hashtag";
        private static string db = "notensystem";

        public static void connect(){
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
        public static void disconnect(){
            dbCon.Close();
        }
        public static void insert(string query){
            using (dbTrans){
                DBHelper.ExecuteScalarGetInsertedID(dbCon, query);
            }
        }
        /*public string[][] select(string query){
            string[][] output;
            using (IDataReader dbReader = DBHelper.ExecuteReader(dbCon, query)){
                while(dbReader.Read()){
                    for(int i = 0;i<dbReader.FieldCount;i++){
                        if(dbReader.GetType()==string){
                            output[output.Length][i] = dbReader.GetString(0);
                        }else if(dbReader.GetType()==int){
                            
                       }
                    }
                }
                return output;
            }
        }*/
    }
}
