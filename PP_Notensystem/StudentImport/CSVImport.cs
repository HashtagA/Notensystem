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
            string test = "SELECT * FROM klasse WHERE s_Description LIKE '" + this.SchoolClassName + "'";
            string selClass = "SELECT * FROM klasse WHERE s_Description LIKE '" + this.SchoolClassName + "'";
            //selClass = "SELECT * FROM klasse";
            IDataReader DataReadClass = DataBase.select(selClass);
            DataTable tblClass = new DataTable("klasse");
            tblClass.Load(DataReadClass);

            Form_DatensatzAuswählen auswählen = new Form_DatensatzAuswählen("Where s_Description LIKE '" + this.SchoolClassName + "'" ,Form_DatensatzAuswählen.DataArt.SchoolClass);
            auswählen.ShowDialog();
            this.SchoolClassID = auswählen.SelectedID;

            auswählen = new Form_DatensatzAuswählen("WHERE s_Description LIKE '" + this.SchoolSubjectName + "'", Form_DatensatzAuswählen.DataArt.SchoolSubject);
            auswählen.ShowDialog();
            this.SchoolSubjectID = auswählen.SelectedID;

            string InsertGroup = "Insert into gruppe (s_Description, id_Unterrichstfach , id_Klasse) values  ('"
                + this.SchoolGroupName + "', " + this.SchoolSubjectID.ToString() + ", " + this.SchoolClassID + ")";

            DataBase.insert(InsertGroup);



            //Form_SchullKlasseAuswählen auswählen = new Form_SchullKlasseAuswählen(this.SchoolClassName);
            //auswählen.ShowDialog();

            //SchoolClassID = auswählen.SelectedKlassID;
            


            /*
            test = string.Empty;
            foreach (DataRow row in tblClass.Rows)
            {
                foreach (DataColumn col in tblClass.Columns)
                {
                    test += row[col].ToString();
                }
                test += "\n";
            }

            test = string.Empty;
            */

            
        }

        private void AddStudentsToDB()
        {
           //Group ID herausfinden
            ////////////////////
            DataTable tblGroup = new DataTable();
            string selGroup = "SELECT id_Gruppe from Gruppe WHERE s_Description LIKE '" + this.SchoolGroupName + "'" +
                                    " AND id_Unterrichstfach = " + this.SchoolSubjectID.ToString() +
                                    " AND id_Klasse = " + this.SchoolClassID;
            IDataReader Reader = DataBase.select(selGroup);
            using (Reader)
            {

                tblGroup.Load(Reader);
                this.SchoolGroupID = Convert.ToInt32(tblGroup.Rows[1][1]);

            }

            //Schüler Hinzufügen
            /////////////////
            foreach (Student AddStudent in _ImportStudents)
            {
                /*/////////////////////////////////////////////////////////////////////////
                 * 
                string selStudentExists = "SELECT id_Schüler From Person WHERE s_Vorname LIKE '" + AddStudent.FirstName + "" + 
                                                    "' AND s_Nachname LIKE '" + AddStudent.LastName + "'";
                DataTable TblStudent = new DataTable();
                Reader = DataBase.select(selStudentExists);
                TblStudent.Load(Reader);
                
                if (TblStudent.Rows.Count > 0)
                {
                    AddStudent.AddPerson();
                    //Die Tabell mit dem so eben hinzugefügten Schüler wieder befüllen
                    Reader = DataBase.select(selStudentExists);
                    TblStudent.Load(Reader);
                }
                 * 
                 * 
                 * 
                */
                ///////////////////////////////////////////////////////////////////////////


                AddStudent.PersID = AddStudent.GetPersonID(AddStudent.FirstName, AddStudent.LastName);
                //Wenn der Student noch nicht in der DB existiert wird er hinzugefügt
                if (AddStudent.PersID == 0)
                {
                    AddStudent.AddPerson();
                }

                AddStudent.AddStudentToGroup(this.SchoolGroupID);


                // + this.SchoolGroupName + "', " + this.SchoolSubjectID.ToString() + ", " + this.SchoolClassID + ")";



                /*SELECT

FROM gruppeschueler gs
	JOIN personen p ON gs.id_Schueler = p.id_Schueler*/
            }
        }

    #endregion  




    }
}
