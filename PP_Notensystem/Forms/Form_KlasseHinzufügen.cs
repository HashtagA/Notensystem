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
    public partial class addClassForm : Form
    {

        int tmpTurnusNumber;

        public addClassForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public SchoolClass CreateSchoolClass()
        {
            SchoolClass tmpClass = new SchoolClass(classNameTextBox .Text, tmpTurnusNumber, turnusStartDatePicker.Value, turnunsEndDatePicker.Value);
  
            return tmpClass;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            tmpTurnusNumber = int.Parse(rb1.Text);
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            tmpTurnusNumber = int.Parse(rb2.Text);
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            tmpTurnusNumber = int.Parse(rb3.Text);
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            tmpTurnusNumber = int.Parse(rb4.Text);
        }

       

    }   
}
