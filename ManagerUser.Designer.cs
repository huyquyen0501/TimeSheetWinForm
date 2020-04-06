namespace TimeSheetWinForm
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnmk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvuser
            // 
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
            this.panel1.Location = new System.Drawing.Point(13, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 229);
            this.panel1.TabIndex = 1;
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(497, 62);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(199, 22);
            this.dateNgaysinh.TabIndex = 11;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(497, 139);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(199, 22);
            this.txtDiachi.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(497, 0);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(199, 22);
            this.txtusername.TabIndex = 9;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(72, 141);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(199, 22);
            this.txtten.TabIndex = 2;
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(72, 65);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(199, 22);
            this.txtho.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(72, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(199, 22);
            this.txtid.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(13, 4);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(21, 17);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(828, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(137, 41);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(828, 62);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(137, 41);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(828, 175);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(137, 41);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnmk
            // 
            this.btnmk.Location = new System.Drawing.Point(828, 120);
            this.btnmk.Name = "btnmk";
            this.btnmk.Size = new System.Drawing.Size(137, 41);
            this.btnmk.TabIndex = 15;
            this.btnmk.Text = "Cấp lại mật khẩu";
            this.btnmk.UseVisualStyleBackColor = true;
            this.btnmk.Click += new System.EventHandler(this.btnmk_Click);
            // 
            // ManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
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
    }
}