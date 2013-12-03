using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using PP_Notensystem;

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
                Person Pers = new Person();
                string Student = strStudents.ReadLine();
                string[] StudentSplit = Student.Split(new Char[] { ';' });

                Pers.PersID = Convert.ToInt32(StudentSplit[0].Replace("-", ""));
                Pers.FirstName = StudentSplit[2];
                Pers.LastName = StudentSplit[1];

                this._ImportStudents.Add(Pers);
            }

            

        }
      
    #endregion

    #region Probertys


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

        public string SubjectName { get; set; }

        private List<Person> _ImportStudents = new List<Person>();
        /// <summary>
        /// Liste mit den Schülern die Importiert bzw der Guppe zugehört werden müssen
        /// </summary>
        public List<Person> ImportStudents { 
            get{ return _ImportStudents;} 
            set { _ImportStudents = value;}}

    #endregion

    #region Methoden

        public void ValidateClassSubject()
        {
            string test = "SELECT * FROM klasse WHERE s_Description LIKE '" + this.SchoolClassName + "'";
            string selClass = "SELECT * FROM klasse WHERE s_Description LIKE '" + this.SchoolClassName + "'";
            selClass = "SELECT * FROM klasse";
            IDataReader DataReadClass = DataBase.select(selClass);
            DataTable tblClass = new DataTable("klasse");
            tblClass.Load(DataReadClass);


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


            
        }

    #endregion  




    }
}
