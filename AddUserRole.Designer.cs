namespace TimeSheetWinForm
{
    partial class AddUserRole
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvuserrole = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbbrole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserrole)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvuserrole);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 210);
            this.panel1.TabIndex = 0;
            // 
            // dgvuserrole
            // 
            this.dgvuserrole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuserrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserrole.Location = new System.Drawing.Point(4, 4);
            this.dgvuserrole.Name = "dgvuserrole";
            this.dgvuserrole.RowTemplate.Height = 24;
            this.dgvuserrole.Size = new System.Drawing.Size(651, 203);
            this.dgvuserrole.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.cbbrole);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 153);
            this.panel2.TabIndex = 1;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(110, 20);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(46, 17);
            this.lbid.TabIndex = 5;
            this.lbid.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID User:";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(468, 86);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(169, 44);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete Roles";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(16, 86);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(169, 44);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Role";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbbrole
            // 
            this.cbbrole.FormattingEnabled = true;
            this.cbbrole.Location = new System.Drawing.Point(361, 17);
            this.cbbrole.Name = "cbbrole";
            this.cbbrole.Size = new System.Drawing.Size(247, 24);
            this.cbbrole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role:";
            // 
            // AddUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUserRole";
            this.Text = "Add User Role";
            this.Load += new System.EventHandler(this.AddUserRole_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserrole)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvuserrole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label2;
    }
}