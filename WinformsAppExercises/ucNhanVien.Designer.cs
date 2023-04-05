namespace WinformsAppExercises
{
	partial class ucNhanVien
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgvDanhSach = new System.Windows.Forms.DataGridView();
			this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.winformsExercisesDataSet = new WinformsAppExercises.WinformsExercisesDataSet();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.nhanVienTableAdapter = new WinformsAppExercises.WinformsExercisesDataSetTableAdapters.NhanVienTableAdapter();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.winformsExercisesDataSet)).BeginInit();
			this.panel3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel4.Controls.Add(this.dgvDanhSach);
			this.panel4.Location = new System.Drawing.Point(0, 329);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(617, 269);
			this.panel4.TabIndex = 4;
			// 
			// dgvDanhSach
			// 
			this.dgvDanhSach.AllowUserToAddRows = false;
			this.dgvDanhSach.AllowUserToDeleteRows = false;
			this.dgvDanhSach.AutoGenerateColumns = false;
			this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.SDT,
            this.DiaChi});
			this.dgvDanhSach.DataSource = this.nhanVienBindingSource;
			this.dgvDanhSach.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dgvDanhSach.Location = new System.Drawing.Point(3, 3);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.ReadOnly = true;
			this.dgvDanhSach.Size = new System.Drawing.Size(611, 263);
			this.dgvDanhSach.TabIndex = 0;
			this.dgvDanhSach.VirtualMode = true;
			this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
			// 
			// nhanVienBindingSource
			// 
			this.nhanVienBindingSource.DataMember = "NhanVien";
			this.nhanVienBindingSource.DataSource = this.winformsExercisesDataSet;
			// 
			// winformsExercisesDataSet
			// 
			this.winformsExercisesDataSet.DataSetName = "WinformsExercisesDataSet";
			this.winformsExercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel3.Controls.Add(this.groupBox2);
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(617, 329);
			this.panel3.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnLamMoi);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnCapNhat);
			this.groupBox2.Controls.Add(this.btnLuu);
			this.groupBox2.Location = new System.Drawing.Point(373, 98);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(230, 188);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(26, 55);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(75, 33);
			this.btnLamMoi.TabIndex = 3;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(129, 103);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 33);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(26, 103);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 33);
			this.btnCapNhat.TabIndex = 1;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(129, 55);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 33);
			this.btnLuu.TabIndex = 0;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.txtSDT);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.Location = new System.Drawing.Point(14, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin";
			// 
			// txtMaNV
			// 
			this.txtMaNV.BackColor = System.Drawing.Color.LightBlue;
			this.txtMaNV.Enabled = false;
			this.txtMaNV.Location = new System.Drawing.Point(102, 36);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(217, 20);
			this.txtMaNV.TabIndex = 14;
			this.txtMaNV.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Mã NV";
			this.label5.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Địa chỉ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "SĐT";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Tên";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(102, 152);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(217, 20);
			this.txtDiaChi.TabIndex = 2;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(102, 112);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(217, 20);
			this.txtSDT.TabIndex = 1;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(102, 74);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(217, 20);
			this.txtTen.TabIndex = 0;
			// 
			// nhanVienTableAdapter
			// 
			this.nhanVienTableAdapter.ClearBeforeFill = true;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã NV";
			this.MaNV.Name = "MaNV";
			this.MaNV.ReadOnly = true;
			this.MaNV.Visible = false;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên NV";
			this.TenNV.Name = "TenNV";
			this.TenNV.ReadOnly = true;
			// 
			// SDT
			// 
			this.SDT.DataPropertyName = "SDT";
			this.SDT.HeaderText = "SĐT";
			this.SDT.Name = "SDT";
			this.SDT.ReadOnly = true;
			// 
			// DiaChi
			// 
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "Địa chỉ";
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.ReadOnly = true;
			// 
			// ucNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.Name = "ucNhanVien";
			this.Size = new System.Drawing.Size(617, 598);
			this.Load += new System.EventHandler(this.ucNhanVien_Load);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.winformsExercisesDataSet)).EndInit();
			this.panel3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dgvDanhSach;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.BindingSource nhanVienBindingSource;
		private WinformsExercisesDataSet winformsExercisesDataSet;
		private WinformsExercisesDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
	}
}
