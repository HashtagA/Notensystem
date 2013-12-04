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
        private DataGridView list = new DataGridView();
        private DataTable data = new DataTable();
        public StudentList(DataGridView container){
            list = container;
        }

        public void loadGroup(string group){
            IDataReader students = DataBase.select("SELECT p.s_Vorname AS Vorname, p.n_Nachname AS Nachname FROM gruppe g JOIN gruppeschueler gs ON(gs.id_Gruppe=g.id_Gruppe) JOIN personen p ON(gs.id_Schueler=p.id_Schüler) WHERE g.id_Gruppe='" + group + "'");
            fillTable(students);
        }
        public void loadClass(string cls){
            IDataReader students = DataBase.select("SELECT p.s_Vorname AS Vorname, p.n_Nachname AS Nachname FROM gruppe g JOIN gruppeschueler gs ON(gs.id_Gruppe=g.id_Gruppe) JOIN personen p ON(gs.id_Schueler=p.id_Schüler) WHERE g.id_Klasse='" + cls + "'");
            fillTable(students);
        }
        private void fillTable(IDataReader reader){
            list.Columns.Clear();
            using (reader){
                data.Load(reader);
                list.DataSource = data;
            }
            
        }
        public void sync(){
            DataTable updateDt = data.GetChanges();
            int i = 0;
        }
    }
}
