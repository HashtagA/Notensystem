using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PP_Notensystem.FormElements
{
    class StudentList
    {
        public DataBase database;

        public StudentList(DataBase db){
            database = db;
        }

        public void loadClass(DataGridView list, string name){
            DataTable data = new DataTable();
            IDataReader students = database.select("SELECT * FROM personen");

            list.DataSource = data;

            
            /*IDataReader classes = db.select("SELECT * FROM klasse");
            List<TreeNode> nodes = new List<TreeNode>();
            container.Nodes.Clear();

            using (classes)
            {
                while (classes.Read())
                {
                    TreeNode added = new TreeNode(classes.GetString(1));
                    added.Name = classes.GetInt32(0).ToString();
                    nodes.Add(added);
                }
            }
            classes.Close();
            container.Nodes.AddRange(nodes.ToArray());*/
        }
        public void loadClass(DataGridView list, string name, string gruppe)
        {
            
        }
        public void loadClass(DataGridView list, string name, string gruppe, string unterrichtsfach)
        {
            
        }
    }
}
