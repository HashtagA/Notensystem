namespace PP_Notensystem
{
    partial class addClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addClassForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEnddate = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.dpPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.dpPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.turnusNumberRodioButtonGroup = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lbToolTip = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.turnusNumberRodioButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbClass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPeriod, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbStartDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbEnddate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbClassName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dpPeriodStart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dpPeriodEnd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.turnusNumberRodioButtonGroup, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbToolTip, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 265);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbClass
            // 
            this.lbClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbClass.Location = new System.Drawing.Point(3, 51);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(87, 16);
            this.lbClass.TabIndex = 1;
            this.lbClass.Text = "Klassenname";
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbPeriod.Location = new System.Drawing.Point(3, 96);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(68, 16);
            this.lbPeriod.TabIndex = 2;
            this.lbPeriod.Text = "Turnus Nr:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbStartDate.Location = new System.Drawing.Point(3, 149);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(160, 16);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = "Start Datum des Turnuses";
            // 
            // lbEnddate
            // 
            this.lbEnddate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEnddate.AutoSize = true;
            this.lbEnddate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbEnddate.Location = new System.Drawing.Point(3, 195);
            this.lbEnddate.Name = "lbEnddate";
            this.lbEnddate.Size = new System.Drawing.Size(155, 16);
            this.lbEnddate.TabIndex = 4;
            this.lbEnddate.Text = "End Datum des Turnuses";
            // 
            // tbClassName
            // 
            this.tbClassName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbClassName.Location = new System.Drawing.Point(228, 48);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(210, 22);
            this.tbClassName.TabIndex = 5;
            // 
            // dpPeriodStart
            // 
            this.dpPeriodStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dpPeriodStart.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dpPeriodStart.Location = new System.Drawing.Point(228, 146);
            this.dpPeriodStart.Name = "dpPeriodStart";
            this.dpPeriodStart.Size = new System.Drawing.Size(210, 22);
            this.dpPeriodStart.TabIndex = 10;
            // 
            // dpPeriodEnd
            // 
            this.dpPeriodEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dpPeriodEnd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dpPeriodEnd.Location = new System.Drawing.Point(228, 192);
            this.dpPeriodEnd.Name = "dpPeriodEnd";
            this.dpPeriodEnd.Size = new System.Drawing.Size(210, 22);
            this.dpPeriodEnd.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btCancel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 229);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 32);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAdd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btAdd.Location = new System.Drawing.Point(3, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(103, 26);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "&Hinzufügen";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btCancel.Location = new System.Drawing.Point(117, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(99, 26);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "&Abbrechen";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // turnusNumberRodioButtonGroup
            // 
            this.turnusNumberRodioButtonGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.turnusNumberRodioButtonGroup.Controls.Add(this.rb4);
            this.turnusNumberRodioButtonGroup.Controls.Add(this.rb2);
            this.turnusNumberRodioButtonGroup.Controls.Add(this.rb3);
            this.turnusNumberRodioButtonGroup.Controls.Add(this.rb1);
            this.turnusNumberRodioButtonGroup.Location = new System.Drawing.Point(225, 75);
            this.turnusNumberRodioButtonGroup.Margin = new System.Windows.Forms.Padding(0);
            this.turnusNumberRodioButtonGroup.Name = "turnusNumberRodioButtonGroup";
            this.turnusNumberRodioButtonGroup.Size = new System.Drawing.Size(213, 59);
            this.turnusNumberRodioButtonGroup.TabIndex = 12;
            this.turnusNumberRodioButtonGroup.TabStop = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rb4.Location = new System.Drawing.Point(131, 36);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(33, 20);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rb2.Location = new System.Drawing.Point(131, 13);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(33, 20);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rb3.Location = new System.Drawing.Point(32, 36);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(33, 20);
            this.rb3.TabIndex = 1;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rb1.Location = new System.Drawing.Point(32, 13);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(33, 20);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // lbToolTip
            // 
            this.lbToolTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbToolTip.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbToolTip, 2);
            this.lbToolTip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToolTip.Location = new System.Drawing.Point(113, 6);
            this.lbToolTip.Name = "lbToolTip";
            this.lbToolTip.Size = new System.Drawing.Size(223, 32);
            this.lbToolTip.TabIndex = 0;
            this.lbToolTip.Text = "Bitte füllen Sie die Informationen aus:\r\n\r\n";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // addClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addClassForm";
            this.Text = "Klasse Hinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.turnusNumberRodioButtonGroup.ResumeLayout(false);
            this.turnusNumberRodioButtonGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbToolTip;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEnddate;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DateTimePicker dpPeriodStart;
        private System.Windows.Forms.DateTimePicker dpPeriodEnd;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox turnusNumberRodioButtonGroup;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btCancel;
    }
}