using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP_Notensystem
{
    public class SchoolSubject
    {
        #region Members

        private String name;
        private String groupe;
        private String schoolclass; /* TODO: Mit eigen Erstellter Klasse initalisieren */
        #endregion

        public SchoolSubject(String name, String groupe, String schoolclass) /* TODO: Mit eigen Erstellter Klasse initalisieren */
        {
            this.name = name;
            this.groupe = groupe;
            this.schoolclass = schoolclass;
        }
    }
}
