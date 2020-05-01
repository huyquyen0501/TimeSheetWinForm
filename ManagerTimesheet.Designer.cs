namespace TimeSheetWinForm
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimesheet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvtimesheet);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 271);
            this.panel1.TabIndex = 0;
            // 
            // dgvtimesheet
            // 
            this.dgvtimesheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimesheet.Location = new System.Drawing.Point(-11, 3);
            this.dgvtimesheet.Name = "dgvtimesheet";
            this.dgvtimesheet.RowTemplate.Height = 24;
            this.dgvtimesheet.Size = new System.Drawing.Size(1082, 265);
            this.dgvtimesheet.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnreject);
            this.panel2.Controls.Add(this.btnapprove);
            this.panel2.Location = new System.Drawing.Point(13, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 168);
            this.panel2.TabIndex = 1;
            // 
            // btnreject
            // 
            this.btnreject.Location = new System.Drawing.Point(282, 115);
            this.btnreject.Name = "btnreject";
            this.btnreject.Size = new System.Drawing.Size(188, 47);
            this.btnreject.TabIndex = 1;
            this.btnreject.Text = "Reject";
            this.btnreject.UseVisualStyleBackColor = true;
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(22, 115);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(188, 47);
            this.btnapprove.TabIndex = 0;
            this.btnapprove.Text = "Approve ";
            this.btnapprove.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
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
    }
}