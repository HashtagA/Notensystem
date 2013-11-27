namespace PP_Notensystem
{
    partial class addSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSubject));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbToolTip = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cBClass = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBAll = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rBV = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rBN = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbToolTip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSubject, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cBClass, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btSave, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btCancel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbSubject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbClass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbGroup, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbToolTip
            // 
            this.lbToolTip.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbToolTip, 5);
            this.lbToolTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbToolTip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToolTip.Location = new System.Drawing.Point(3, 0);
            this.lbToolTip.Name = "lbToolTip";
            this.lbToolTip.Size = new System.Drawing.Size(327, 61);
            this.lbToolTip.TabIndex = 1;
            this.lbToolTip.Text = "Bitte geben Sie das hinzuzufügendene Fach sowie die betroffene Klasse ein und wäh" +
    "len Sie anschließend noch die entsprechende Gruppenzuteilung aus:\r\n";
            this.lbToolTip.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSubject, 3);
            this.txtSubject.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSubject.Location = new System.Drawing.Point(135, 80);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(195, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // cBClass
            // 
            this.cBClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cBClass, 3);
            this.cBClass.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cBClass.FormattingEnabled = true;
            this.cBClass.Location = new System.Drawing.Point(135, 140);
            this.cBClass.Name = "cBClass";
            this.cBClass.Size = new System.Drawing.Size(195, 24);
            this.cBClass.TabIndex = 4;
            // 
            // btSave
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btSave, 2);
            this.btSave.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btSave.Location = new System.Drawing.Point(3, 247);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(126, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "&Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // btCancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btCancel, 2);
            this.btCancel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btCancel.Location = new System.Drawing.Point(201, 247);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(129, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "&Abbrechen";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lbSubject
            // 
            this.lbSubject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSubject.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbSubject, 2);
            this.lbSubject.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbSubject.Location = new System.Drawing.Point(88, 83);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(41, 16);
            this.lbSubject.TabIndex = 2;
            this.lbSubject.Text = "Fach:";
            // 
            // lbClass
            // 
            this.lbClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbClass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbClass, 2);
            this.lbClass.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbClass.Location = new System.Drawing.Point(77, 144);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(52, 16);
            this.lbClass.TabIndex = 3;
            this.lbClass.Text = "Klasse:";
            // 
            // lbGroup
            // 
            this.lbGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroup.Location = new System.Drawing.Point(75, 205);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(54, 16);
            this.lbGroup.TabIndex = 6;
            this.lbGroup.Text = "Gruppe:";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.rBAll);
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rBV);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Controls.Add(this.rBN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(135, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rBAll
            // 
            this.rBAll.AutoSize = true;
            this.rBAll.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rBAll.Location = new System.Drawing.Point(129, 20);
            this.rBAll.Name = "rBAll";
            this.rBAll.Size = new System.Drawing.Size(41, 20);
            this.rBAll.TabIndex = 4;
            this.rBAll.TabStop = true;
            this.rBAll.Text = "All";
            this.rBAll.UseVisualStyleBackColor = true;
            this.rBAll.CheckedChanged += new System.EventHandler(this.rBAll_CheckedChanged);
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rB2.Location = new System.Drawing.Point(81, 32);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(33, 20);
            this.rB2.TabIndex = 3;
            this.rB2.TabStop = true;
            this.rB2.Text = "2";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.rB2_CheckedChanged);
            // 
            // rBV
            // 
            this.rBV.AutoSize = true;
            this.rBV.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rBV.Location = new System.Drawing.Point(7, 32);
            this.rBV.Name = "rBV";
            this.rBV.Size = new System.Drawing.Size(35, 20);
            this.rBV.TabIndex = 2;
            this.rBV.TabStop = true;
            this.rBV.Text = "V";
            this.rBV.UseVisualStyleBackColor = true;
            this.rBV.CheckedChanged += new System.EventHandler(this.rBV_CheckedChanged);
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rB1.Location = new System.Drawing.Point(81, 9);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(33, 20);
            this.rB1.TabIndex = 1;
            this.rB1.TabStop = true;
            this.rB1.Text = "1";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.rB1_CheckedChanged);
            // 
            // rBN
            // 
            this.rBN.AutoSize = true;
            this.rBN.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rBN.Location = new System.Drawing.Point(7, 9);
            this.rBN.Name = "rBN";
            this.rBN.Size = new System.Drawing.Size(35, 20);
            this.rBN.TabIndex = 0;
            this.rBN.TabStop = true;
            this.rBN.Text = "N";
            this.rBN.UseVisualStyleBackColor = true;
            this.rBN.CheckedChanged += new System.EventHandler(this.rBN_CheckedChanged);
            // 
            // addSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSubject";
            this.Text = "Fach hinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbToolTip;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox cBClass;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBAll;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rBV;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rBN;
    }
}