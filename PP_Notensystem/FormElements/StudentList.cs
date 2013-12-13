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
        private DataTable data = new DataTable();

        public StudentList(){
            
        }

        public void loadGroup(DataGridView list, object id){
            IDataReader students = DataBase.select("SELECT p.id_Schüler AS id, p.Vorname, p.Nachname FROM personen p JOIN gruppeschueler gs ON(gs.id_Schueler=p.id_Schüler) JOIN gruppe g ON(gs.id_Gruppe=g.id_Gruppe) JOIN klasse k ON(k.id_Klasse=g.id_Klasse) WHERE k.id_Klasse=" + id);
            doQuery(list, students);
        }
        public void loadSubject(DataGridView list, string id)
        {
            IDataReader students = DataBase.select("SELECT p.id_Schüler AS id, p.Vorname, p.Nachname FROM personen p JOIN gruppeschueler gs ON(gs.id_Schueler=p.id_Schüler) WHERE gs.id_Gruppe=" + id);
            doQuery(list, students);
        }
        public void doQuery(DataGridView list, IDataReader reader)
        {
            data = new DataTable();
            list.Columns.Clear();
            using (reader)
            {
                data.Load(reader);
                list.DataSource = data;
            }
            list.Columns[0].Visible = false;
        }
    }
}
