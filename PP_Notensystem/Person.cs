using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PP_Notensystem
{

    //Florian 19.11
    /*
     * Ich habe eine neue Klasse erstellt die einen Datensatz der Tabelle Person darstellt,     
     * diese hat 3 Eigenschaften int ID, string FirstName, string LastName,     
     * z.B. zum Erstellen eines Arrays mit Schülern oder zum schreiben der Eigenschaft Lehrer
    */
    /// <summary>
    /// Klasse die einen Datensatz der Tabelle Person dagibt
    /// </summary>
    public abstract class Person
    {

     #region Konstruktoren
        /*
        public Person()
        {
            
        }
    */

        /// <param name="newFirstName">Vorname der P_erson</param>
        /// <param name="newLastName">Nachname der Person</param>
        public Person(string newFirstName, string newLastName)
        {
            _LastName = newLastName;
            _FirstName = newFirstName;
            _PersID = GetPersonID(newFirstName, newLastName);
            
        }


        /// <param name="newFirstName">Vorname der Person</param>
        /// <param name="newLastName">Nachname der Person</param>
        /// <param name="newPersID">ID vom Datensatz der Person</param>
        public Person(string newFirstName, string newLastName, int newPersID)
        {
            _PersID = newPersID;
            _LastName = newLastName;
            _FirstName = newFirstName;
        }

        #endregion

     #region Members

        private string _FirstName;
        /// <summary>
        /// Vorname der Person
        /// </summary>
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        /// <summary>
        /// NachName der Person
        /// </summary>
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private int _PersID;
        /// <summary>
        /// Id des Datensatzes der Person (wenn null ist dann existiert die Person noch nicht in der DB)
        /// </summary>
        public int PersID
        {
            get { return _PersID; }
            set { _PersID = value; }
        }

        private bool _IsTeacher;
        /// <summary>
        /// Id des Datensatzes der Person
        /// </summary>
        protected bool IsTeacher
        {
            get { return _IsTeacher; }
            set { _IsTeacher = value; }
        }

        /// <summary>
        /// Gibt den Kompleten Namen aus ('Vorname' 'Nachname')
        /// </summary>
        public string CompleteName
        {
            get { return _FirstName + " " + _LastName; }
        }



        #endregion

    #region Methoden

        /// <summary>
        /// Fügt diese Person zur DB hinzu
        /// </summary>
        public virtual void AddPerson()
        {

            string PersInsert = "INSERT INTO `notensystem`.`personen` (`id_Schüler`, `s_Vorname`, `n_Nachname`, `b_IsLehrer`) " + 
                " VALUES (NULL, '" + _FirstName + "', '" + _LastName + "', '" + _IsTeacher.ToString() + "');";
            _PersID = GetPersonID(_FirstName, _LastName);
            DataBase.insert(PersInsert);

        }

        /// <summary>
        /// Gibt die ID der Person zurück, wenn sie nich in der DB existiert wird 0 zurückgegeben
        /// </summary>
        /// <returns>wenn sie nich in der DB existiert wird 0 zurückgegeben</returns>
        public int GetPersonID(string funcFirstName, string funcLastName)
        {
            string select = "SELECT id_Schüler FROM person WHERE s_Vorname Like '" + funcFirstName + "' " +
                                "AND n_Nachname LIKE '" + funcLastName + "' ";

            DataTable TblStudent = new DataTable();
            IDataReader Reader = DataBase.select(select);
            TblStudent.Load(Reader);
            if (TblStudent.Rows.Count > 0)
                return Convert.ToInt32(TblStudent.Rows[0][0]);
            else
                return 0;
        }

    #endregion
    }



}


