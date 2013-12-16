namespace PP_Notensystem.Forms
{
    partial class Form_DatensatzAuswählen
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
            this.GridData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectData = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridData
            // 
            this.GridData.AllowUserToAddRows = false;
            this.GridData.AllowUserToDeleteRows = false;
            this.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.GridData, 3);
            this.GridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridData.Location = new System.Drawing.Point(3, 3);
            this.GridData.Name = "GridData";
            this.GridData.Size = new System.Drawing.Size(487, 270);
            this.GridData.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GridData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddData, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 336);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSelectData
            // 
            this.btnSelectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectData.Location = new System.Drawing.Point(396, 279);
            this.btnSelectData.Name = "btnSelectData";
            this.btnSelectData.Size = new System.Drawing.Size(94, 54);
            this.btnSelectData.TabIndex = 1;
            this.btnSelectData.Text = "auswählen";
            this.btnSelectData.UseVisualStyleBackColor = true;
            this.btnSelectData.Click += new System.EventHandler(this.btnSelectData_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddData.Location = new System.Drawing.Point(296, 279);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(94, 54);
            this.btnAddData.TabIndex = 3;
            this.btnAddData.Text = "Neu Hinzufügen";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // Form_DatensatzAuswählen
            // 
            this.AcceptButton = this.btnSelectData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DatensatzAuswählen";
            this.ShowIcon = false;
            this.Text = "Datensatz auswhälen";
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSelectData;
        private System.Windows.Forms.Button btnAddData;
    }
}