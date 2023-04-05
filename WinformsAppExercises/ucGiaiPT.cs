using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAppExercises
{
	public partial class ucGiaiPT : UserControl
	{
		private SoundPlayer sound;
		public ucGiaiPT()
		{
			InitializeComponent();
			sound = new SoundPlayer("thieuthan.wav");
		}

		private void rdoPTB1_CheckedChanged(object sender, EventArgs e)
		{

			if (rdoPTB1.Checked == true)
			{
				txtA.Enabled = true;
				txtB.Enabled = true;
				txtC.Enabled = false;
			}
		}

		private void rdoPTB2_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoPTB2.Checked == true)
			{
				txtA.Enabled = true;
				txtB.Enabled = true;
				txtC.Enabled = true;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

			if (checkBox1.Checked)
			{
				sound.Play();
			}
			else
			{
				sound.Stop();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			txtA.Text = string.Empty;
			txtB.Text = string.Empty;
			txtC.Text = string.Empty;
			txtKetQua.Text = string.Empty;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		public void PTB1()
		{
			if (txtA.Text == "")
			{
				errorProvider2.SetError(txtA, "Vui lòng nhập số A");
			}
			else if (txtB.Text == "")
			{
				errorProvider2.SetError(txtB, "Vui lòng nhập số B");
			}
		}

		public void PTB2()
		{
			if (txtA.Text == "")
			{
				errorProvider2.SetError(txtA, "Vui lòng nhập số A");
			}
			else if (txtB.Text == "")
			{
				errorProvider2.SetError(txtB, "Vui lòng nhập số B");
			}
			else if (txtC.Text == "" && txtC.Enabled == true)
			{
				errorProvider2.SetError(txtC, "Vui lòng nhập số C");
			}
		}

		private void btnTinhToan_Click(object sender, EventArgs e)
		{ 
			try
			{
				errorProvider2.Clear();
				if (rdoPTB1.Checked == true)
				{
					double soA = double.Parse(txtA.Text);
					double soB = double.Parse(txtB.Text);
					PTB1();
					double delta = (double)Math.Round(-soB / soA, 2);
					txtKetQua.Text = "Phương trình có nghiệm là: " + delta;
				}
				else if (rdoPTB2.Checked == true)
				{
					double soA = double.Parse(txtA.Text);
					double soB = double.Parse(txtB.Text);
					double soC = double.Parse(txtC.Text);
					PTB2();
					double delta = (double)Math.Round((soB * soB) - 4 * soA * soC);
					if (delta > 0)
					{
						double x1 = (double)Math.Round((-soB - Math.Sqrt(delta)) / (2 * soA));
						double x2 = (double)Math.Round((-soB + Math.Sqrt(delta)) / (2 * soA));
						txtKetQua.Text = "PT có 2 nghiệm phân biệt: " + " x1 = " + x1 + " và x2 = " + x2 + "";
					}
					else if (delta < 0)
					{
						txtKetQua.Text = "Phương trình vô nghiệm!!";
					}
					else
					{
						double x1 = (double)Math.Round(-soB / soA, 2);
						txtKetQua.Text = "PT có nghiệm kép: " + x1 + "";
					}
				}
				else
				{
					MessageBox.Show("Vui lòng chọn bài toán cần làm", "Thông báo", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
	}
}
