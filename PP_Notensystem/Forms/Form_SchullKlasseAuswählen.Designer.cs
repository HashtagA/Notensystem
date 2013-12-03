namespace PP_Notensystem.Forms
{
    partial class Form_SchullKlasseAuswählen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridShoolClass = new System.Windows.Forms.DataGridView();
            this.btnSelectSchoolKlass = new System.Windows.Forms.Button();
            this.btnAddSchoolClass = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridShoolClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GridShoolClass, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectSchoolKlass, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSchoolClass, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GridShoolClass
            // 
            this.GridShoolClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.GridShoolClass, 3);
            this.GridShoolClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridShoolClass.Location = new System.Drawing.Point(3, 3);
            this.GridShoolClass.Name = "GridShoolClass";
            this.GridShoolClass.Size = new System.Drawing.Size(458, 196);
            this.GridShoolClass.TabIndex = 0;
            // 
            // btnSelectSchoolKlass
            // 
            this.btnSelectSchoolKlass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectSchoolKlass.Location = new System.Drawing.Point(367, 205);
            this.btnSelectSchoolKlass.Name = "btnSelectSchoolKlass";
            this.btnSelectSchoolKlass.Size = new System.Drawing.Size(94, 54);
            this.btnSelectSchoolKlass.TabIndex = 1;
            this.btnSelectSchoolKlass.Text = "auswählen";
            this.btnSelectSchoolKlass.UseVisualStyleBackColor = true;
            this.btnSelectSchoolKlass.Click += new System.EventHandler(this.btnSelectSchoolKlass_Click);
            // 
            // btnAddSchoolClass
            // 
            this.btnAddSchoolClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSchoolClass.Location = new System.Drawing.Point(267, 205);
            this.btnAddSchoolClass.Name = "btnAddSchoolClass";
            this.btnAddSchoolClass.Size = new System.Drawing.Size(94, 54);
            this.btnAddSchoolClass.TabIndex = 3;
            this.btnAddSchoolClass.Text = "Klasse Hinzufügen";
            this.btnAddSchoolClass.UseVisualStyleBackColor = true;
            this.btnAddSchoolClass.Click += new System.EventHandler(this.btnAddSchoolClass_Click);
            // 
            // Form_SchullKlasseAuswählen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SchullKlasseAuswählen";
            this.ShowIcon = false;
            this.Text = "Klasse auswählen";
            this.Load += new System.EventHandler(this.Form_SchullKlasseAuswählen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridShoolClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView GridShoolClass;
        private System.Windows.Forms.Button btnSelectSchoolKlass;
        private System.Windows.Forms.Button btnAddSchoolClass;
    }
}