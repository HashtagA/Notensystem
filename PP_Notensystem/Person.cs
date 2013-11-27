using System;
using System.Collections.Generic;
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
    public class Person
    {

        #region Konstruktoren

        public Person()
        {
        }

        /// <param name="newFirstName">Vorname der Person</param>
        /// <param name="newLastName">Nachname der Person</param>
        public Person(string newFirstName, string newLastName)
        {
            _LastName = newLastName;
            _FirstName = newFirstName;
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

        #region Probertys

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
        /// Id des Datensatzes der Person
        /// </summary>
        public int PersID
        {
            get { return _PersID; }
            set { _PersID = value; }
        }

        /// <summary>
        /// Gibt den Kompleten Namen aus ('Vorname' 'Nachname')
        /// </summary>
        public string CompleteName
        {
            get { return _FirstName + " " + _LastName; }
        }



        #endregion
    }
}
