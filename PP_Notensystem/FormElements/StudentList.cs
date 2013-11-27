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

        public StudentList(){
            
        }

        public void loadGroup(DataGridView list, string name){
            DataTable data = new DataTable();
            list.Columns.Clear();
            IDataReader students = DataBase.select("SELECT s_Vorname AS Vorname, n_Nachname AS Nachname FROM personen");
            using (students){
                data.Load(students);
                list.DataSource = data;
            }


        }
        public void loadSubject(DataGridView list, string name, string unterrichtsfach)
        {
            
        }
    }
}
