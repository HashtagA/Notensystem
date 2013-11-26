using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PP_Notensystem.FormElements
{
    class StudentList
    {
        public DataBase database;

        public StudentList(DataBase db){
            database = db;
        }

        public void loadClass(DataGridView list, string name){
            DataTable data = new DataTable();
            list.Columns.Clear();
            IDataReader students = database.select("SELECT s_Vorname AS Vorname, n_Nachname AS Nachname FROM personen");
            using (students){
                data.Load(students);
                list.DataSource = data;
            }
        }
        public void loadClass(DataGridView list, string name, string gruppe)
        {
            
        }
        public void loadClass(DataGridView list, string name, string gruppe, string unterrichtsfach)
        {
            
        }
    }
}
