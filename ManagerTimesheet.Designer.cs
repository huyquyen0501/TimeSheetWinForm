﻿namespace TimeSheetWinForm
{
    partial class ManagerTimesheet
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
            this.dgvtimesheet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnreject = new System.Windows.Forms.Button();
            this.btnapprove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbstatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimesheet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbstatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvtimesheet);
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 326);
            this.panel1.TabIndex = 0;
            // 
            // dgvtimesheet
            // 
            this.dgvtimesheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimesheet.Location = new System.Drawing.Point(3, 58);
            this.dgvtimesheet.Name = "dgvtimesheet";
            this.dgvtimesheet.RowTemplate.Height = 24;
            this.dgvtimesheet.Size = new System.Drawing.Size(1068, 265);
            this.dgvtimesheet.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnreject);
            this.panel2.Controls.Add(this.btnapprove);
            this.panel2.Location = new System.Drawing.Point(13, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 115);
            this.panel2.TabIndex = 1;
            // 
            // btnreject
            // 
            this.btnreject.Location = new System.Drawing.Point(283, 59);
            this.btnreject.Name = "btnreject";
            this.btnreject.Size = new System.Drawing.Size(188, 47);
            this.btnreject.TabIndex = 1;
            this.btnreject.Text = "Reject";
            this.btnreject.UseVisualStyleBackColor = true;
            this.btnreject.Click += new System.EventHandler(this.btnreject_Click);
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(22, 59);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(188, 47);
            this.btnapprove.TabIndex = 0;
            this.btnapprove.Text = "Approve ";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // cbbstatus
            // 
            this.cbbstatus.FormattingEnabled = true;
            this.cbbstatus.Location = new System.Drawing.Point(103, 7);
            this.cbbstatus.Name = "cbbstatus";
            this.cbbstatus.Size = new System.Drawing.Size(214, 24);
            this.cbbstatus.TabIndex = 2;
            this.cbbstatus.SelectedIndexChanged += new System.EventHandler(this.cbbstatus_SelectedIndexChanged);
            // 
            // ManagerTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerTimesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagerTimesheet";
            this.Load += new System.EventHandler(this.ManagerTimesheet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimesheet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvtimesheet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnreject;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.ComboBox cbbstatus;
        private System.Windows.Forms.Label label1;
    }
}