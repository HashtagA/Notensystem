using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PP_Notensystem.FormElements;

namespace PP_Notensystem
{
    public partial class Form_GegenstandGesamtAnsicht : Form
    {
        public Form_GegenstandGesamtAnsicht(string id)
        {
            InitializeComponent();
            
            IDataReader getGroup = DataBase.select("SELECT CONCAT(p.Nachname, ' ', p.Vorname), p.id_Schüler " +
                "FROM Gruppe g JOIN GruppeSchueler gs ON g.id_Gruppe = gs.id_Gruppe " +
                "JOIN Personen p ON gs.id_Schueler = p.id_Schüler " +
                "WHERE gs.id_Gruppe=" + id);



            DataTable table = new DataTable();
            dgvGeneralView.Columns.Clear();
            dgvGeneralView.DataSource = table;

            Dictionary<int, string> studentIDs = new Dictionary<int, string>();

            using (getGroup)
            {

                table.Columns.Add("Schüler", typeof(string));

                while (getGroup.Read())
                {
                    int sid = getGroup.GetInt32(1);
                    string name = getGroup.GetString(0);

                    table.Rows.Add(name);

                    if (!studentIDs.ContainsKey(sid))
                        studentIDs.Add(sid, name);
                }

            }

            Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();

            foreach (int tmpSID in studentIDs.Keys)
            {
                string query = "SELECT pa.Beschreibung AS kind, pe.ErgebnisProz AS result  " +
                   "FROM Personen p JOIN GruppeSchueler gs ON p.id_Schüler = gs.id_Schueler " +
                   "JOIN Gruppe g ON gs.id_Gruppe = g.id_Gruppe " +
                   "JOIN PruefKriterium pk ON g.id_Gruppe = pk.id_Gruppe " +
                   "JOIN PruefHist ph ON pk.id_PruefKriterium = ph.id_PruefKriterium " +
                   "JOIN PruefErgebnis pe ON ph.id_PruefHist = pe.id_PruefHist " +
                   "JOIN PruefArt pa ON pk.id_PruefArt = pa.id_PruefArt " +
                   "WHERE p.id_Schüler =" + tmpSID;
                IDataReader getGrades = DataBase.select(query);

                using (getGrades)
                {
                    while(getGrades.Read()){
                        string kind = getGrades.GetString(0);

                        if (!results.ContainsKey(kind))
                            results.Add(kind, new List<int>());

                        results[kind].Add(getGrades.GetInt16(1));
                    }
                }
            }



            foreach (KeyValuePair<string, List<int>> tmpPair in results)
            {
                int tmpRow = 0;

                DataColumn curCol = table.Columns.Add(tmpPair.Key, typeof(string));

                foreach (int tmpResult in tmpPair.Value)
                {
                    table.Rows[tmpRow][curCol] = tmpResult;

                    tmpRow++;
                }


            }

            /*using (getGrades)
            {
                table.Columns.Add("Art", typeof(string));
               
                while (getGrades.Read())
                {
                    table.Rows.Add(getGroup.GetString(0));
                }

                dgvGeneralView.DataSource = table;
            }*/
            this.Show();
        }

        private void dgvGeneralView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
