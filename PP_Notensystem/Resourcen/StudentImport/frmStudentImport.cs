using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PP_Notensystem.StudentImport
{
    public partial class frmStudentImport : Form
    {

        #region Propertys

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newDB">DataBase to Connect</param>
        public frmStudentImport()
        {
            InitializeComponent();
            txtPath.Text = "C:\\temp\\5aTIX_GDT_N.csv";
        }


        /// <summary>
        /// Gruppen, Klasse, Fach ermitteln
        /// </summary>
        private void txtPath_TextChanged(object sender, EventArgs e)
        {

            string FileName = Path.GetFileNameWithoutExtension(txtPath.Text);
            string[] FileNameSplit = {"_"};
            if (FileName.Contains('_') && FileName.IndexOf('_') < (FileName.Length-1))
            {
                FileNameSplit = FileName.Split(new Char[] { '_' });            
          
                //Import Klassennamen
                if (FileNameSplit.Length >= 1)
                {
        
                    //StudentImport.SchoolClassName = FileNameSplit[0];
                    txtScholClass.Text = FileNameSplit[0];
                    
                    //Import FachNamen
                    if (FileNameSplit.Length >= 2)
                    {

                        //StudentImport.SubjectName = FileNameSplit[1];
                        txtSubject.Text = FileNameSplit[1];
                        
                        //GruppenNamen
                        if (FileNameSplit.Length >= 3)
                        {
                            txtGrp.Text = FileNameSplit[2];
                        }
                        else
                        {
                            txtGrp.Text = "alle";
                        }
                        
                    }

                }

                
            }


        }

        /// <summary>
        /// Datei auswählen
        /// </summary>
        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.DefaultExt = ".csv";
            opf.Filter = "CSV - Datei (.csv)|*.csv";
            opf.ShowDialog();
            opf.CheckFileExists = true;
            opf.Multiselect = false;
            txtPath.Text = opf.FileName;
        }
        
        private void btnImportStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //IO Exception
                CSVStudentImport Import = new CSVStudentImport(txtPath.Text);
                Import.SchoolClassName = txtScholClass.Text;
                Import.SchoolGroupName = txtGrp.Text;
                Import.SchoolSubjectName = txtSubject.Text;

                Import.ValidateClassSubject();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmStudentImport_Load(object sender, EventArgs e)
        {

        }




    }
}
