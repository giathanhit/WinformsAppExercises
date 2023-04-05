namespace WinformsAppExercises
{
	partial class ucSoLonNhat
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoSoNhoNhat = new System.Windows.Forms.RadioButton();
			this.rdoSoLonNhat = new System.Windows.Forms.RadioButton();
			this.btnGiai = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtKetQua = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtC);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.txtKetQua);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtA);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(617, 598);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoSoNhoNhat);
			this.groupBox1.Controls.Add(this.rdoSoLonNhat);
			this.groupBox1.Controls.Add(this.btnGiai);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Location = new System.Drawing.Point(330, 208);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 192);
			this.groupBox1.TabIndex = 44;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bài toán cần làm";
			// 
			// rdoSoNhoNhat
			// 
			this.rdoSoNhoNhat.AutoSize = true;
			this.rdoSoNhoNhat.Location = new System.Drawing.Point(19, 77);
			this.rdoSoNhoNhat.Name = "rdoSoNhoNhat";
			this.rdoSoNhoNhat.Size = new System.Drawing.Size(101, 17);
			this.rdoSoNhoNhat.TabIndex = 16;
			this.rdoSoNhoNhat.TabStop = true;
			this.rdoSoNhoNhat.Text = "Tìm số nhỏ nhất";
			this.rdoSoNhoNhat.UseVisualStyleBackColor = true;
			this.rdoSoNhoNhat.CheckedChanged += new System.EventHandler(this.rdoSoNhoNhat_CheckedChanged);
			// 
			// rdoSoLonNhat
			// 
			this.rdoSoLonNhat.AutoSize = true;
			this.rdoSoLonNhat.Location = new System.Drawing.Point(19, 30);
			this.rdoSoLonNhat.Name = "rdoSoLonNhat";
			this.rdoSoLonNhat.Size = new System.Drawing.Size(97, 17);
			this.rdoSoLonNhat.TabIndex = 15;
			this.rdoSoLonNhat.TabStop = true;
			this.rdoSoLonNhat.Text = "Tìm số lớn nhất";
			this.rdoSoLonNhat.UseVisualStyleBackColor = true;
			this.rdoSoLonNhat.CheckedChanged += new System.EventHandler(this.rdoSoLonNhat_CheckedChanged);
			// 
			// btnGiai
			// 
			this.btnGiai.Location = new System.Drawing.Point(19, 133);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(75, 33);
			this.btnGiai.TabIndex = 2;
			this.btnGiai.Text = "Giải";
			this.btnGiai.UseVisualStyleBackColor = true;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
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
			this.txtKetQua.Location = new System.Drawing.Point(121, 351);
			this.txtKetQua.Multiline = true;
			this.txtKetQua.Name = "txtKetQua";
			this.txtKetQua.Size = new System.Drawing.Size(173, 49);
			this.txtKetQua.TabIndex = 42;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 354);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 43;
			this.label5.Text = "Kết quả";
			// 
			// txtB
			// 
			this.txtB.Enabled = false;
			this.txtB.Location = new System.Drawing.Point(121, 257);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(173, 20);
			this.txtB.TabIndex = 38;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 262);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 40;
			this.label2.Text = "Số B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "Số A";
			// 
			// txtA
			// 
			this.txtA.Enabled = false;
			this.txtA.Location = new System.Drawing.Point(121, 213);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(173, 20);
			this.txtA.TabIndex = 37;
			// 
			// txtC
			// 
			this.txtC.Enabled = false;
			this.txtC.Location = new System.Drawing.Point(121, 304);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(173, 20);
			this.txtC.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 307);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 46;
			this.label3.Text = "Số C";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(153, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(304, 25);
			this.label4.TabIndex = 47;
			this.label4.Text = "SỐ LỚN NHẤT - NHỎ NHẤT";
			// 
			// ucSoLonNhat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "ucSoLonNhat";
			this.Size = new System.Drawing.Size(617, 598);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoSoNhoNhat;
		private System.Windows.Forms.RadioButton rdoSoLonNhat;
		private System.Windows.Forms.Button btnGiai;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtKetQua;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}
