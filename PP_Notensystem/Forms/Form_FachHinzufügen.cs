using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PP_Notensystem
{
    public partial class addSubject : Form
    {

        String tmpGroupe;

        public addSubject()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public SchoolSubject createSchoolSubject()
        {
            SchoolSubject tmpSchoolSubject = new SchoolSubject(txtSubject.Text, tmpGroupe, cBClass.Text);

            return tmpSchoolSubject;
        }

        private void rBN_CheckedChanged(object sender, EventArgs e)
        {
            tmpGroupe = rBN.Text;
        }

        private void rBV_CheckedChanged(object sender, EventArgs e)
        {
            tmpGroupe = rBV.Text;
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            tmpGroupe = rB1.Text;
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            tmpGroupe = rB2.Text;
        }

        private void rBAll_CheckedChanged(object sender, EventArgs e)
        {
            tmpGroupe = rBAll.Text;
        }

        private void cBClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Cl cl = new cl();
            comboBox.DataSource = new List<Person> {new Person{Name = "1"}, new Person{Name = "2"}};
            comboBox.DataBindings.Add("Item", cl, "Person");*/
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
