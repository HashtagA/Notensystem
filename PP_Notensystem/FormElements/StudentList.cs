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

        public void loadGroup(DataGridView list, object name){
            DataTable data = new DataTable();
            list.Columns.Clear();
            IDataReader students = DataBase.select("SELECT p.s_Vorname AS Vorname, p.n_Nachname AS Nachname FROM personen p JOIN gruppeschueler gs ON(gs.id_Schueler=p.id_Schüler) JOIN gruppe g ON(gs.id_Gruppe=g.id_Gruppe) JOIN klasse k ON(k.id_Klasse=g.id_Klasse) WHERE k.id_Klasse=" + name);
            using (students){
                data.Load(students);
                list.DataSource = data;
            }


        }
        public void loadSubject(DataGridView list, string name)
        {
            DataTable data = new DataTable();
            list.Columns.Clear();
            IDataReader students = DataBase.select("SELECT p.s_Vorname AS Vorname, p.n_Nachname AS Nachname FROM personen p JOIN gruppeschueler gs ON(gs.id_Schueler=p.id_Schüler) WHERE gs.id_Gruppe=" + name);
            using (students)
            {
                data.Load(students);
                list.DataSource = data;
            }


        }
    }
}
