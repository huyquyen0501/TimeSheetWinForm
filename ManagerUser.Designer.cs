﻿namespace TimeSheetWinForm
{
    partial class ManagerUser
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
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnrole = new System.Windows.Forms.Button();
            this.btnmk = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtho = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvuser
            // 
            this.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(13, 12);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowTemplate.Height = 24;
            this.dgvuser.Size = new System.Drawing.Size(981, 293);
            this.dgvuser.TabIndex = 0;
            this.dgvuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvuser_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnrole);
            this.panel1.Controls.Add(this.btnmk);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.dateNgaysinh);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.txtho);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Location = new System.Drawing.Point(10, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 229);
            this.panel1.TabIndex = 1;
            // 
            // btnrole
            // 
            this.btnrole.Location = new System.Drawing.Point(810, 168);
            this.btnrole.Name = "btnrole";
            this.btnrole.Size = new System.Drawing.Size(137, 49);
            this.btnrole.TabIndex = 16;
            this.btnrole.Text = "\r\nRole manage\n";
            this.btnrole.UseVisualStyleBackColor = true;
            this.btnrole.Click += new System.EventHandler(this.btnrole_Click);
            // 
            // btnmk
            // 
            this.btnmk.Location = new System.Drawing.Point(409, 172);
            this.btnmk.Name = "btnmk";
            this.btnmk.Size = new System.Drawing.Size(137, 49);
            this.btnmk.TabIndex = 15;
            this.btnmk.Text = "Re-issue the password";
            this.btnmk.UseVisualStyleBackColor = true;
            this.btnmk.Click += new System.EventHandler(this.btnmk_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(609, 172);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(137, 49);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Deleted";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(204, 172);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(137, 45);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Edit";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(16, 172);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(137, 45);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Add";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(442, 66);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(199, 22);
            this.dateNgaysinh.TabIndex = 11;
            this.dateNgaysinh.Value = new System.DateTime(2020, 4, 8, 10, 31, 57, 0);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(819, 72);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(158, 22);
            this.txtDiachi.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(92, 68);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(181, 22);
            this.txtusername.TabIndex = 9;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(819, 4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(158, 22);
            this.txtten.TabIndex = 2;
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(442, 9);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(199, 22);
            this.txtho.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(92, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(181, 22);
            this.txtid.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(13, 4);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(25, 17);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID:";
            // 
            // ManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvuser);
            this.Name = "ManagerUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagerUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtho;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnmk;
        private System.Windows.Forms.Button btnrole;
    }
}