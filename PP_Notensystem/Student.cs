using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP_Notensystem
{
    public class Student : Person
    {

    #region Konstruktoren
        /*
        public Student()
        {
            base.IsTeacher = false;
        }
        */
        /// <param name="newFirstName">Vorname der Person</param>
        /// <param name="newLastName">Nachname der Person</param>
        public Student(string newFirstName, string newLastName)
        : base(newFirstName, newLastName)
        {
            base.IsTeacher = false;
        }


        /// <param name="newFirstName">Vorname der Person</param>
        /// <param name="newLastName">Nachname der Person</param>
        /// <param name="newPersID">ID vom Datensatz der Person</param>
        public Student(string newFirstName, string newLastName, int newPersID)
         :base(newFirstName,newLastName,newPersID)
        {
            base.IsTeacher = false;
        }

    #endregion


    #region Methoden

        //Fügt den Schüler hinzu
        private static void AddStudentToGroup(int funcGroupID, int funcStudentID)
        {
            if (this.funcStudentID == 0)
            {
                throw new Exception("es existiert kein Schüler mit PK 0 und kann deswegen nicht zur gruppe hinzugefügt werden")
            }
            string Insert = "INSERT INTO  gruppeschueler (id_Gruppe ,id_Schueler) VALUES (" + funcGroupID + ", " + funcStudentID + ")";
            DataBase.insert(Insert);
        }

        /// <summary>
        /// ügt den Schüler zur Gruppe hinzu
        /// </summary>
        /// <param name="funcGroupID">FK der Gruppe</param>
        public void AddStudentToGroup(int funcGroupID)
        {
            if (this.PersID == 0)
            {
                throw new Exception("es existiert kein Schüler mit PK 0 und kann deswegen nicht zur gruppe hinzugefügt werden");                
            }
            AddStudentToGroup(funcGroupID, this.PersID);
            
        }
    #endregion
    }
}
