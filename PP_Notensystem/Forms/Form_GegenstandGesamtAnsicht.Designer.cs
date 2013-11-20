namespace PP_Notensystem
{
    partial class Form_GegenstandGesamtAnsicht
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GegenstandGesamtAnsicht));
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.dgvGeneralView = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.Location = new System.Drawing.Point(12, 9);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(109, 22);
            this.lblHeadline.TabIndex = 11;
            this.lblHeadline.Text = "Notensystem";
            // 
            // lblSubject
            // 
            this.lblSubject.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(646, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(80, 22);
            this.lblSubject.TabIndex = 12;
            this.lblSubject.Text = "APHM";
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(560, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(80, 22);
            this.lblClass.TabIndex = 13;
            this.lblClass.Text = "4aBUKO";
            // 
            // lblGroup
            // 
            this.lblGroup.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(732, 9);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(40, 22);
            this.lblGroup.TabIndex = 14;
            this.lblGroup.Text = "V";
            // 
            // dgvGeneralView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneralView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGeneralView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student});
            this.dgvGeneralView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGeneralView.Location = new System.Drawing.Point(0, 34);
            this.dgvGeneralView.Name = "dgvGeneralView";
            this.dgvGeneralView.ReadOnly = true;
            this.dgvGeneralView.Size = new System.Drawing.Size(784, 428);
            this.dgvGeneralView.TabIndex = 15;
            this.dgvGeneralView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneralView_CellContentClick);
            // 
            // Student
            // 
            this.Student.HeaderText = "Schüler";
            this.Student.MinimumWidth = 200;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            this.Student.Width = 250;
            // 
            // Form_GegenstandGesamtAnsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.dgvGeneralView);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblHeadline);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_GegenstandGesamtAnsicht";
            this.Text = "Fachübersicht";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.DataGridView dgvGeneralView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
    }
}