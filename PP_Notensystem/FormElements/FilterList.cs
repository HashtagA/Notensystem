using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PP_Notensystem.FormElements
{
    static class FilterList
    {
        public static void loadSelection(TreeView container, DataBase db){
            IDataReader classes = db.select("SELECT * FROM klasse");
            /*while(classes.Read()){
                container.Nodes.Add(classes.GetString(1));
            }*/
        }
    }
}
