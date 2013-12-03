using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PP_Notensystem.FormElements;
using PP_Notensystem.StudentImport;
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

            if (ClassList.SelectedNode.Level==1){
                sl.loadGroup(DataList, ClassList.SelectedNode.Tag.ToString());
            }else{
                sl.loadClass(DataList, ClassList.SelectedNode.Tag.ToString());
            }


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
            frmStudentImport Import = new frmStudentImport();
            Import.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tmp = ClassList.SelectedNode.Name;
            if (ClassList.SelectedNode.Level == 1)
            {
                Form_GegenstandGesamtAnsicht f = new Form_GegenstandGesamtAnsicht(ClassList.SelectedNode.Name);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROOOOOR");
            }
        }
    }
}
