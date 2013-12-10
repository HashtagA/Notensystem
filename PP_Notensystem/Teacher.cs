using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP_Notensystem
{
    class Teacher : Person
    {
    #region Konstruktoren
       /* public Teacher()
        {
            base.IsTeacher = true;
        }
        */
        /// <param name="newFirstName">Vorname der Person</param>
        /// <param name="newLastName">Nachname der Person</param>
        public Teacher(string newFirstName, string newLastName)
        :base(newFirstName,newLastName)
        {
            base.IsTeacher = true;
        }


        /// <param name="newFirstName">Vorname der Person</param>
        /// <param name="newLastName">Nachname der Person</param>
        /// <param name="newPersID">ID vom Datensatz der Person</param>
        public Teacher(string newFirstName, string newLastName, int newPersID)
         :base(newFirstName,newLastName,newPersID)
        {
            base.IsTeacher = true;
        }

     #endregion

     #region Methoden

    #endregion
   
    }
}
