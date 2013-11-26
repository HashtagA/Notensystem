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
        public DataBase mainDb;

        public Form_GegenstandGesamtAnsicht()
        {
            InitializeComponent();
            mainDb = new DataBase("192.168.28.130", 3306, "Hashtag", "Hashtag", "notensystem");
        }

        private void dgvGeneralView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
