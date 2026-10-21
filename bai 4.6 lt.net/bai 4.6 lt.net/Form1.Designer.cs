namespace QuanLySinhVien
{
    partial class Form1
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseAvatar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.grpAvatar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpStudentInfo.SuspendLayout();
            this.grpAvatar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(15, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(67, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Mã sinh viên";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(104, 29);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 67);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(39, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Họ tên";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(104, 64);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 106);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Tuổi";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(104, 99);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // label1lblGender
            // 
            this.label1lblGender.AutoSize = true;
            this.label1lblGender.Location = new System.Drawing.Point(15, 143);
            this.label1lblGender.Name = "label1lblGender";
            this.label1lblGender.Size = new System.Drawing.Size(47, 13);
            this.label1lblGender.TabIndex = 6;
            this.label1lblGender.Text = "Giới tính";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(104, 140);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 21);
            this.cboGender.TabIndex = 7;
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(60, 19);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(161, 137);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 8;
            this.picAvatar.TabStop = false;
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.Location = new System.Drawing.Point(99, 171);
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnChooseAvatar.TabIndex = 9;
            this.btnChooseAvatar.Text = "Chọn Ảnh";
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 38);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(708, 300);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(130, 38);
            this.btnExportCsv.TabIndex = 13;
            this.btnExportCsv.Text = "Xuất CSV";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(20, 355);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(940, 240);
            this.dgvStudents.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 30);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "QUẢN LÝ SINH VIÊN ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.lblStudentId);
            this.grpStudentInfo.Controls.Add(this.txtStudentId);
            this.grpStudentInfo.Controls.Add(this.lblFullName);
            this.grpStudentInfo.Controls.Add(this.txtFullName);
            this.grpStudentInfo.Controls.Add(this.lblAge);
            this.grpStudentInfo.Controls.Add(this.txtAge);
            this.grpStudentInfo.Controls.Add(this.label1lblGender);
            this.grpStudentInfo.Controls.Add(this.cboGender);
            this.grpStudentInfo.Location = new System.Drawing.Point(20, 75);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(640, 210);
            this.grpStudentInfo.TabIndex = 16;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Thông tin sinh viên";
            // 
            // grpAvatar
            // 
            this.grpAvatar.Controls.Add(this.picAvatar);
            this.grpAvatar.Controls.Add(this.btnChooseAvatar);
            this.grpAvatar.Location = new System.Drawing.Point(680, 75);
            this.grpAvatar.Name = "grpAvatar";
            this.grpAvatar.Size = new System.Drawing.Size(280, 210);
            this.grpAvatar.TabIndex = 17;
            this.grpAvatar.TabStop = false;
            this.grpAvatar.Text = "Ảnh đại diện";
            // 
            // frmStudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.grpAvatar);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStudentManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpAvatar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseAvatar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.GroupBox grpAvatar;
    }
}

