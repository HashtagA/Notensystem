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
            IDataReader getGroup = DataBase.select("SELECT * FROM Gruppe WHERE id_gruppe =" + id);
            using (getGroup)
            {
                while (getGroup.Read())
                {
                    
                }
            }
        }

        private void dgvGeneralView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
