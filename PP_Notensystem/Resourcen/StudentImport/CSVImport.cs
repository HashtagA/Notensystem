using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using PP_Notensystem;
using PP_Notensystem.Forms;
using System.Windows.Forms;

namespace PP_Notensystem.StudentImport
{
    public class CSVStudentImport
    {
    #region Konstruktoren

        public CSVStudentImport(string newPfad)
        {
            //Connect
            //this._mainDB = new DataBase("192.168.28.130", 3306, "Hashtag", "Hashtag", "notensystem");
            //this._mainDB = new DataBase("192.168.28.130", 3306, "test1", "test", "cdcol");
            //_mainDB.connect();

            StreamReader strStudents = new StreamReader(newPfad);

            //Alle schüler der Liste hinzufügen
            while (strStudents.EndOfStream == false)
            {
                string StudentString = strStudents.ReadLine();
                string[] StudentSplit = StudentString.Split(new Char[] { ';' });
                Student Student = new Student(StudentSplit[2],StudentSplit[1],Convert.ToInt32(StudentSplit[0].Replace("-", "")));

                this._ImportStudents.Add(Student);
            }

            

        }
      
    #endregion

    #region Members

        /// <summary>
        /// Liste mit den Schülern die Importiert bzw der Guppe zugehört werden müssen
        /// </summary>
        public List<Student> ImportStudents
        {
            get { return _ImportStudents; }
            set { _ImportStudents = value; }
        }

        /// <summary>
        /// Name der Klasse
        /// </summary>
        public string SchoolClassName { get; set; }
        /// <summary>
        /// ID der Klasse
        /// </summary>
        public int SchoolClassID { get; set; }

        /// <summary>
        /// Name der Gruppe
        /// </summary>
        public string SchoolGroupName { get; set; }
        /// <summary>
        /// ID der Gruppe
        /// </summary>
        public int SchoolGroupID { get; set; }
        
        /// <summary>
        /// Name des Faches
        /// </summary>
        public string SchoolSubjectName { get; set; }
        /// <summary>
        /// ID des Faches
        /// </summary>
        public int SchoolSubjectID { get; set; }

        private List<Student> _ImportStudents = new List<Student>();
        
    #endregion

    #region Methoden

        public void ValidateClassSubject()
        {
            string selClass = "SELECT * FROM klasse WHERE KlassenName LIKE '" + this.SchoolClassName + "'";
            
            IDataReader DataReadClass = DataBase.select(selClass);
            DataTable tblClass = new DataTable("klasse");
            tblClass.Load(DataReadClass);

            Form_DatensatzAuswählen auswählen = new Form_DatensatzAuswählen("Where KlassenName LIKE '" + this.SchoolClassName + "'", Form_DatensatzAuswählen.DataArt.SchoolClass);
            //auswählen.ShowDialog();
            auswählen.ShowDialog();
            if(auswählen.DialogResult == DialogResult.OK)
            {
                this.SchoolClassID = auswählen.SelectedID;

                auswählen = new Form_DatensatzAuswählen("WHERE Beschreibung LIKE '" + this.SchoolSubjectName + "'", Form_DatensatzAuswählen.DataArt.SchoolSubject);
                auswählen.ShowDialog();
                if (auswählen.DialogResult == DialogResult.OK)
                {
                    this.SchoolSubjectID = auswählen.SelectedID;

                    string InsertGroup = "Insert into gruppe (Beschreibung, id_Unterrichstfach , id_Klasse) values  ('"
                        + this.SchoolGroupName + "', " + this.SchoolSubjectID.ToString() + ", " + this.SchoolClassID + ")";

                    DataBase.insert(InsertGroup);

                    //Schüler werden zur Gruppe hinzugefügt, falls nicht vorhanden werden sie in die DB geschrieben
                    AddStudentsToDBToGroup();
                }
                else
                {
                    MessageBox.Show("Es wurde keine Gruppe importiert",string.Empty,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            
          

            
        }

        private void AddStudentsToDBToGroup()
        {
           //Group ID herausfinden
            ////////////////////
            DataTable tblGroup = new DataTable();
            string selGroup = "SELECT id_Gruppe from Gruppe WHERE Beschreibung LIKE '" + this.SchoolGroupName + "'" +
                                    " AND id_Unterrichstfach = " + this.SchoolSubjectID.ToString() +
                                    " AND id_Klasse = " + this.SchoolClassID;
            IDataReader Reader = DataBase.select(selGroup);
            using (Reader)
            {

                tblGroup.Load(Reader);
                this.SchoolGroupID = Convert.ToInt32(tblGroup.Rows[0][0]);

            }

            //Schüler Hinzufügen
            /////////////////
            foreach (Student AddStudent in _ImportStudents)
            {
               

                AddStudent.PersID = AddStudent.GetPersonID(AddStudent.FirstName, AddStudent.LastName);
                //Wenn der Student noch nicht in der DB existiert wird er hinzugefügt
                if (AddStudent.PersID == 0)
                {
                    AddStudent.AddPerson();
                }

                AddStudent.AddStudentToGroup(this.SchoolGroupID);


                

            }
        }

    #endregion  




    }
}
