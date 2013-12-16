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
            if(ClassList.SelectedNode.Level==0){
                sl.loadGroup(DataList, (string)ClassList.SelectedNode.Tag);
            }else{
                sl.loadSubject(DataList, (string)ClassList.SelectedNode.Tag);
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

        //editieren einer Zeile - Datagrid
        private void DataList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string txt = (string)DataList.CurrentCell.FormattedValue;
            int id = (int)DataList.CurrentRow.Cells[0].Value;
            string query = "UPDATE personen SET id_Schüler=" + DataList.CurrentRow.Cells[0].Value + ", Vorname='" + DataList.CurrentRow.Cells[1].Value + "', Nachname='" + DataList.CurrentRow.Cells[2].Value + "' WHERE id_Schüler=" + id;
            DataBase.update(query);
        }
        
        //hinzufügen einer Zeile - Datagrid
        private void DataList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow row = DataList.Rows[DataList.Rows.Count - 1];
           
            string vn = row.Cells[0].EditedFormattedValue.ToString();
            string nn ="";
            if(row.Cells.Count>1){
                nn = row.Cells[1].EditedFormattedValue.ToString();
            }
            if (vn != "" && nn != "")
            {
                Student newStudent = new Student((string)row.Cells[1].EditedFormattedValue, "nachname");
                newStudent.AddStudentToDB();
                newStudent.AddStudentToGroup(Convert.ToInt32(ClassList.SelectedNode.Tag));
            }

        }

        private void btnGesamt_Click(object sender, EventArgs e)
        {
            if(ClassList.SelectedNode.Level==1){
                Form_GegenstandGesamtAnsicht newClass = new Form_GegenstandGesamtAnsicht((string)ClassList.SelectedNode.Tag); 
            }else{
                MessageBox.Show("Keine Gruppe ausgewählt");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmStudentImport form = new frmStudentImport();
            form.ShowDialog();
        }
    }
}
