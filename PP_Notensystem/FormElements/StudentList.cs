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

        public void loadGroup(DataGridView list, string group){
            DataTable data = new DataTable();
            list.Columns.Clear();
            IDataReader students = DataBase.select("SELECT p.s_Vorname AS Vorname, p.n_Nachname AS Nachname FROM gruppe g JOIN gruppeschueler gs ON(gs.id_Gruppe=g.id_Gruppe) JOIN personen p ON(gs.id_Schueler=p.id_Schüler) WHERE g.id_Gruppe='" + group + "'");
            using (students){
                data.Load(students);
                list.DataSource = data;
            }
        }
        public void loadClass(DataGridView list, string cls){
            DataTable data = new DataTable();
            list.Columns.Clear();
            IDataReader students = DataBase.select("SELECT s_Vorname AS Vorname, n_Nachname AS Nachname FROM personen");
            using (students)
            {
                data.Load(students);
                list.DataSource = data;
            }
        }
    }
}
