﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PP_Notensystem.FormElements;

namespace PP_Notensystem
{
    public partial class Form_Hauptmaske : Form
    {
        public DataBase mainDb;

        public Form_Hauptmaske()
        {
            InitializeComponent();
            mainDb = new DataBase("192.168.28.130", 3306, "Hashtag", "Hashtag", "notensystem");
            FilterList.loadSelection(ClassList, mainDb);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainDb.disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addClassForm acf = new addClassForm();
            acf.Show();
        }
    }
}