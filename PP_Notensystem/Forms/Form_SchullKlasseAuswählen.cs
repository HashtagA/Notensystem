using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*
 * Diese Form selektiert alle Klassen anhand einer Bezeichnung (Z.B.) 5aTIX, und man kann dan die Klasse auswählen, die man will
 * da es in einem Jahr gleiche Klassennamen pro Schuljahr geben kann, d.b. man muss seine Klasse anhand des Turnus auswählen oder eine neue hinzufügen
 */

namespace PP_Notensystem.Forms
{
    public partial class Form_SchullKlasseAuswählen : Form
    {
        public Form_SchullKlasseAuswählen(string newClassDescription)
        {
            InitializeComponent();
            this._ClassDescription = newClassDescription;
            _tblSchoolClasses = new DataTable("Klasse " + this._ClassDescription);

            RefreshTable();

            
            this.GridShoolClass.Rows[0].Selected = true;

     

        }

    #region Propertys

        private DataTable _tblSchoolClasses;


        private string _ClassDescription;
        /// <summary>
        /// Name der Klasse (Feld s_Description)
        /// </summary>
        public string ClassDescription
        {
            get { return _ClassDescription; }
            set { _ClassDescription = value; }
        }

        /// <summary>
        /// ID der Klassse die ausgewählt wurde
        /// </summary>
        public int KlassID { get; set; }

         


    #endregion


    #region EventMethoden

        private void btnSelectSchoolKlass_Click(object sender, EventArgs e)
        {
            if (GridShoolClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wähle zuerst ein Klasse aus indem du auf das graue Feld links vom Klassenamen klickst",
                    string.Empty,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            DataGridViewRow row = GridShoolClass.SelectedRows[0];
            this.KlassID = (int)row.Cells[0].Value;
            this.Close();
            }
        }

        private void btnAddSchoolClass_Click(object sender, EventArgs e)
        {
            addClassForm AddClass = new addClassForm();
            RefreshTable();
        }

    #endregion

    #region Methoden

        private void RefreshTable()
        {
            string selClass = "SELECT id_Klasse, s_Description, dt_Beginn, dt_Ende, n_Turnus From klasse Where s_Description LIKE '" + this._ClassDescription + "'";
            IDataReader Reader = DataBase.select(selClass);
            using (Reader)
            {
                
                    _tblSchoolClasses.Load(Reader);
             
            }
            _tblSchoolClasses.Columns[1].ColumnName = "Name";
            _tblSchoolClasses.Columns[2].ColumnName = "Beginn";
            _tblSchoolClasses.Columns[3].ColumnName = "Ende";
            _tblSchoolClasses.Columns[4].ColumnName = "Turnus";
            GridShoolClass.MultiSelect = false;
            GridShoolClass.DataSource = _tblSchoolClasses;


            this.GridShoolClass.Columns["id_Klasse"].Visible = false;

        }

    #endregion

    }
}
