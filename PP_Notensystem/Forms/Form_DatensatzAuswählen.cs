using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PP_Notensystem.Forms
{
    public partial class Form_DatensatzAuswählen : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newWhereSelect">School = s_Description, Subject = s_Description</param>
        /// <param name="newDataArt"></param>
        public Form_DatensatzAuswählen(string newWhereSelect, DataArt newDataArt)
        {
            this.WhereSelect = newWhereSelect;
            InitializeComponent();
            this.DataArtZumAuswählen = newDataArt;
            Refresh(this.DataArtZumAuswählen);
        }


    #region MEmber

        public enum DataArt
        {
            SchoolClass,
            SchoolSubject           
        }


        DataTable _TableData = new DataTable();
        public DataTable TableData { 
            get{return _TableData; } 
            set{_TableData = value;}
        }
        public DataArt DataArtZumAuswählen { get; set; }

        public int SelectedID { get; set; }
        public string WhereSelect { get; set; }

        //Die ID Spalte muss immr im INDEX 0 sein wird in der Oberfläche nicht angezeigt
        private string IDCollumName = "ID";

    #endregion


    #region Methoden
        private void Refresh(DataArt funArt)
        {

            switch (funArt)
            {
                case DataArt.SchoolClass:
                    RefreshSchoolClass();
                    break;
                case DataArt.SchoolSubject:
                    RefreshScoolSubject();
                    break;

            }

            this.GridData.MultiSelect = false;
            this.GridData.DataSource = _TableData;
            this.GridData.Columns[IDCollumName].Visible = false;
           
        }

        /// <summary>
        /// School
        /// </summary>
        private void RefreshSchoolClass()
        {
            //string selClass = "SELECT id_Klasse as " + IDCollumName + " , s_Description, dt_Beginn, dt_Ende, n_Turnus From klasse Where s_Description LIKE '" + this._ClassDescription + "'";
            
            string selClass = "SELECT id_Klasse as " + IDCollumName + " , s_Description, dt_Beginn, dt_Ende, n_Turnus From klasse " + this.WhereSelect ;
            IDataReader Reader = DataBase.select(selClass);
            using (Reader)
            {

                _TableData.Load(Reader);

            }
            _TableData.Columns[1].ColumnName = "Name";
            _TableData.Columns[2].ColumnName = "Beginn";
            _TableData.Columns[3].ColumnName = "Ende";
            _TableData.Columns[4].ColumnName = "Turnus";
           

        }

        /// <summary>
        /// Subject
        /// </summary>
        private void RefreshScoolSubject()
        {
            string selClass = "SELECT id_unterrichstfach as " + IDCollumName + " , s_Description From unterrichstfach " + this.WhereSelect;
            IDataReader Reader = DataBase.select(selClass);
            using (Reader)
            {

                _TableData.Load(Reader);

            }
            _TableData.Columns[1].ColumnName = "Name";
           

         }

    #endregion

        private void btnSelectData_Click(object sender, EventArgs e)
        {
            if (GridData.Columns[this.IDCollumName].Index == 0)
            {
                if (GridData.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Wähle zuerst ein Klasse aus indem du auf das graue Feld links vom Klassenamen klickst",
                        string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewRow row = GridData.SelectedRows[0];
                    this.SelectedID = (int)row.Cells[0].Value;
                    this.Close();
                }
            }
            else
            {
                throw new ArgumentException("Die ID Collum hat nicht denn Index 0 im Datagrid (erste Stelle)");
            }
        }
    }
}
