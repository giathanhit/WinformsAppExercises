namespace WinformsAppExercises
{
	partial class ucGiaiPT
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoPTB2 = new System.Windows.Forms.RadioButton();
			this.rdoPTB1 = new System.Windows.Forms.RadioButton();
			this.btnTinhToan = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtKetQua = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoPTB2);
			this.groupBox1.Controls.Add(this.rdoPTB1);
			this.groupBox1.Controls.Add(this.btnTinhToan);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Location = new System.Drawing.Point(337, 210);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 192);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bài toán cần làm";
			// 
			// rdoPTB2
			// 
			this.rdoPTB2.AutoSize = true;
			this.rdoPTB2.Location = new System.Drawing.Point(19, 77);
			this.rdoPTB2.Name = "rdoPTB2";
			this.rdoPTB2.Size = new System.Drawing.Size(115, 17);
			this.rdoPTB2.TabIndex = 16;
			this.rdoPTB2.TabStop = true;
			this.rdoPTB2.Text = "Phương trình bậc 2";
			this.rdoPTB2.UseVisualStyleBackColor = true;
			this.rdoPTB2.CheckedChanged += new System.EventHandler(this.rdoPTB2_CheckedChanged);
			// 
			// rdoPTB1
			// 
			this.rdoPTB1.AutoSize = true;
			this.rdoPTB1.Location = new System.Drawing.Point(19, 30);
			this.rdoPTB1.Name = "rdoPTB1";
			this.rdoPTB1.Size = new System.Drawing.Size(115, 17);
			this.rdoPTB1.TabIndex = 15;
			this.rdoPTB1.TabStop = true;
			this.rdoPTB1.Text = "Phương trình bậc 1";
			this.rdoPTB1.UseVisualStyleBackColor = true;
			this.rdoPTB1.CheckedChanged += new System.EventHandler(this.rdoPTB1_CheckedChanged);
			// 
			// btnTinhToan
			// 
			this.btnTinhToan.Location = new System.Drawing.Point(19, 133);
			this.btnTinhToan.Name = "btnTinhToan";
			this.btnTinhToan.Size = new System.Drawing.Size(75, 33);
			this.btnTinhToan.TabIndex = 2;
			this.btnTinhToan.Text = "Giải";
			this.btnTinhToan.UseVisualStyleBackColor = true;
			this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(100, 133);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Làm mới";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtKetQua
			// 
			this.txtKetQua.Enabled = false;
			this.txtKetQua.Location = new System.Drawing.Point(128, 353);
			this.txtKetQua.Multiline = true;
			this.txtKetQua.Name = "txtKetQua";
			this.txtKetQua.Size = new System.Drawing.Size(173, 49);
			this.txtKetQua.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(64, 358);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Kết quả";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(142, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(329, 25);
			this.label4.TabIndex = 25;
			this.label4.Text = "GIẢI BÀI TẬP PHƯƠNG TRÌNH";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 305);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Số C";
			// 
			// txtB
			// 
			this.txtB.Enabled = false;
			this.txtB.Location = new System.Drawing.Point(128, 246);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(173, 20);
			this.txtB.TabIndex = 20;
			// 
			// txtC
			// 
			this.txtC.Enabled = false;
			this.txtC.Location = new System.Drawing.Point(128, 301);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(173, 20);
			this.txtC.TabIndex = 19;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "Số B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 205);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Số A";
			// 
			// txtA
			// 
			this.txtA.Enabled = false;
			this.txtA.Location = new System.Drawing.Point(128, 202);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(173, 20);
			this.txtA.TabIndex = 18;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(483, 187);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(54, 17);
			this.checkBox1.TabIndex = 17;
			this.checkBox1.Text = "Music";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// ucGiaiPT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtKetQua);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.checkBox1);
			this.Name = "ucGiaiPT";
			this.Size = new System.Drawing.Size(617, 598);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoPTB2;
		private System.Windows.Forms.RadioButton rdoPTB1;
		private System.Windows.Forms.Button btnTinhToan;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtKetQua;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}
