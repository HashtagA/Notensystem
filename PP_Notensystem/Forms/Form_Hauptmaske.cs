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
    public partial class Form_Hauptmaske : Form
    {
        public Form_Hauptmaske()
        {
            InitializeComponent();
            DataBase.initialize("192.168.28.130", 3306, "Hashtag", "Hashtag", "notensystem");
            FilterList.loadSelection(ClassList);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StudentList sl = new StudentList();
            sl.loadGroup(DataList, ClassList.SelectedNode.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addClassForm acf = new addClassForm();

            if (acf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               SchoolClass newClass = acf.CreateSchoolClass(); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSubject aS = new addSubject();

            aS.ShowDialog(); 

            /*if (aS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              
            }*/


        }

        /// <summary>
        /// CSV Import
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            StudentImport.frmStudentImport ImportForm = new StudentImport.frmStudentImport(mainDb);
        }
    }
}
