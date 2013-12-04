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


            DataGridViewTextBoxColumn xy = new System.Windows.Forms.DataGridViewTextBoxColumn();

            xy.HeaderText = "Schüler";
            xy.MinimumWidth = 200;
            xy.Name = "xy";
            xy.ReadOnly = true;
            xy.Width = 250;

            this.dgvGeneralView.Columns.Add(xy);

            IDataReader getGroup = DataBase.select("SELECT CONCAT(p.n_Nachname, ' ', p.s_Vorname)" + 
                "FROM Gruppe g JOIN GruppeSchueler gs ON g.id_gruppe = gs.id_gruppe" +
                "JOIN Personen p ON gs.id_schueler = p.id_schüler WHERE id_gruppe =" + id);

            using (getGroup)
            {
                while (getGroup.Read())
                {
                     string name = getGroup.GetString(0);

                    
                }
            }

           

            

        }

        private void dgvGeneralView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
