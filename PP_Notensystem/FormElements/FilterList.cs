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
        public static void loadSelection(TreeView container, DataBase db)
        {
            //Klassen hinzufügen
            IDataReader classes = db.select("SELECT * FROM klasse");
            List<TreeNode> nodes = new List<TreeNode>();
            container.Nodes.Clear();

            using (classes){
                while (classes.Read()){
                    TreeNode added = new TreeNode(classes.GetString(1));
                    added.Name = classes.GetInt32(0).ToString();
                    nodes.Add(added);
                }
            }
            classes.Close();

            //Gruppen und Unterrichtsfächer hinzufügen
            string query = "SELECT * FROM gruppe g JOIN unterrichstfach uf ON(g.id_Unterrichstfach=uf.id_Unterrichstfach) ";
            IDataReader groups = db.select(query);
            using (groups){
                while (groups.Read()){
                    foreach(TreeNode n in nodes){
                        if (n.Name == groups.GetInt32(3).ToString()){
                            n.Nodes.Add(new TreeNode(groups.GetString(6)+" - "+groups.GetString(1)));
                        }
                    }
                }
            }
            groups.Close();

            container.Nodes.AddRange(nodes.ToArray());
        }
    }
}
