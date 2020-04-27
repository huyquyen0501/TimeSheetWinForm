namespace TimeSheetWinForm
{
    partial class ManageMyTimesheet
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
            this.dgvmytimesheet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtend = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtstart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxtaskname = new System.Windows.Forms.ComboBox();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkischarged = new System.Windows.Forms.CheckBox();
            this.cbtypeofwork = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtworkingtime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtdateat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbprojectname = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnapprove = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmytimesheet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvmytimesheet);
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 233);
            this.panel1.TabIndex = 0;
            // 
            // dgvmytimesheet
            // 
            this.dgvmytimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmytimesheet.Location = new System.Drawing.Point(3, 4);
            this.dgvmytimesheet.Name = "dgvmytimesheet";
            this.dgvmytimesheet.RowTemplate.Height = 24;
            this.dgvmytimesheet.Size = new System.Drawing.Size(975, 226);
            this.dgvmytimesheet.TabIndex = 0;
            this.dgvmytimesheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmytimesheet_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtend);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtstart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 33);
            this.panel2.TabIndex = 1;
            // 
            // dtend
            // 
            this.dtend.Location = new System.Drawing.Point(744, 4);
            this.dtend.Name = "dtend";
            this.dtend.Size = new System.Drawing.Size(212, 22);
            this.dtend.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian kết thúc:";
            // 
            // dtstart
            // 
            this.dtstart.Location = new System.Drawing.Point(134, 4);
            this.dtstart.Name = "dtstart";
            this.dtstart.Size = new System.Drawing.Size(212, 22);
            this.dtstart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian bắt đầu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbxtaskname);
            this.panel3.Controls.Add(this.txtnote);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.checkischarged);
            this.panel3.Controls.Add(this.cbtypeofwork);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtworkingtime);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtdateat);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbprojectname);
            this.panel3.Location = new System.Drawing.Point(16, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 106);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Task Name:";
            // 
            // cbxtaskname
            // 
            this.cbxtaskname.FormattingEnabled = true;
            this.cbxtaskname.Location = new System.Drawing.Point(392, 3);
            this.cbxtaskname.Name = "cbxtaskname";
            this.cbxtaskname.Size = new System.Drawing.Size(143, 24);
            this.cbxtaskname.TabIndex = 15;
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(751, 59);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(221, 22);
            this.txtnote.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Note:";
            // 
            // checkischarged
            // 
            this.checkischarged.AutoSize = true;
            this.checkischarged.Location = new System.Drawing.Point(862, 8);
            this.checkischarged.Name = "checkischarged";
            this.checkischarged.Size = new System.Drawing.Size(94, 21);
            this.checkischarged.TabIndex = 12;
            this.checkischarged.Text = "IsCharged";
            this.checkischarged.UseVisualStyleBackColor = true;
            // 
            // cbtypeofwork
            // 
            this.cbtypeofwork.FormattingEnabled = true;
            this.cbtypeofwork.Location = new System.Drawing.Point(647, 3);
            this.cbtypeofwork.Name = "cbtypeofwork";
            this.cbtypeofwork.Size = new System.Drawing.Size(192, 24);
            this.cbtypeofwork.TabIndex = 11;
            this.cbtypeofwork.SelectedIndexChanged += new System.EventHandler(this.cbtypeofwork_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type Of Work:";
            // 
            // txtworkingtime
            // 
            this.txtworkingtime.Location = new System.Drawing.Point(484, 54);
            this.txtworkingtime.Mask = "00";
            this.txtworkingtime.Name = "txtworkingtime";
            this.txtworkingtime.Size = new System.Drawing.Size(192, 22);
            this.txtworkingtime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Working Time:";
            // 
            // dtdateat
            // 
            this.dtdateat.Location = new System.Drawing.Point(106, 56);
            this.dtdateat.Name = "dtdateat";
            this.dtdateat.Size = new System.Drawing.Size(202, 22);
            this.dtdateat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date At:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project Name:";
            // 
            // cbprojectname
            // 
            this.cbprojectname.FormattingEnabled = true;
            this.cbprojectname.Location = new System.Drawing.Point(116, 5);
            this.cbprojectname.Name = "cbprojectname";
            this.cbprojectname.Size = new System.Drawing.Size(153, 24);
            this.cbprojectname.TabIndex = 0;
            this.cbprojectname.SelectedIndexChanged += new System.EventHandler(this.cbprojectname_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnapprove);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Location = new System.Drawing.Point(16, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 94);
            this.panel4.TabIndex = 3;
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(205, 4);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(141, 32);
            this.btnapprove.TabIndex = 1;
            this.btnapprove.Text = "Approve";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(7, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 32);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // ManageMyTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMyTimesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageMyTimesheet";
            this.Load += new System.EventHandler(this.ManageMyTimesheet_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmytimesheet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvmytimesheet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtdateat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbprojectname;
        private System.Windows.Forms.MaskedTextBox txtworkingtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkischarged;
        private System.Windows.Forms.ComboBox cbtypeofwork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxtaskname;
    }
}