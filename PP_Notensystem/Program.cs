using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PP_Notensystem.Forms;

namespace PP_Notensystem
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Hauptmaske());
            //Application.Run(new StudentImport.frmStudentImport(new DataBase("192.168.28.130", 3306, "Hashtag", "Hashtag", "notensystem")));
            //Application.Run(new addClassForm());
            //Application.Run( new Form_SchullKlasseAuswählen(new DataBase("192.168.28.130", 3306, "Hashtag", "Hashtag", "notensystem"),"5aTIX"));
       
            //Application.Run( new Form_SchullKlasseAuswählen("5aTIX"));
        }
    }
}
